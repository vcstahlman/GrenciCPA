﻿using System;
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
    public partial class Invoices : Form
    {
        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;
        

        private List<AClient> ClientsObjList;

        public Invoices()
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
            CreateClientList();
            FillDGV();
        }

        public Invoices(int pClientID)
        {
            InitializeComponent();            
            ClientsObjList = new List<AClient>();
            CreateSingleClient(pClientID);
            FillDGV();
        }

        // this method is for when the user wants to access the invoices of a singular client, client ID is tracked within database through query statments
        private void CreateSingleClient(int pClientId)
        {
            
                string search = tbxSearch.Text;
                string GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID "+
                    "WHERE CLIENT_TABLE.CLIENT_ID = " + pClientId + "; ";

                connectionString = Properties.Settings.Default.GrenciDBConnectionString;

                try
                {
                    ClientsObjList.Clear();//resets the client list

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
                        if (reader["FILE_PATH"] != DBNull.Value)
                        {
                            tempClient.Address = reader["FILE_PATH"] as string;
                        }
                        if (reader["AMOUNT_OWED"] != DBNull.Value)
                        {
                            tempClient.Balance = (reader["AMOUNT_OWED"] as decimal?) ?? 0;
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

        private void CreateClientList()
        {
            if (tbxSearch.Text != "")
            {
                string search = tbxSearch.Text;
                string GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID " +
                    "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') "; //gets all that fall under the search

                if (cbxOverdue.Checked) GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID " +
                    "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%')  AND " +
                    "INVOICE_TABLE.AMOUNT_OWED > 0 ;"; //gets all overdue that follow search

                connectionString = Properties.Settings.Default.GrenciDBConnectionString;

                try
                {
                    ClientsObjList.Clear();//resets the client list

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
                        if (reader["FILE_PATH"] != DBNull.Value)
                        {
                            tempClient.Address = reader["FILE_PATH"] as string;
                        }
                        if (reader["AMOUNT_OWED"] != DBNull.Value)
                        {
                            tempClient.Balance = (reader["AMOUNT_OWED"] as decimal?) ?? 0;
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
            else
            {
                string GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID ";//gets all

                if (cbxOverdue.Checked) GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID " +
                    "WHERE INVOICE_TABLE.AMOUNT_OWED > 0 ;"; //gets all overdue

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
                        if (reader["COMPANY_NAME"] != DBNull.Value)
                        {
                            tempClient.Company = reader["COMPANY_NAME"] as string;
                        }
                        if (reader["FILE_PATH"] != DBNull.Value)
                        {
                            tempClient.Address = reader["FILE_PATH"]as string;
                        }
                        if (reader["AMOUNT_OWED"] != DBNull.Value)
                        {
                            tempClient.Balance = (reader["AMOUNT_OWED"] as decimal?) ?? 0;
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

        private void FillDGV()//fills in the Datagridview via the list of objects
        {

            dgvInvoices.Rows.Clear();
            foreach (AClient aClient in ClientsObjList)
            {
                dgvInvoices.Rows.Add("View", aClient.ClientID, aClient.LastName, aClient.FirstName, aClient.Company,
                   string.Format("{0:#,0.00}", aClient.Balance) , aClient.Address, "Make Payment");
            }
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxOverdue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void dgvInvoices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoices.Columns["View"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString());//gets the ID

                    ClientView form = new ClientView(IDtoPass);
                    form.ShowDialog();

                }
                if (e.ColumnIndex == dgvInvoices.Columns["Payment"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString());

                    Payments form = new Payments(IDtoPass);
                    form.ShowDialog();
                }
                if (e.ColumnIndex == dgvInvoices.Columns[6].Index) { 
                    System.Diagnostics.Process.Start(@dgvInvoices.Rows[e.RowIndex].Cells[6].Value.ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvInvoices.Rows.Clear();
            if (ClientsObjList.Count != 0) ClientsObjList.Clear();

            if (tbxSearch.Text == "" && cbxOverdue.Checked == true)
            {

                string GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID WHERE " +
                    "INVOICE_TABLE.AMOUNT_OWED > 0";
                //Pulled from App.config
                connectionString = Properties.Settings.Default.GrenciDBConnectionString;
                try
                {
                    ClientsObjList = null;//resets the client list

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
                        if (reader["FILE_PATH"] != DBNull.Value)
                        {
                            tempClient.Address = reader["FILE_PATH"] as string;
                        }
                        if (reader["AMOUNT_OWED"] != DBNull.Value)
                        {
                            tempClient.Balance = (reader["AMOUNT_OWED"] as decimal?) ?? 0;
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
                dgvInvoices.Rows.Clear();
                if (ClientsObjList != null) FillDGV();
                else MessageBox.Show("There are no clients with outstanding payments.");
            }
            else
            {
                CreateClientList();
                dgvInvoices.Rows.Clear();
                FillDGV();
            }


        }
    }
}
