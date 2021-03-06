﻿/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for viewing the client information and their past invoices. we can also lauch invoice and jobs for the client as well as create new jobs
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


namespace GrenciCPA
{
    public partial class ClientView : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;


        private AClient ClientsObj;
        private int parentID;
        private int clientID;

        private List<AInvoice> invoiceList = new List<AInvoice>();

        //constructor
        public ClientView(int pClientID)
        {
            InitializeComponent();
            clientID = pClientID;
            ClientsObj = new AClient();
        }


        //creates the information for the client. it is a common function we used on several pages
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
                        tempClient.Balance = (reader["OWED_BALANCE"] as decimal?) ?? 0;
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


        //gets parent for the client if there is one

        //this is a hidden function and is not used but it would work if we activate the feature in the future
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


        //creates the list of characteristics applied to the client
        private void GetChar(int aClientID)
        {
            lbxLabels.Items.Clear();

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
                        lbxLabels.Items.Add(reader["CHAR_NAME"] as string + " ");
                    }


                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

        }


        //fills in all the client information
        private void FillClientInfo()
        {
            AClient aClient = ClientsObj;

            if (aClient.IsBusiness) lblName.Text = aClient.Company;
            else lblName.Text = aClient.FirstName + " " + aClient.LastName;

            lblAddressSt.Text = aClient.Address;
            lblAddressCSZ.Text = aClient.City + ", " + aClient.State + " " + aClient.Zip;
            lblCounty.Text =  "County: " + aClient.County ;
            lblSchool.Text = "School Distict: "+ aClient.School;

            lblBirthdate.Text = "Birthday: " + aClient.Birthdate;

            lblPhone.Text = "Phone: " + aClient.Phone;
            lblEmail.Text = "Email: " + aClient.Email;
            lblSSN.Text = "SSN: " + aClient.SSN1;

            GetChar(clientID);
            rtbNotes.Text = aClient.Notes;

            lblParent.Text = GetParent(aClient.ParentID);
            lblBalance.Text = "Balance: $" + string.Format("{0:#,0.00}", aClient.Balance);
            
            
        }

        //this makes a job and then the user is sent into said job after it is created in a different function
        private int CreateJob()
        {
            int jobID = 0;
            string SetOtherSQL = "INSERT INTO JOB_TABLE (CLIENT_ID, JOB_ACTIVE) " +
                "OUTPUT INSERTED.JOB_ID " +
                "VALUES (@CLIENT_ID, @JOB_ACTIVE); ";
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetOtherSQL, connection);
                //Open the connection
                connection.Open();


                command.Parameters.AddWithValue("@CLIENT_ID", clientID);
                command.Parameters.AddWithValue("@JOB_ACTIVE", 1);
                                
                var lastID = command.ExecuteScalar(); //this gets the data of the client that was just added into the system
                jobID = Convert.ToInt32(lastID);
                

                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not open or insert data! \nError: " + ex.Message);
            }
        
            return jobID;
        }


        //Prompt to ensure the user saves all changes made to form before closing
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

        // this button will take the user to the ServiceSelect form, allowing them to select a staff member from a dropdown and bringing them to the JobScreen form
        // for a new job.
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            JobScreen form = new JobScreen(clientID, CreateJob());
            form.ShowDialog();

        }

        // opens up a form to edit client information
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient(clientID);
            form.ShowDialog();
            this.Close();
        }



        private void ClientView_Load(object sender, EventArgs e)
        {

            dgvClientPast.Rows.Clear();
            CreateClientList();

            FillClientInfo();

            FillJobs();
            FillDGV();
        }

        // this button will show all Active Jobs for the given client on the Active Job form
        private void btnActive_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs(clientID);
            form.ShowDialog();
        }

        private void dgvClientPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //unused eventhandler
        }


        //fills in the job info for the datagridview in the form
        private void FillJobs()
        {
            invoiceList.Clear();
            var GetClientsSQL = "SELECT JOB_TABLE.JOB_ID, JOB_TABLE.CLIENT_ID, INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.DATE_SENT, " +
                "INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.AMOUNT_PAID FROM INVOICE_TABLE " +
                "INNER JOIN JOB_TABLE ON INVOICE_TABLE.JOB_ID = JOB_TABLE.JOB_ID" +
                " WHERE JOB_TABLE.CLIENT_ID = "+ clientID+ ";";

            
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


                    AInvoice tempinvoice = new AInvoice();

                    if (reader["JOB_ID"] != DBNull.Value)
                    {
                        tempinvoice.JobID = (reader["JOB_ID"] as int?) ?? 0;
                    }
                    if (reader["DATE_SENT"] != DBNull.Value)
                    {
                        tempinvoice.SentDate = (DateTime)reader["DATE_SENT"];
                    }
                    if (reader["AMOUNT_PAID"] != DBNull.Value)
                    {
                        tempinvoice.AmtPaid = (reader["AMOUNT_PAID"] as decimal?) ?? 0;
                    }
                    if (reader["AMOUNT_OWED"] != DBNull.Value)
                    {
                        tempinvoice.AmtOwed = (reader["AMOUNT_OWED"] as decimal?) ?? 0;
                    }




                    //Add the temporary plot stuff from list.
                    invoiceList.Add(tempinvoice);

                    tempinvoice = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }
        }


        //gets services that the client has needed in the past
        private string GetServ(int ajobID)
        {
            string returning = "";
            string GetParentSQL = "SELECT SERVICE_TABLE.SERV_NAME FROM SERVICE_TABLE INNER JOIN JOB_COMPONENT_TABLE ON SERVICE_TABLE.SERV_ID = JOB_COMPONENT_TABLE.SERV_ID " +
                "INNER JOIN JOB_TABLE ON JOB_COMPONENT_TABLE.JOB_ID = JOB_TABLE.JOB_ID WHERE JOB_TABLE.JOB_ID =" + ajobID + ";";//gets on a job by job basis
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
                        returning += reader["SERV_NAME"] as string + ", \n";
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


        //files the infromation needed
        private void FillDGV()
        {
            foreach(AInvoice invoice in invoiceList)
            {
                dgvClientPast.Rows.Add(invoice.SentDate.ToShortDateString(), GetServ(invoice.JobID), invoice.AmtOwed, invoice.AmtPaid);
            }
        }


        //sends the user to a list of payments they have made
        private void btnPayments_Click(object sender, EventArgs e)
        {
            ReportDemo form = new ReportDemo(clientID);
            form.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClientView_Load(null, null);
        }
    }
}
