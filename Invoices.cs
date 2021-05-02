/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for listing of the invoices and allowing the user to view the client and pay invoices as well as bring up the invoice from the file system.
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
    public partial class Invoices : Form
    {
        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;
        

        private List<AClient> ClientsObjList;


        //constructor
        public Invoices()
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
            CreateClientList();
            FillDGV();
        }


        //constructor that sets up the page for a specific client
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
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH, JOB_TABLE.JOB_ID" +
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


                    //puts all the info into the client class
                    while (reader.Read())
                    {
                    
                        AClient tempClient = new AClient();



                        if (reader["CLIENT_ID"] != DBNull.Value)
                        {
                            tempClient.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;
                        }
                        if (reader["JOB_ID"] != DBNull.Value)
                        {
                            tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
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

        //this gets all the clients that meet a specific search criteria 
        private void CreateClientList()
        {
            if (tbxSearch.Text != "")
            {
                string search = tbxSearch.Text;
                string GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH, JOB_TABLE.JOB_ID " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID " +
                    "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '" + search + "%')  "; //gets all that fall under the search

                if (!cbxOverdue.Checked) GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH, JOB_TABLE.JOB_ID " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID " +
                    "WHERE ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '" + search + "%')) AND " +
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
                        if (reader["JOB_ID"] != DBNull.Value)
                        {
                            tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
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
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH, JOB_TABLE.JOB_ID " +
                    "FROM CLIENT_TABLE INNER JOIN " +
                    "JOB_TABLE ON CLIENT_TABLE.CLIENT_ID = JOB_TABLE.CLIENT_ID INNER JOIN " +
                    "INVOICE_TABLE ON JOB_TABLE.JOB_ID = INVOICE_TABLE.JOB_ID ";//gets all

                if (!cbxOverdue.Checked) GetClientsSQL = "SELECT CLIENT_TABLE.CLIENT_ID, CLIENT_TABLE.FIRST_NAME, CLIENT_TABLE.LAST_NAME, CLIENT_TABLE.COMPANY_NAME, " +
                    "INVOICE_TABLE.INVOICE_ID, INVOICE_TABLE.AMOUNT_OWED, INVOICE_TABLE.FILE_PATH, JOB_TABLE.JOB_ID " +
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
                        if (reader["JOB_ID"] != DBNull.Value)
                        {
                            tempClient.JobID = (reader["JOB_ID"] as int?) ?? 0;
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
                dgvInvoices.Rows.Insert( 0 , new string[]{"View", aClient.ClientID.ToString(), aClient.LastName, aClient.FirstName, aClient.Company,
                   string.Format("{0:#,0.00}", aClient.Balance) , aClient.Address, "Make Payment", aClient.JobID.ToString()});
            }
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
        //unused, it was used for hardcoding    
        }

        private void cbxOverdue_CheckedChanged(object sender, EventArgs e)
        {
            //unused operater
        }

        //closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        //button click event for each of the clicks it will open up the respecive form or file from that row
        private void dgvInvoices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoices.Columns["View"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[1].Value.ToString());//gets the ID

                    int IDforJob = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[8].Value.ToString());//gets the ID


                    JobScreen form = new JobScreen(IDtoPass, IDforJob);
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


        //when clicked it will run though the set up and searching through the database for client invoices that match the parameters
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvInvoices.Rows.Clear();
            ClientsObjList.Clear();

           
            CreateClientList();
            dgvInvoices.Rows.Clear();
            FillDGV();
            


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "InvoiceOutput" + DateTime.Now.Month + DateTime.Now.Year +".csv";
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
                            int columnCount = dgvInvoices.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvInvoices.Rows.Count + 2];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvInvoices.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            

                            for (int i = 1; (i - 1) < dgvInvoices.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvInvoices.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            outputCsv[outputCsv.Length -1] += "Filters,Search: " + tbxSearch.Text + ",All Invoices that match search: " + cbxOverdue.Checked.ToString();

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
    }
}
