/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for listing offthe clients and allowing the user to view the client and view the invoices for the client via buttons to other forms
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
using System.Drawing.Drawing2D;
using System.IO;
using System.Text.RegularExpressions;

namespace GrenciCPA
{
    public partial class ClientList : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private List<AClient> ClientsObjList;


        //constructor
        public ClientList()
        {
            InitializeComponent();
            ClientsObjList = new List<AClient>();
            CreateClientList();
            FillDGV();

            //this allows multiple lines for the char
            dgvClients.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        //creates a list of clients that matches what search settings there are.
        private void CreateClientList()
        {
            if (txtSearch.Text != "")
            {
                string search = txtSearch.Text;
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
              "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
              "FROM CLIENT_TABLE " +
              "WHERE ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                    "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                    "OR (CLIENT_TABLE.ST_ADDRESS LIKE '%" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '%" + search + "%')) ";

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
            else {//if there is no search this is the base sql for retrieving the clients
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                    "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                    "FROM CLIENT_TABLE;";



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

        

        //this gets the clients characteristics that serve as a reminder to the staff of what to add on the jobscreen
        private string GetChar(int aClientID)
        {
            string ret = "";
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
                        ret += reader["CHAR_NAME"] as string + " \n";
                    }
                    


                    
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve characteristics from Database.! \n Error reads: " + ex.Message);
            }

            return ret;
        }

        private void FillDGV()//fills in the Datagridview via the list of objects
        {
            foreach (AClient aClient in ClientsObjList)
            {
                dgvClients.Rows.Add(aClient.Active, aClient.FirstName, aClient.LastName, GetChar(aClient.ClientID), 
                    aClient.Company, aClient.Address, aClient.City, aClient.State + " " + aClient.Zip, "View Client", 
                    "View Invoice", aClient.ClientID );
            }
        }


        //closes the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        //brings the user to the addedit screen with the screen empty for an addition
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }


        //this is theclick event that checks for the buttons and then opens the respective form
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
            try
            {
                if (e.ColumnIndex == dgvClients.Columns["View"].Index)
                {
                    int IDtoPass = int.Parse(dgvClients.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());//gets the ID

                    ClientView form = new ClientView(IDtoPass);
                    form.ShowDialog();

                }
                else if(e.ColumnIndex == dgvClients.Columns["Invoices"].Index)
                {
                    int IDtoPass = int.Parse(dgvClients.Rows[e.RowIndex].Cells[e.ColumnIndex  +1].Value.ToString());//gets the ID

                    Invoices form = new Invoices(IDtoPass);
                    form.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }


        //this is the load that we used for hardcoded info
        private void ClientList_Load(object sender, EventArgs e)
        {

            //dgvClients.Rows.Add("Joe", "Smith", "", "123 Clari St", "Clarion", "PA", "Email", "View Client", "View Invoices", "View Returns", "Create Return");

        }


        //this creates a list of clients depending on the search fields
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClientsObjList.Clear();//reset the list
            dgvClients.Rows.Clear();//resets the dgv
            
            if (cbxIsCompany.Checked == true)
            {
                
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE " +
                "WHERE IS_BUSINESS = 1";

                string search = txtSearch.Text;
                if (txtSearch.Text != "") GetClientsSQL += " AND ((CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') " +
                   "OR (CLIENT_TABLE.FIRST_NAME LIKE '" + search + "%') OR (CLIENT_TABLE.COMPANY_NAME LIKE '%" + search + "%') " +
                   "OR (CLIENT_TABLE.ST_ADDRESS LIKE '%" + search + "%') OR (CLIENT_TABLE.CITY LIKE '" + search + "%') OR (CLIENT_TABLE.ZIP LIKE '%" + search + "%')) ";

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
                CreateClientList();
                
            }

            if (ClientsObjList != null) FillDGV();
            else MessageBox.Show("There were no clients to display, retry the filters and search to try again.");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvClients.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "ClientOutput" + DateTime.Now.Month + DateTime.Now.Year + ".csv";
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
                            int columnCount = dgvClients.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dgvClients.Rows.Count + 2];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dgvClients.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dgvClients.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dgvClients.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            outputCsv[outputCsv.Length - 1] += "Filters,Search: " + txtSearch.Text + ",OnlyCompany: " + cbxIsCompany.Checked.ToString();

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
