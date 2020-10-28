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
using Org.BouncyCastle.Crypto.Agreement.Srp;

// Justin Bloss
// The JobScreen form is where the user enters in services provided for a client and takes time of each service to calculate a total for the invoice
namespace GrenciCPA
{
    public partial class JobScreen : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private double time;
        private DateTime timeStarted;
        private double timeStart;
        private int clientID;
        private int jobID;
        private AClient ClientsObj;
        private int parentID;

        private List<AComp> componentList = new List<AComp>();
        private List<AServ> serivceList = new List<AServ>();
        private List<AChar> characteristicList = new List<AChar>();



        public JobScreen()
        {
            InitializeComponent();


        }

        public JobScreen(int pClient, int pjob)
        {
            InitializeComponent();
            clientID = pClient;
            jobID = pjob;
            ClientsObj = new AClient();
            CreateClientList();
            FillClientInfo();

            FillComponents();
            GetServChar();

        }

        private void dgvFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvFees.Columns["Characteristics"].Index)
                {
                    string selectedChar = dgvFees.Rows[e.RowIndex].Cells[2].Selected.ToString() ;
                    foreach (AChar achar in characteristicList)
                    {
                        if(achar.CharName == selectedChar)
                        {
                            dgvFees.Rows[e.RowIndex].Cells[3].Value = achar.CharCost;
                            if (dgvFees.Rows[e.RowIndex].Cells[5].Value == null) dgvFees.Rows[e.RowIndex].Cells[5].Value = achar.CharMini;
                        }
                    }

                }
                if (e.ColumnIndex == dgvFees.Columns["Multiplier"].Index)
                {
                    string selectedChar = dgvFees.Rows[e.RowIndex].Cells[2].Selected.ToString();
                    foreach (AChar achar in characteristicList)
                    {
                        if (achar.CharName == selectedChar)
                        {
                            double total = 0;
                            if (dgvFees.Rows[e.RowIndex].Cells[4].Value != null)
                            {
                                double multi = 0;
                                double.TryParse(dgvFees.Rows[e.RowIndex].Cells[4].Value.ToString(), out multi);

                                total = achar.CharCost * multi;
                            }

                            if (dgvFees.Rows[e.RowIndex].Cells[5].Value != null ) 
                            {
                                
                                if (achar.CharMini <= total)    dgvFees.Rows[e.RowIndex].Cells[5].Value = total;
                                    //if the total is now more mini then it will overwrite
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void JobScreen_Load(object sender, EventArgs e)
        {
            // test data

        }

        // this button allows the user to change client information, like home address or telephone number, and inputs the new info to the jobScreen
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            ClientView form = new ClientView(clientID);
            form.Show();
        }

        // To ensure user saves all information before completing a job, we have entered in this message prompt as a reminder
        private void button3_Click(object sender, EventArgs e)
        {
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
                timeStart = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                timeStarted = DateTime.Now;

            }
            else
            {

                double timeend = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                btnTimer.Text = "Start Timer";

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                dgvTime.Rows.Add((DateTime.Now - timeStarted).ToString(), timeStarted.ToString(), DateTime.Now.ToString(), timeDesc);
                SaveTime(timeDesc);//saves it to the database as well.

                time += timeend - timeStart;
                txtDateTime.Text = "Total Elapsed Time: " + (((int)time * 100) / 100).ToString() + " hours";
            }


        }

        // Once the Complete button is clicked, the user will be taken to the Invoice form with services and amount listed
        private void btnComplete_Click(object sender, EventArgs e)
        {

            InvoiceScreen form = new InvoiceScreen(jobID);//pass the jobID and the total
            form.ShowDialog();
        }

        // Allows the user to edit the timer incase of user error (ex. forgot to click the Start Timer button or let it run for too long)
        private void btnEditTime_Click(object sender, EventArgs e)
        {
            if (btnEditTime.Text == "Edit Time")
            {
                lblAddMinutes.Visible = true;
                cmboAddTime.Visible = true;
                lblAddTime.Visible = true;
                txtAddTime.Visible = true;
                lblSubtractTime.Visible = true;
                txtSubtract.Visible = true;

                btnEditTime.Text = "Finish Editing";
            }

            else
            {
                lblAddMinutes.Visible = false;
                lblAddTime.Visible = false;
                lblSubtractTime.Visible = false;
                txtAddTime.Text = "";
                txtAddTime.Visible = false;
                txtSubtract.Text = "";
                txtSubtract.Visible = false;
                cmboAddTime.Items.Clear();
                cmboAddTime.Visible = false;

                btnEditTime.Text = "Edit Time";

                //SaveTime("edit of time");
            }
        }

        private void SaveTime(string ptimedesc)
        {
            string GetClientsSQL = "INSERT INTO TIME_TABLE (JOB_ID, START_TIME, END_TIME, TIME_DESCRIPT)  " +
                        " VALUES (@pJobID, @pStart, @pEnd, @pDescript) ;";


            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetClientsSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object

                //Keep reading as long as I have data from the database to read

                command.Parameters.AddWithValue("@pJobID", jobID);
                command.Parameters.AddWithValue("@pStart", timeStarted);
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
                        tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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

        private void GetChar(int aClientID)
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
            lblBalance.Text = "Balance: " + aClient.Balance;


        }


        private void FillComponents()
        {


            string GetCompSQL = "SELECT CHARACTERISTIC_TABLE.CHAR_NAME, SERVICE_TABLE.SERV_NAME, JOB_COMPONENT_TABLE.* " +
                "FROM JOB_COMPONENT_TABLE INNER JOIN SERVICE_TABLE ON JOB_COMPONENT_TABLE.SERV_ID = SERVICE_TABLE.SERV_ID " +
                "INNER JOIN CHARACTERISTIC_TABLE ON JOB_COMPONENT_TABLE.CHAR_ID = CHARACTERISTIC_TABLE.CHAR_ID AND " +
                "SERVICE_TABLE.SERV_ID = CHARACTERISTIC_TABLE.SERV_ID " + //CHARACTERISTIC_TABLE.CHAR_ID   SERVICE_TABLE.SERV_ID,
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
                        tempComp.Char_cost = (reader["CHAR_COST"] as double?) ?? 0.0;
                    }
                    if (reader["CHAR_MINI"] != DBNull.Value)
                    {
                        tempComp.Char_multi = (reader["CHAR_MIN"] as double?) ?? 0.0;
                    }
                    if (reader["CHAR_MULTI"] != DBNull.Value)
                    {
                        tempComp.Char_multi = (reader["CHAR_MULTI"] as double?) ?? 0.0;
                    }
                    if (reader["TOTAL"] != DBNull.Value)
                    {
                        tempComp.Total = (reader["TOTAL"] as double?) ?? 0.0;
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFees.Rows.Count; i++)
            {
                foreach (AComp aComp in componentList)
                {
                    if (i == aComp.Row && aComp.SortInt == 1)//if it is new and if it is in the correct row
                    {
                        aComp.Serv_Name = dgvFees.Rows[i].Cells[1].Value.ToString();//reads in the string for the serv
                        aComp.Char_Name = dgvFees.Rows[i].Cells[2].Value.ToString();//readsin the string for the char
                        int cost = 0;
                        int.TryParse(dgvFees.Rows[i].Cells[3].Value.ToString(), out cost);
                        aComp.Char_cost = cost;
                        int multi = 0;
                        int.TryParse(dgvFees.Rows[i].Cells[4].Value.ToString(), out multi);
                        aComp.Char_multi = multi;

                    }

                }
            }




            //this travels through the datagridview and checks if the current row is saved at all
            for (int i = 0; i < dgvFees.Rows.Count; i++)
            {
                foreach (AComp aComp in componentList)
                {
                    if (dgvFees.Rows[i].Cells[0].ToString() == aComp.Component_ID.ToString())
                    {
                        //this means that it was put into the fill command and needs updating
                        aComp.SortInt = 2; //sorting index that will be for updating past 
                    }

                }
            }


            //this section saves the char relations between this client and the id of the char. It updates ones that were used or are now ready to be reused.
            //int affectedrows = 0; //this is to keep track of what all was deleted row wise

            foreach (AComp aComp in componentList)// loops through and updates the ones set up 
            {
                if (aComp.SortInt == 2) // this is set to be the CTC id for the ones that are being used
                {

                    string SetCharSQL = "UPDATE JOB_COMPONENT_TABLE SET JOB_ID = @pJOB_ID,  " +
                        "CHAR_ID = @pCharID, SERV_ID = @pSERV_ID, CHAR_MULTI = @pMULTI, TOTAL = " +
                        "@pTOTAL WHERE JOB_COMPONENT_ID = " + aComp.Component_ID + ";";
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCharSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@pJOB_ID", jobID);
                        command.Parameters.AddWithValue("@pCharID", aComp.Char_ID);
                        command.Parameters.AddWithValue("@pSERV_ID", aComp.Serv_ID);
                        command.Parameters.AddWithValue("@pMULTI", aComp.Char_multi);
                        command.Parameters.AddWithValue("@pTotal", aComp.Total);


                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not update the table " + ex.Message);
                    }//end recycle
                }
                else if (aComp.SortInt == 1) // adding to the db
                {

                    string SetCharSQL = "INSERT INTO JOB_COMPONENT_TABLE (JOB_ID, CHAR_ID, SERV_ID, CHAR_COST, CHAR_MULTI, TOTAL)  " +
                        " VALUES (@JOB_ID, @CHAR_ID, @SERV_ID, @CHAR_COST, @CHAR_MULTI, @TOTAL ) ;";
                    //Pulled from App.config
                    connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                    try
                    {
                        connection = new SqlConnection(connectionString);
                        command = new SqlCommand(SetCharSQL, connection);
                        //Open the connection
                        connection.Open();

                        command.Parameters.AddWithValue("@pJOB_ID", jobID);
                        command.Parameters.AddWithValue("@pCharID", aComp.Char_ID);
                        command.Parameters.AddWithValue("@pSERV_ID", aComp.Serv_ID);
                        command.Parameters.AddWithValue("@pMULTI", aComp.Char_multi);
                        command.Parameters.AddWithValue("@pTotal", aComp.Total);



                        int rowsAffected = command.ExecuteNonQuery();//tells ya if it worked

                        connection.Close();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add characteristics to the table " + ex.Message);
                    }//end creation


                }
            }

        }

        private void dgvFees_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)//if a new row is added this will pop up and make a new acomp for it
        {
            AComp temp = new AComp();
            temp.SortInt = 1; //this will tag it to be added to the list.
            temp.Row = dgvFees.Rows.Count;//the count should be updated so this should give the comp a new rowrelated id.

            componentList.Add(temp);

            DataGridViewComboBoxCell cboServ = (DataGridViewComboBoxCell)dgvFees[dgvFees.Rows.Count, 1];
            foreach(AServ serv in serivceList) { 
                cboServ.Items.AddRange(serv.ServName); 
            }

            DataGridViewComboBoxCell cboChar = (DataGridViewComboBoxCell)dgvFees[dgvFees.Rows.Count, 2];
            foreach (AChar achar in characteristicList)
            {
                cboChar.Items.AddRange(achar.CharName);
            }

        }

        private void GetServChar() //this makes a list of the char and serv at the begining of the
        {

            string GetServSQL = "SELECT * FROM SERVICE_TABLE";

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
                    AServ tempServ = new AServ();


                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempServ.ServID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempServ.ServName = (reader["SERV_NAME"] as string);

                    }
                    if (reader["SERV_SENTENCE"] != DBNull.Value)
                    {
                        tempServ.ServID = (reader["SERV_SENTENCE"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempServ.ServName = (reader["SERV_NAME"] as string);
                    }
                    if (reader["SERV_ACTIVE"] != DBNull.Value)
                    {
                        if (!reader.GetBoolean(reader.GetOrdinal("SERV_ACTIVE"))) tempServ = null;//if not active then it will delete the temp so it is not added
                    }


                    //this is used for a comparason for in the save function

                    i++;
                    serivceList.Add(tempServ);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve services from Database.! \n Error reads: " + ex.Message);
            }


            string GetCharSQL = "SELECT * FROM CHARACTERISTIC_TABLE";

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
                        tempChar.CharCost = (reader["CHAR_COST"] as int?) ?? 0;
                    }
                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempChar.CharAsso = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_ACTIVE"] != DBNull.Value)
                    {
                        if (!reader.GetBoolean(reader.GetOrdinal("CHAR_ACTIVE"))) tempChar = null;//if not active then it will delete the temp so it is not added
                    }


                    //this is used for a comparason for in the save function

                    i++;
                    characteristicList.Add(tempChar);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }
        }
    }
}
