/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for listing of the jobs and it displayes the client the staff assigned to the job and the list of services in a job. it also shows past jobs by sending along a past view set up
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
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace GrenciCPA
{
    public partial class Jobs : Form
    {


        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private List<AClient> ClientsObjList;
        private int clientID = 0 ;
        private int staffID = 0;

        //constructor breaks up only active at first
        public Jobs()
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
        }


        //brings up active for a client
        public Jobs(int pclient)
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
            clientID = pclient;
            cbxProgress.Checked = false;
        }

        //brings up active for a staff
        public Jobs(int pStaff, string useless)
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
            staffID = pStaff;
        }

        //when the button is clicked it will search for matches
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvJobs.Rows.Clear();
            if (ClientsObjList.Count != 0) ClientsObjList.Clear();
            string GetClientsSQL = "";
            if (tbxSearch.Text != "")
            {
                string search = tbxSearch.Text;
                if (cbxUnassigned.Checked == true && cbxProgress.Checked == true)
                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE JOB_TABLE.JOB_ACTIVE = 1 AND JOB_TABLE.STAFF_ID IS NULL AND ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                    "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                    "OR (CLIENT_TABLE.ST_ADDRESS LIKE '" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '" + search + "%'))";

                }

                else if (cbxPast.Checked == true && cbxUnassigned.Checked == true)
                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE JOB_TABLE.STAFF_ID IS NULL AND JOB_TABLE.JOB_ACTIVE = 0 AND ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                    "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                    "OR (CLIENT_TABLE.ST_ADDRESS LIKE '" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '" + search + "%'))";

                }


                //one of these 2 is always checked
                else if (cbxProgress.Checked == true)
                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE JOB_TABLE.JOB_ACTIVE = 1 AND ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                    "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                    "OR (CLIENT_TABLE.ST_ADDRESS LIKE '" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '" + search + "%'))";

                }
                else if (cbxPast.Checked == true)
                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE JOB_TABLE.JOB_ACTIVE = 0 AND ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                    "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                    "OR (CLIENT_TABLE.ST_ADDRESS LIKE '" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '" + search + "%'))";

                }
            }
            else if (cbxUnassigned.Checked == true && cbxProgress.Checked == true)
            {
                GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                "WHERE JOB_TABLE.JOB_ACTIVE = 1 AND JOB_TABLE.STAFF_ID IS NULL  ";

            }
            
            else if (cbxPast.Checked == true && cbxUnassigned.Checked == true)
            {
                GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                "WHERE JOB_TABLE.STAFF_ID IS NULL AND JOB_TABLE.JOB_ACTIVE = 0";

            }
            

            //one of these 2 is always checked
            else if (cbxProgress.Checked == true)
            {
                GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                "WHERE JOB_TABLE.JOB_ACTIVE = 1";

            }
            else if (cbxPast.Checked == true)
            {
                GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID, " +
                "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                "WHERE JOB_TABLE.JOB_ACTIVE = 0";

            }
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
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }
                    //if (reader["PARENT_CLIENT"] != DBNull.Value)
                    //{
                    //    tempClient.Balance = (reader["PARENT_CLIENT"] as int?) ?? 0.0;
                    //}
                    if (reader["JOB_ID"] != DBNull.Value)
                    {
                        tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
                    }


                    //Add the temporary plot stuff from list.
                    ClientsObjList.Add(tempClient);

                    tempClient = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }
            FillDGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        

        private void Jobs_Load(object sender, EventArgs e)
        {
            CreateJobList();

            FillDGV();
        }

        //defalt creation
        private void CreateJobList()
        {
            if (tbxSearch.Text != "")
            {
                string search = tbxSearch.Text;
                string GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') AND JOB_TABLE.JOB_ACTIVE = 1 ";
                if(cbxPast.Checked) {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                       "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                       "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                       "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                       "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') AND JOB_TABLE.JOB_ACTIVE = 0 ";
                }

               
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
                        if (reader["COMPANY_NAME"] != DBNull.Value)
                        {
                            tempClient.Company = reader["COMPANY_NAME"] as string;
                        }
                        //if (reader["PARENT_CLIENT"] != DBNull.Value)
                        //{
                        //    tempClient.Balance = (reader["PARENT_CLIENT"] as int?) ?? 0.0;
                        //}
                        if (reader["JOB_ID"] != DBNull.Value)
                        {
                            tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
                        }
                        if (reader["JOB_ACTIVE"] != DBNull.Value)
                        {
                            if (!reader.GetBoolean(reader.GetOrdinal("JOB_ACTIVE"))) tempClient.Active = false;
                            else tempClient.Active = true;
                        }


                        //Add the temporary plot stuff from list.
                        ClientsObjList.Add(tempClient);

                        tempClient = null;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
                }
            }
            else {
                String GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID " +
                    "WHERE JOB_TABLE.JOB_ACTIVE = 1" ;//only opens active jobs at first

                if (clientID != 0)//if there is a passed id for the client then it will make only the clients info come in for now.

                //need to auto put in the name when the filtering is a thing.

                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID,  " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID WHERE JOB_TABLE.CLIENT_ID = " + clientID + ";";
                }

                if (staffID != 0)//if there is a passed id for the client then it will make only the clients info come in for now.

                //need to auto put in the name when the filtering is a thing.

                {
                    GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, JOB_TABLE.STAFF_ID, " +
                    "JOB_TABLE.TOTAL_BILL, JOB_TABLE.JOB_ACTIVE, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.IS_BUSINESS, " +
                    "CLIENT_TABLE.COMPANY_NAME, CLIENT_TABLE.CLIENT_ACTIVE " +
                    "FROM JOB_TABLE INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID WHERE JOB_TABLE.STAFF_ID = " + staffID + ";";
                }
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
                        if (reader["COMPANY_NAME"] != DBNull.Value)
                        {
                            tempClient.Company = reader["COMPANY_NAME"] as string;
                        }
                        //if (reader["PARENT_CLIENT"] != DBNull.Value)
                        //{
                        //    tempClient.Balance = (reader["PARENT_CLIENT"] as int?) ?? 0.0;
                        //}
                        if (reader["JOB_ID"] != DBNull.Value)
                        {
                            tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
                        }


                        //Add the temporary plot stuff from list.
                        ClientsObjList.Add(tempClient);

                        tempClient = null;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
                }
            }
        }


        ////////////////
        private void FillDGV()//fills in the Datagridview via the list of objects
        {
            if (ClientsObjList.Count > 0)
            {
                foreach (AClient aClient in ClientsObjList)
                {
                    dgvJobs.Rows.Add(aClient.FirstName, aClient.LastName, aClient.Company, " " /*GetParent(aClient.ParentID)*/, GetServ(aClient.JobID), GetStaff(aClient.JobID), "View Job", aClient.ClientID, aClient.JobID);

                }
            }
        }

        ////////////////
        ///gets the staff for the job in the row during the creation
        private string GetStaff(int aJob)
        {
            string returning = "";
            string GetParentSQL = "SELECT STAFF_TABLE.STAFF_FIRST_NAME, STAFF_TABLE.STAFF_LAST_NAME FROM STAFF_TABLE INNER JOIN JOB_TABLE ON " +
                "STAFF_TABLE.STAFF_ID = JOB_TABLE.STAFF_ID INNER JOIN CLIENT_TABLE ON JOB_TABLE.CLIENT_ID = CLIENT_TABLE.CLIENT_ID WHERE JOB_TABLE.JOB_ID =" + aJob + ";";

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


                    if (reader["STAFF_FIRST_NAME"] != DBNull.Value)
                    {
                        returning = reader["STAFF_FIRST_NAME"] as string;
                    }
                    if (reader["STAFF_LAST_NAME"] != DBNull.Value)
                    {
                        returning += " " + reader["STAFF_LAST_NAME"];
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve parent client from Database.! \n Error reads: " + ex.Message);
            }
            return returning;
        }
        ////////////////
        ///gets the services for a given job
        private string GetServ(int aJob)
        {
            string returning = "";
            string GetParentSQL = "SELECT SERVICE_TABLE.SERV_NAME FROM SERVICE_TABLE INNER JOIN JOB_COMPONENT_TABLE ON SERVICE_TABLE.SERV_ID = JOB_COMPONENT_TABLE.SERV_ID INNER JOIN JOB_TABLE ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID WHERE JOB_TABLE.JOB_ID =" + aJob + ";";
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

                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        returning += reader["SERV_NAME"] as string  + " \n";
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve services for the client from Database.! \n Error reads: " + ex.Message);
            }
            return returning;
        }
        ////////////////
        ///unused would get parent if enabled
        private string GetParent(int aClientID)
        {
            if (clientID == 0) return " ";
            string returning = "";
            string GetParentSQL = "SELECT FIRST_NAME, LAST_NAME, COMPANY_NAME, IS_BUSINESS FROM CLIENT_TABLE WHERE PARENT_CLIENT =" + aClientID + ";";
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

        ///click event for the user to get to the jobscreen and pass on the correct info.
        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    int IDtoPass = int.Parse(dgvJobs.Rows[e.RowIndex].Cells[8].Value.ToString());//gets the Job id
                    int aClientID = int.Parse(dgvJobs.Rows[e.RowIndex].Cells[7].Value.ToString());//gets the client id

                    JobScreen form = new JobScreen(aClientID, IDtoPass);
                    form.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvJobs.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "JobOutput" + DateTime.Now.Month + DateTime.Now.Year + ".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dgvJobs.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvJobs.Rows.Count + 2];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvJobs.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvJobs.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvJobs.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            outputCsv[outputCsv.Length - 1] += "Filters,Search: " + tbxSearch.Text + ",Unassigned: " + cbxUnassigned.Checked.ToString()+ ", Present job: "+ cbxProgress.Checked.ToString();

                            int k = 0;
                            foreach (String st in outputCsv)
                            {
                                outputCsv[k] = Regex.Replace(st, "\n", " ");
                                k++;
                            }
                            
                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            //MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        ////////////////
    }
}
