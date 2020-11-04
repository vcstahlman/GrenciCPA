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

namespace GrenciCPA
{
    public partial class ClientList : Form
    {

        //sql stuff
        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private List<AClient> ClientsObjList;

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

        private void CreateClientList()
        {
            if (txtSearch.Text != "")
            {
                string search = txtSearch.Text;
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
              "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
              "FROM CLIENT_TABLE " +
              "WHERE (CLIENT_TABLE.LAST_NAME LIKE '" + search + "%') ";

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
                            tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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
                            tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void ClientList_Load(object sender, EventArgs e)
        {

            //dgvClients.Rows.Add("Joe", "Smith", "", "123 Clari St", "Clarion", "PA", "Email", "View Client", "View Invoices", "View Returns", "Create Return");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClientsObjList.Clear();//reset the list
            dgvClients.Rows.Clear();//resets the dgv
            if (cbxIsCompany.Checked == true && cbxUnassigned.Checked == true)
            {
                
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE " +
                "WHERE IS_BUSINESS = 1 ;"; //idk why there was this but it is hear if needed again AND CLIENT_ACTIVE = 0
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
                            tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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
            else if (cbxIsCompany.Checked == true)
            {
                
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE " +
                "WHERE IS_BUSINESS = 1;";
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
                            tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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
            else if (cbxUnassigned.Checked == true)
            {
                
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE " +
                "WHERE CLIENT_ACTIVE = 0;";
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
                            tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
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
    }
}
