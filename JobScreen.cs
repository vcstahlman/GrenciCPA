/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is the heaviest page in the project. it takes in information from the clients the characteristics jobs services and times as well as makes its components
/// it is used for billing and creation of items for an invoice. the user can also keep track of time on this page.
/// the user can save or complete to go onto the invoiceing area.
///

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;


namespace GrenciCPA
{
    public partial class JobScreen : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        //timer stuff
        private TimeSpan time;
        private DateTime timeStart;


        //information holders
        private AClient ClientsObj;
        private int clientID;
        private int jobID;        
        private int parentID;
        private int staffID = 0;
        private decimal jobTotal;
        private bool afterLoad = false;
        private bool isActive = true;
        
        //lists and lists again
        private List<AComp> componentList = new List<AComp>();
        private List<AServ> serviceList = new List<AServ>();
        private List<AChar> characteristicList = new List<AChar>();
        private List<ATime> timeList = new List<ATime>();
        private List<AStaff> staffList = new List<AStaff>();

        


        //constructor runs through the functions and fills out the page for use
        public JobScreen(int pClient, int pjob)
        {
            InitializeComponent();
            clientID = pClient;
            jobID = pjob;
            ClientsObj = new AClient();
            CreateClientList();
            FillClientInfo();


            GetServChar();
            FillComponents();
            

            GetTime();
            FillTimes();
            GetJobStaff();

            
        }

        
        //when loading the page it will set the comboboxes and their values
        private void JobScreen_Load(object sender, EventArgs e)
        {

            
            (dgvFees.Columns[2] as DataGridViewComboBoxColumn).DataSource = characteristicList;
            (dgvFees.Columns[2] as DataGridViewComboBoxColumn).DisplayMember = "CharName";
            (dgvFees.Columns[2] as DataGridViewComboBoxColumn).ValueMember = "CharID";

            (dgvFees.Columns[1] as DataGridViewComboBoxColumn).DataSource = serviceList;
            (dgvFees.Columns[1] as DataGridViewComboBoxColumn).DisplayMember = "ServName";
            (dgvFees.Columns[1] as DataGridViewComboBoxColumn).ValueMember = "ServID";
            

            activeCheck();
            afterLoad = true;

        }


        //\\\\\\\\\\\\\\\\\\\\BUTTONS\\\\\\\\\\\\\\\\


        // this button allows the user to change client information, like home address or telephone number, and inputs the new info to the jobScreen
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            ClientView form = new ClientView(clientID);
            form.Show();
        }

        // To ensure user saves all information before completing a job, we have entered in this message prompt as a reminder
        private void button3_Click(object sender, EventArgs e)
        {//this is the close button

            if(btnTimer.Text == "Stop Timer")
            {

                DateTime timeEnd = DateTime.Now;
                btnTimer.Text = "Start Timer";

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                dgvTime.Rows.Insert(0, new string[] { (DateTime.Now - timeStart).ToString(), timeStart.ToString(), DateTime.Now.ToString(), timeDesc });
                SaveTime(timeDesc);//saves it to the database as well.

                time.Add(timeEnd.Subtract(timeStart));
                
            }

            string message = "If you close now, any unsaved changes may be lost. Are you sure you want to continue?";
            string title = "Confirm Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Working timer, this is pivotal to the form as clients are charged for services based on an hourly rate
        private void btnTimer_Click(object sender, EventArgs e)
        {

            if (btnTimer.Text == "Start Timer")
            {
                btnTimer.Text = "Stop Timer";
                timeStart = DateTime.Now;
                


            }
            else
            {

                DateTime timeEnd = DateTime.Now;
                btnTimer.Text = "Start Timer";

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                dgvTime.Rows.Insert(0, new string[] { (DateTime.Now - timeStart).ToString(), timeStart.ToString(), DateTime.Now.ToString(), timeDesc});
                SaveTime(timeDesc);//saves it to the database as well.

                time.Add(timeEnd.Subtract(timeStart));
                
            }

            GetTime();


        }

        // Once the Complete button is clicked, the user will be taken to the Invoice form with services and amount listed
        private void btnComplete_Click(object sender, EventArgs e)
        {
            SavePage();

            

            InvoiceScreen form = new InvoiceScreen(jobID, jobTotal);//pass the jobID and the total
            form.ShowDialog();
            this.Close();
        }

        // Allows the user to edit the timer incase of user error (ex. forgot to click the Start Timer button or let it run for too long)

        //******************** needs functionality
        private void btnEditTime_Click(object sender, EventArgs e)
        {
            if (btnEditTime.Text == "Edit Time")
            {
                
                lblAddTime.Visible = true;
                txtAddTime.Visible = true;
                lblSubtractTime.Visible = true;
                txtSubtract.Visible = true;

                btnEditTime.Text = "Finish Editing";
            }

            else
            {
                
                lblAddTime.Visible = false;
                lblSubtractTime.Visible = false;
                int tadd = 0;
                int.TryParse(txtAddTime.Text, out tadd);
                txtAddTime.Text = "";
                txtAddTime.Visible = false;
                int tsub = 0;
                int.TryParse(txtSubtract.Text, out tsub);
                txtSubtract.Text = "";
                txtSubtract.Visible = false;
                

                int tedit = tadd - tsub;

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                btnEditTime.Text = "Edit Time";

                DateTime timeEnd = DateTime.Now;
                TimeSpan span = new TimeSpan(0, tedit, 0);
                

                time.Add(timeEnd.Subtract(timeStart));
                lblTime.Text = "Total Elapsed Time: " + String.Format("{0:0.00}", time.TotalHours + span.TotalHours) + " hours";


                string SetEditSQL = "INSERT INTO TIME_TABLE(JOB_ID, START_TIME, END_TIME, TIME_DESCRIPT)  " +
                        " VALUES (@pJobID, @pStart, @pEnd, @pDescript)";
                //Pulled from App.config
                connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                try
                {
                    connection = new SqlConnection(connectionString);
                    command = new SqlCommand(SetEditSQL, connection);
                    //Open the connection
                    connection.Open();


                    command.Parameters.AddWithValue("@pJobID", jobID);
                    command.Parameters.AddWithValue("@pStart", DateTime.Now.Subtract(span));
                    command.Parameters.AddWithValue("@pEnd", DateTime.Now);
                    command.Parameters.AddWithValue("@pDescript", timeDesc);


                    int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                    connection.Close();
                    dgvTime.Rows.Insert(0, new string[] { (DateTime.Now - DateTime.Now.Subtract(span)).ToString(), DateTime.Now.Subtract(span).ToString(), DateTime.Now.ToString(), timeDesc });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not add time.! \n Error reads: " + ex.Message);
                }

            }
            GetTime();
        }

        //saves the page via the savePage operation and it makes a box to tell you that it saved
        private void btnSave_Click(object sender, EventArgs e)
                {

                    SavePage();
            
                    string message = "Save Complete";
                    string title = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }

                }

        //\\\\\\\\\\\\\\MAIN SAVE\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void SavePage()
        {

            //this makes the rows save fully in case they did not click on the datagrid after a calculation
            jobTotal = 0;// retotal every move 
            for (int i = 0; i < dgvFees.RowCount; i++)
            {
                decimal newcost = 0;
                decimal newmulti = 0;

                if (dgvFees.Rows[i].Cells[3].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out newcost);
                if (dgvFees.Rows[i].Cells[4].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out newmulti);

                decimal newtotal = newcost * newmulti;//if it is less it will be overwriten, if not it will be fine.
                dgvFees.Rows[i].Cells[5].Value = string.Format("{0:#,0.00}", newtotal);//if the new total is more than the one in there it will rewrite.


                jobTotal += newtotal;
            }
            lblTotal.Text = "Total: $" + string.Format("{0:#,0.00}", jobTotal);

            componentList.Clear();

            foreach (DataGridViewRow row in dgvFees.Rows)//goes through the dgv and saves items to the page
            {
                int i = row.Index;
                AComp temp = new AComp();
                temp.Row = row.Index;

                //retrives the numbers from the dgv and saves them to the comp

                int inOutInt = 0;
                if (dgvFees.Rows[i].Cells[0].Value != null)
                    int.TryParse(dgvFees.Rows[i].Cells[0].Value.ToString(), out inOutInt);
                if (inOutInt != 0) temp.Component_ID = inOutInt;

                //only need the ids for the save so we are making sure that we watch the list to the dgv
                inOutInt = 0;
                if (dgvFees.Rows[i].Cells[1].Value != null)
                    int.TryParse(dgvFees.Rows[i].Cells[1].Value.ToString(), out inOutInt);
                temp.Serv_ID = inOutInt;

                inOutInt = 0;
                if (dgvFees.Rows[i].Cells[2].Value != null)
                    int.TryParse(dgvFees.Rows[i].Cells[2].Value.ToString(), out inOutInt);
                temp.Char_ID = inOutInt;


                decimal inOutDub = 0.00m;
                if (dgvFees.Rows[i].Cells[3].Value != null)
                    decimal.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out inOutDub);
                temp.Char_cost = inOutDub;

                inOutDub = 0.00m;
                if (dgvFees.Rows[i].Cells[4].Value != null)
                    decimal.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out inOutDub);
                temp.Char_multi = inOutDub;

                inOutDub = 0.00m;
                if (dgvFees.Rows[i].Cells[5].Value != null)
                    decimal.TryParse(dgvFees.Rows[i].Cells[5].Value.ToString(), out inOutDub);
                temp.Total = inOutDub;



                temp.SortInt = 1;

                if (temp.Serv_ID == 0 && temp.Char_ID == 0)
                    temp.SortInt = 3;//this marks it to not save due to having no information

                componentList.Add(temp);


            }


            //this travels through the datagridview and checks if the current row is saved at all
            for (int i = 0; i < dgvFees.Rows.Count; i++)
            {
                foreach (AComp aComp in componentList)
                {
                    if (dgvFees.Rows[i].Cells[0].Value == null) continue;//if saved in component
                    else if (dgvFees.Rows[i].Cells[0].Value.ToString() == aComp.Component_ID.ToString())
                    {
                        if (dgvFees.Rows[i].Cells[1].Value != null)
                            aComp.Serv_ID = int.Parse(dgvFees.Rows[i].Cells[1].Value.ToString());
                        else aComp.Serv_ID = 0;
                        //reads in the string for the serv
                        if (dgvFees.Rows[i].Cells[2].Value != null)
                            aComp.Char_ID = int.Parse(dgvFees.Rows[i].Cells[2].Value.ToString());
                        else aComp.Char_ID = 0;

                        decimal cost = 0;
                        decimal.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out cost);
                        aComp.Char_cost = cost;
                        decimal multi = 0;
                        decimal.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out multi);
                        aComp.Char_multi = multi;
                        aComp.Total = multi * cost;

                        //readsin the string for the char
                        //this means that it was put into the fill command and needs updating
                        if (aComp.Component_ID != 0)aComp.SortInt = 2; //sorting index that will be for updating past 

                        if (aComp.Serv_ID == 0 && aComp.Char_ID == 0) 
                            aComp.SortInt = 4;//this marks it to not save due to having no information, but also need deleted from db
                    }

                }
            }


            //this section saves the char relations between this client and the id of the char. It updates ones that were used or are now ready to be reused.
            //int affectedrows = 0; //this is to keep track of what all was deleted row wise

            foreach (AComp aComp in componentList)// loops through and updates the ones set up 
            {
                if (aComp.SortInt == 2) // this is set to be the CTC id for the ones that are being used
                {

                    string SetCompSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = @pJOB_ID,  " +
                        "CHAR_ID = @pCharID, SERV_ID = @pServID, CHAR_MULTI = @pMULTI, TOTAL = " +
                        "@pTOTAL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + ";";

                    if (aComp.Char_ID == 0 && aComp.Serv_ID == 0)//if both are empty
                    {
                        SetCompSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = @pJOB_ID,  " +
                            " CHAR_MULTI = @pMULTI, TOTAL = " +
                            "@pTOTAL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + ";";


                    }
                    else if (aComp.Serv_ID == 0)//if serv is empty
                    {
                        SetCompSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = @pJOB_ID,  " +
                            "CHAR_ID = @pCharID, CHAR_MULTI = @pMULTI, TOTAL = " +
                            "@pTOTAL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + ";";

                    }
                    else if (aComp.Char_ID == 0)//if char is empty
                    {
                        SetCompSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = @pJOB_ID,  " +
                            "Serv_ID = @pServID, CHAR_MULTI = @pMULTI, TOTAL = " +
                            "@pTOTAL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + ";";

                    }
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCompSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@pJOB_ID", jobID);

                        if (aComp.Char_ID != 0) command.Parameters.AddWithValue("@pCharID", aComp.Char_ID);

                        if (aComp.Serv_ID != 0) command.Parameters.AddWithValue("@pServID", aComp.Serv_ID);

                        command.Parameters.AddWithValue("@pMULTI", aComp.Char_multi);
                        command.Parameters.AddWithValue("@pTOTAL", aComp.Total);


                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table \nError: " + ex.Message);
                    }//end recycle
                }
                else if (aComp.SortInt == 1) // adding to the db
                {

                    string SetCompSQL;

                    if (aComp.Char_ID != 0 && aComp.Serv_ID != 0) SetCompSQL = "INSERT INTO JOB_COMPONENT_TABLE (JOB_ID, CHAR_ID, SERV_ID, CHAR_MULTI, TOTAL)  " +
                        " VALUES (@JOB_ID, @CHAR_ID, @SERV_ID, @CHAR_MULTI, @TOTAL ) ;";

                    else if (aComp.Char_ID != 0) SetCompSQL = "INSERT INTO JOB_COMPONENT_TABLE (JOB_ID, CHAR_ID,  CHAR_MULTI, TOTAL)  " +
                       " VALUES (@JOB_ID, @CHAR_ID, @CHAR_MULTI, @TOTAL ) ;";

                    else if (aComp.Serv_ID != 0) SetCompSQL = "INSERT INTO JOB_COMPONENT_TABLE (JOB_ID,  SERV_ID, CHAR_MULTI, TOTAL)  " +
                         " VALUES (@JOB_ID, @SERV_ID, @CHAR_MULTI, @TOTAL ) ;";

                    else SetCompSQL = "INSERT INTO JOB_COMPONENT_TABLE (JOB_ID,  CHAR_MULTI, TOTAL)  " +
                        " VALUES (@JOB_ID,  @CHAR_MULTI, @TOTAL ) ;";
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCompSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@JOB_ID", jobID);

                        if (aComp.Char_ID != 0)
                        {
                            command.Parameters.AddWithValue("@CHAR_ID", aComp.Char_ID);
                        }
                        if (aComp.Serv_ID != 0)
                        {
                            command.Parameters.AddWithValue("@SERV_ID", aComp.Serv_ID);
                        }


                        command.Parameters.AddWithValue("@CHAR_MULTI", aComp.Char_multi);
                        command.Parameters.AddWithValue("@TOTAL", aComp.Total);



                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add job component row to the table. \nError: " + ex.Message);
                    }//end creation


                }

                else if (aComp.SortInt == 4)//saved for deletion
                {
                    string DelCompSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = NULL,  " +
                        "CHAR_ID = NULL, SERV_ID = NULL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + "; " +
                        "DELETE FROM JOB_COMPONENT_TABLE WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + "; ";

                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(DelCompSQL, connection);
                        //Open the connection
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not delete component row the table. \nError: " + ex.Message);
                    }//end creation
                }
            }

            try
            {
                foreach (AStaff staff in staffList)//little loop to get the updated staff if there is one.
                {
                    if (cmboStaff.Text != "")
                    {
                        if (staff.StaffFirstName + " " + staff.StaffLastName == cmboStaff.SelectedItem.ToString())
                        {
                            staffID = staff.StaffID;
                        }
                    }
                }

                string SetJobSQL = "UPDATE JOB_TABLE SET TOTAL_BILL = @pTOTAL, STAFF_ID = @pSTAFF_ID " +
                    "WHERE JOB_ID = " + jobID + ";";

                if (staffID == 0)
                {
                    SetJobSQL = "UPDATE JOB_TABLE SET TOTAL_BILL = @pTOTAL " +
                    "WHERE JOB_ID = " + jobID + ";";
                }
                //Pulled from App.config
                connectionString = Properties.Settings.Default.GrenciDBConnectionString;

                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetJobSQL, connection);
                //Open the connection
                connection.Open();


                command.Parameters.AddWithValue("@pTOTAL", jobTotal);
                if (staffID != 0) command.Parameters.AddWithValue("@pSTAFF_ID", staffID);



                int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the job information. \n" + ex.Message);
            }

            if (btnTimer.Text == "Stop Timer")//saves time if that is needed.
            {

                DateTime timeEnd = DateTime.Now;
                btnTimer.Text = "Start Timer";

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                dgvTime.Rows.Insert(0, new string[] { (DateTime.Now - timeStart).ToString(), timeStart.ToString(), DateTime.Now.ToString(), timeDesc });
                SaveTime(timeDesc);//saves it to the database as well.

                time.Add(timeEnd.Subtract(timeStart));
                GetTime();
            }

        }



        //\\\\\\\\\\\\\\\\\\TIME\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void GetTime()
        {
            timeList.Clear(); //clears the list for the refresh
            string GetTimeSQL = "SELECT * FROM TIME_TABLE WHERE JOB_ID = " + jobID + ";";
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetTimeSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    ATime temptime = new ATime();

                    if (reader["TIME_ID"] != DBNull.Value)
                    {
                        temptime.TimeID = (reader["TIME_ID"] as int?) ?? 0;
                    }
                    if (reader["JOB_ID"] != DBNull.Value)
                    {
                        temptime.JobID = (reader["JOB_ID"] as int?) ??0;
                    }
                    if (reader["START_TIME"] != DBNull.Value)
                    {
                        temptime.StartTime = DateTime.Parse(reader["START_TIME"].ToString());
                    }
                    if (reader["END_TIME"] != DBNull.Value)
                    {
                        temptime.EndTime = DateTime.Parse(reader["END_TIME"].ToString());
                    }
                    if(reader["TIME_DESCRIPT"] != DBNull.Value)
                    {
                        temptime.Description = reader["TIME_DESCRIPT"] as string;
                    }
                    
                    temptime.Elapse = temptime.EndTime.Subtract(temptime.StartTime);


                    //Add the temporary plot stuff from list.
                    timeList.Add(temptime);
                    
                    temptime = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve times from Database.! \n Error reads: " + ex.Message);
            }
            FillTimes();
            
        }

        //this fills the time area of the datagridview
        private void FillTimes()
        {
            dgvTime.Rows.Clear();
            time = new TimeSpan();
            foreach (ATime atime in timeList)
            {
                dgvTime.Rows.Insert(0, new string[] { atime.Elapse.ToString(), atime.StartTime.ToString(), atime.EndTime.ToString(), atime.Description });
                time += atime.Elapse;
                lblTime.Text = "Total Elapsed Time: " + String.Format("{0:0.00}",time.TotalHours) + " hours";
            }
        }


        //saves the time component that is made from a timer or from the add sub bar
        private void SaveTime(string ptimedesc)
        {
            string SetTimeSQL = "INSERT INTO TIME_TABLE (JOB_ID, START_TIME, END_TIME, TIME_DESCRIPT)  " +
                        " VALUES (@pJobID, @pStart, @pEnd, @pDescript) ;";


            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetTimeSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object

                //Keep reading as long as I have data from the database to read

                command.Parameters.AddWithValue("@pJobID", jobID);
                command.Parameters.AddWithValue("@pStart", timeStart);
                command.Parameters.AddWithValue("@pEnd", DateTime.Now);
                command.Parameters.AddWithValue("@pDescript", ptimedesc);


                int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add time.! \n Error reads: " + ex.Message);
            }

        }


        //\\\\\\\\\\\\\\\\\CLIENT\\\\\\\\\\\\\\\\\\\\\\\\\\\


        //creates the client information to a client class object
        private void CreateClientList()
        {


            string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE WHERE CLIENT_ID = " + clientID + ";";


            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetClientsSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    AClient tempClient = new AClient();

                    if (reader["CLIENT_ID"] != DBNull.Value)
                    {
                        tempClient.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
                    }
                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;
                    }
                    if (reader["BIRTHDATE"] != DBNull.Value)
                    {
                        tempClient.Birthdate = reader["BIRTHDATE"] as string;
                    }
                    if (reader["ST_ADDRESS"] != DBNull.Value)
                    {
                        tempClient.Address = reader["ST_ADDRESS"] as string;
                    }
                    if (reader["CITY"] != DBNull.Value)
                    {
                        tempClient.City = reader["CITY"] as string;
                    }
                    if (reader["STATE_AB"] != DBNull.Value)
                    {
                        tempClient.State = reader["STATE_AB"] as string;
                    }
                    if (reader["ZIP"] != DBNull.Value)
                    {
                        tempClient.Zip = reader["ZIP"] as string;
                    }
                    if (reader["COUNTY"] != DBNull.Value)
                    {
                        tempClient.County = reader["COUNTY"] as string;
                    }
                    if (reader["SCHOOL"] != DBNull.Value)
                    {
                        tempClient.School = reader["SCHOOL"] as string;
                    }
                    if (reader["EMAIL"] != DBNull.Value)
                    {
                        tempClient.Email = reader["EMAIL"] as string;
                    }
                    if (reader["PHONE"] != DBNull.Value)
                    {
                        tempClient.Phone = reader["PHONE"] as string;
                    }
                    if (reader["SS"] != DBNull.Value)
                    {
                        tempClient.SSN1 = reader["SS"] as string;
                    }
                    if (reader["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempClient.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    if (reader["NOTES"] != DBNull.Value)
                    {
                        tempClient.Notes = reader["NOTES"] as string;
                    }
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }
                    if (reader["PARENT_CLIENT"] != DBNull.Value)
                    {
                        tempClient.ParentID = (reader["PARENT_CLIENT"] as int?) ?? 0;
                    }
                    if (reader["CLIENT_ACTIVE"] != DBNull.Value)
                    {
                        tempClient.Active = reader.GetBoolean(reader.GetOrdinal("CLIENT_ACTIVE"));
                    }

                    if (reader["OWED_BALANCE"] != DBNull.Value)
                    {
                        tempClient.Balance = (reader["OWED_BALANCE"] as decimal?) ?? 0.00m;
                    }


                    //Add the temporary plot stuff from list.
                    ClientsObj = tempClient;

                    tempClient = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }



        }

        //gets parent if it was activated in the program
        private string GetParent(int aClientID)
        {
            string returning = "";
            string GetParentSQL = "SELECT FIRST_NAME, LAST_NAME FROM CLIENT_TABLE WHERE CLIENT_ID =" + aClientID + ";";
            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetParentSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    AClient tempClient = new AClient();


                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;
                    }
                    if (reader["IS_BUSINESS"] != DBNull.Value)
                    {
                        tempClient.IsBusiness = reader.GetBoolean(reader.GetOrdinal("IS_BUSINESS"));
                    }
                    else tempClient.IsBusiness = false;
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }

                    if (tempClient.IsBusiness) returning = tempClient.Company;
                    else returning = tempClient.FirstName + " " + tempClient.LastName;

                    tempClient = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve parent client from Database.! \n Error reads: " + ex.Message);
            }
            return returning;
        }


        //gets the charactreistics to fill the listbox
        private void GetChar(int aClientID) //client charlist
        {
            lbxChar.Items.Clear();

            string GetCharSQL = "SELECT CHARACTERISTIC_TABLE.CHAR_NAME FROM CHARACTERISTIC_TABLE " +
                "INNER JOIN CTC_TABLE ON CHARACTERISTIC_TABLE.CHAR_ID = CTC_TABLE.CHAR_ID WHERE CTC_TABLE.CLIENT_ID = " + aClientID + ";";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetCharSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        lbxChar.Items.Add(reader["CHAR_NAME"] as string + " ");
                    }


                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

        }

        //fills all the client information that is retrieved in the last operations
        private void FillClientInfo()
        {
            AClient aClient = ClientsObj;

            if (aClient.IsBusiness) lblName.Text = aClient.Company;
            else lblName.Text = aClient.FirstName + " " + aClient.LastName;

            lblAddressSt.Text = aClient.Address;
            lblAddressCSZ.Text = aClient.City + ", " + aClient.State + " " + aClient.Zip;
            lblCounty.Text = "County: " + aClient.County;
            lblSchool.Text = "School Distict: " + aClient.School;

            lblBirthdate.Text = "Birthday: " + aClient.Birthdate;

            lblPhone.Text = "Phone: " + aClient.Phone;
            lblEmail.Text = "Email: " + aClient.Email;
            lblSSN.Text = "SSN: " + aClient.SSN1;

            GetChar(clientID);
            rtbNotes.Text = aClient.Notes;

            lblParent.Text = GetParent(aClient.ParentID);
            lblBalance.Text = "Balance: " + string.Format("{0:#,0.00}", aClient.Balance);

            
        }

        //\\\\\\\\\\\\\\\\\\\Page/dgvFiller\\\\\\\\\\\\\\\\\\\\
        private void GetServChar() //this makes a list of the char and serv at the begining of the
        {

            string GetServSQL = "SELECT * FROM SERVICE_TABLE ORDER BY SERV_NAME";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetServSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AServ temp = new AServ();


                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        temp.ServID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        temp.ServName = (reader["SERV_NAME"] as string);
                    }
                    if (reader["SERV_ACTIVE"] != DBNull.Value)
                    {
                        if (!reader.GetBoolean(reader.GetOrdinal("SERV_ACTIVE"))) temp = null;//if not active then it will delete the temp so it is not added
                    }

                    if (temp != null)
                    {
                        List<AChar> chars = new List<AChar>();
                        temp.Chars = chars;
                        //this is used for a comparason for in the save function
                        serviceList.Add(temp);
                    }
                    
                    
                    i++;
                }
                
                connection.Close();
                AServ tempServ = new AServ();
                tempServ.ServName = "____Blank____";
                tempServ.ServID = 0;
                tempServ.Chars = new List<AChar>();
                serviceList.Add(tempServ);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve services from Database.! \n Error reads: " + ex.Message);
            }


            string GetCharSQL = "select * from SERVICE_TABLE st inner join CHARACTERISTIC_TABLE ct on " +
                "st.SERV_ID = ct.SERV_ID  order by st.SERV_NAME, ct.CHAR_NAME";

            //Pulled from App.config

            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetCharSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AChar tempChar = new AChar();


                    if (reader["CHAR_ID"] != DBNull.Value)
                    {
                        tempChar.CharID = (reader["CHAR_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        tempChar.CharName = (reader["CHAR_NAME"] as string);
                    }
                    if (reader["CHAR_MIN"] != DBNull.Value)
                    {
                        tempChar.CharMini = (reader["CHAR_MIN"] as int?) ?? 0;
                    }
                    if (reader["CHAR_COST"] != DBNull.Value)
                    {
                        tempChar.CharCost = (reader["CHAR_COST"] as decimal?) ?? 0.00m;
                    }
                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempChar.CharAsso = (reader["SERV_ID"] as int?) ?? 0;
                        
                    }
                    if (reader["CHAR_ACTIVE"] != DBNull.Value)
                    {
                        if (!reader.GetBoolean(reader.GetOrdinal("CHAR_ACTIVE"))) tempChar = null;//if not active then it will delete the temp so it is not added
                    }

                    if (tempChar != null)
                    {
                        //this is used for a comparason for in the save function
                        foreach (AServ aserv in serviceList)
                        {
                            if (aserv.ServID == tempChar.CharAsso && tempChar.CharAsso != 0)
                            {
                                aserv.Chars.Add(tempChar);
                            }
                        }
                        characteristicList.Add(tempChar);
                    }

                    i++;
                    
                }
                connection.Close();

                //adds in a blank characteristic
                AChar temp = new AChar();
                temp.CharID = 0;
                temp.CharName = "____Blank____";
                temp.CharCost = 0;
                characteristicList.Add(temp);
                foreach (AServ aserv in serviceList)
                {
                    aserv.Chars.Add(temp);
                    if (aserv.Chars.Count == 1)//if empty it will bring up all char
                    {
                        foreach (AChar characteristic in characteristicList)
                        {
                            aserv.Chars.Add(characteristic);
                        }

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

            
        }

        //gets the staff list and it sets the assigned to the combo box head
        private void GetJobStaff()
        {
            string GetStaffSQL = "SELECT * FROM STAFF_TABLE";

            //Pulled from App.config

            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetStaffSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AStaff tempStaff = new AStaff();


                    if (reader["STAFF_ID"] != DBNull.Value)
                    {
                        tempStaff.StaffID = (reader["STAFF_ID"] as int?) ?? 0;
                    }
                    if (reader["STAFF_FIRST_NAME"] != DBNull.Value)
                    {
                        tempStaff.StaffFirstName = (reader["STAFF_FIRST_NAME"] as string);
                    }
                    if (reader["STAFF_LAST_NAME"] != DBNull.Value)
                    {
                        tempStaff.StaffLastName = (reader["STAFF_LAST_NAME"] as string);
                    }



                    //this is used for a comparason for in the save function

                    i++;
                    staffList.Add(tempStaff);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve staff from Database.! \n Error reads: " + ex.Message);
            }
            string GetJobSQL = "SELECT * FROM JOB_TABLE WHERE JOB_ID = " + jobID + ";";

            //Pulled from App.config

            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetJobSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())//reads in all the data assotiated with the 
                {



                    if (reader["STAFF_ID"] != DBNull.Value)
                    {
                        staffID = (reader["STAFF_ID"] as int?) ?? 0;
                    }



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve staff from Database.! \n Error reads: " + ex.Message);
            }

            foreach (AStaff staff in staffList)
            {
                cmboStaff.Items.Add( staff.StaffFirstName + " " + staff.StaffLastName);
                if (staffID == staff.StaffID)
                {
                    cmboStaff.Text = staff.StaffFirstName + " " + staff.StaffLastName;
                }
            }
        }



        //\\\\\\\\\\\\\\\\\\\\\COMPONENTS\\\\\\\\\\\\\\\\\\\

        //fills in componentes from an old job save
        private void FillComponents()
        {


            string GetCompSQL = "SELECT CHARACTERISTIC_TABLE.CHAR_NAME, CHARACTERISTIC_TABLE.CHAR_COST, SERVICE_TABLE.SERV_NAME, JOB_COMPONENT_TABLE.* " +
                "FROM JOB_COMPONENT_TABLE left JOIN SERVICE_TABLE ON JOB_COMPONENT_TABLE.SERV_ID = SERVICE_TABLE.SERV_ID " +
                "left JOIN CHARACTERISTIC_TABLE ON JOB_COMPONENT_TABLE.CHAR_ID = CHARACTERISTIC_TABLE.CHAR_ID " +
                "WHERE JOB_ID = " + jobID + ";";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetCompSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    AComp tempComp = new AComp();

                    if (reader["JOB_COMPONENT_ID"] != DBNull.Value)
                    {
                        tempComp.Component_ID = (reader["JOB_COMPONENT_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempComp.Serv_ID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempComp.Serv_Name = (reader["SERV_NAME"] as string);
                    }
                    if (reader["CHAR_ID"] != DBNull.Value)
                    {
                        tempComp.Char_ID = (reader["CHAR_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        tempComp.Char_Name = (reader["CHAR_NAME"] as string);
                    }
                    if (reader["CHAR_COST"] != DBNull.Value)
                    {
                        tempComp.Char_cost = (reader["CHAR_COST"] as decimal?) ?? 0.00m;
                        //tempComp.Char_cost = decimal.Parse( reader["CHAR_COST"] as string);
                    }                    
                    if (reader["CHAR_MULTI"] != DBNull.Value)
                    {
                        tempComp.Char_multi = (reader["CHAR_MULTI"] as decimal?) ?? 0.00m;
                        //tempComp.Char_multi = decimal.Parse(reader["CHAR_MULTI"] as string);
                    }
                    if (reader["TOTAL"] != DBNull.Value)
                    {
                        tempComp.Total = (reader["TOTAL"] as decimal?) ?? 0.00m;
                        //tempComp.Total = decimal.Parse(reader["TOTAL"] as string);
                        
                    }

                    //this is used for a comparason for in the save function
                    tempComp.Row = i;
                    i++;
                    componentList.Add(tempComp);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }


            //if (componentList.Count == 0) MessageBox.Show("Components list for this job is empty. Something did not load correct, or the job is new.");
            
            foreach (AComp comp in componentList)
            {
                //inserts the component on the last row of the dgv
                dgvFees.Rows.Insert(comp.Row, new string[] {                    
                    comp.Component_ID.ToString(), null , null, string.Format("{0:#,0.00}", comp.Char_cost), string.Format("{0:#,0.00}", comp.Char_multi), string.Format("{0:#,0.00}", comp.Total) });
            }
            foreach( AComp acomp in componentList)
            {
                if(acomp.Serv_ID != 0) dgvFees.Rows[acomp.Row].Cells[1].Value = acomp.Serv_ID;
                if(acomp.Char_ID != 0) dgvFees.Rows[acomp.Row].Cells[2].Value = acomp.Char_ID;

            }
            
        }

        //checks if the job is active and if not it will deactivate parts of the program
        private void activeCheck()
        {
            string GetCompSQL = "SELECT JOB_ACTIVE FROM JOB_TABLE " +
                "WHERE JOB_ID = " + jobID + ";";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetCompSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read


                int i = 0;
                while (reader.Read())//reads in all the data assotiated with the 
                {
                    

                    if (reader["JOB_ACTIVE"] != DBNull.Value)
                    {
                        isActive = reader.GetBoolean(reader.GetOrdinal("JOB_ACTIVE"));
                    }
                    
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }


            if(!isActive)//if the job is not active it will disable everything
            {
                MessageBox.Show("Not all information may be present if you deactivated something.\nSo if there is an error that pops up before this do not worry.");
                this.Text += ": Past Job View";
                dgvFees.Enabled = false;
                btnComplete.Enabled = false;
                btnSave.Enabled = false;
                btnTimer.Enabled = false;
                btnEditTime.Enabled = false;
            }
        }

        //\\\\\\\\\DGV FEATURES
       
        private void dgvFees_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)//if a new row is added this will pop up and make a new acomp for it
        {
            if (afterLoad)//if it is after the loading of the dgv then it will do stuff
            {
                AComp temp = new AComp();
                temp.SortInt = 1; //this will tag it to be added to the list.
                temp.Row = dgvFees.Rows.Count;//the count should be updated so this should give the comp a new rowrelated id.
                dgvFees.Rows[e.RowIndex].Cells[4].Value = 1.00;
                dgvFees.Rows[e.RowIndex].Cells[3].Value = 0.00;
                dgvFees.Rows[e.RowIndex].Cells[5].Value = 0.00;
                componentList.Add(temp);

            }

        }

        //if a row is entered it will total the row
        private void dgvFees_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            jobTotal = 0;// retotal every move 
            for (int i = 0; i < dgvFees.RowCount; i++)
            {
                decimal newcost = 0;
                decimal newmulti = 0;
                
                if (dgvFees.Rows[i].Cells[3].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out newcost);
                if (dgvFees.Rows[i].Cells[4].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out newmulti);

                decimal newtotal = newcost * newmulti;//if it is less it will be overwriten, if not it will be fine.
                dgvFees.Rows[i].Cells[5].Value = string.Format("{0:#,0.00}", newtotal);//if the new total is more than the one in there it will rewrite.


                jobTotal += newtotal;
            }
            lblTotal.Text = "Total: $" + string.Format("{0:#,0.00}", jobTotal);
        }


        //cell click event
        private void dgvFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvFees.Rows[e.RowIndex].Cells[2].Value != null)
                //if the user selects the  row, it is saved into the current component
                {
                    if (e.ColumnIndex == 2)
                    {
                        
                        int selectedChar = (int)dgvFees.Rows[e.RowIndex].Cells[2].Value;
                        foreach (AChar achar in characteristicList)
                        {
                            if (achar.CharID == selectedChar)
                            {

                                dgvFees.Rows[e.RowIndex].Cells[3].Value = string.Format("{0:#,0.00}", achar.CharCost);//resets the cost to be whatever the charcost is.

                                foreach (AComp cmp in componentList)//this finds the current row under edit and adds the correct data for the char selected
                                {
                                    if (cmp.Row == e.RowIndex) //sets cost and char for that row
                                    {
                                        cmp.Char_cost = achar.CharCost;
                                        cmp.Char_ID = achar.CharID;
                                        cmp.Char_Name = achar.CharName;
                                    }
                                }
                            }
                        }
                    }
                }
                if (dgvFees.Rows[e.RowIndex].Cells[1].Value != null && afterLoad)
                //if the user selects the  row, it is saved into the current component
                {
                    if (e.ColumnIndex == 1)
                    {
                        int selectedServ = (int)dgvFees.Rows[e.RowIndex].Cells[1].Value;
                        foreach (AServ aserv in serviceList)
                        {
                            if (aserv.ServID == selectedServ)
                            {


                                DataGridViewComboBoxCell cbo = new DataGridViewComboBoxCell();
                                cbo.DataSource = aserv.Chars;
                                cbo.DisplayMember = "CharName";
                                cbo.ValueMember = "CharID";
                                dgvFees.Rows[e.RowIndex].Cells[2] = cbo;
                                dgvFees.Rows[e.RowIndex].Cells[3].Value = "0.00";

                                //gets the list of chars for each serv in the second combo box if the first one is used.
                                foreach (AComp cmp in componentList)//this finds the current row under edit and adds the correct data for the char selected
                                {
                                    if (cmp.Row == e.RowIndex)//sets the component details for thatrow if somethin is selected
                                    {
                                        cmp.Serv_ID = aserv.ServID;
                                        cmp.Serv_Name = aserv.ServName;
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }

            //runs this everytime
            jobTotal = 0;// retotal every move 
            for (int i = 0; i < dgvFees.RowCount; i++)
            {
                decimal newcost = 0;
                decimal newmulti = 0;

                if (dgvFees.Rows[i].Cells[3].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out newcost);
                if (dgvFees.Rows[i].Cells[4].Value != null) decimal.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out newmulti);

                decimal newtotal = newcost * newmulti;//if it is less it will be overwriten, if not it will be fine.
                dgvFees.Rows[i].Cells[5].Value = string.Format("{0:#,0.00}", newtotal);//if the new total is more than the one in there it will rewrite.


                jobTotal += newtotal;
            }
            lblTotal.Text = "Total: $" + string.Format("{0:#,0.00}", jobTotal);
        }


    }
}
