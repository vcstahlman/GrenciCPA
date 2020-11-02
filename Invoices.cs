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


        private void CreateClientList()
        {
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

        private void FillDGV()//fills in the Datagridview via the list of objects
        {
            
            dgvInvoices.Rows.Clear();
            foreach (AClient aClient in ClientsObjList)
            {
                dgvInvoices.Rows.Add("View", aClient.ClientID, aClient.LastName, aClient.FirstName, aClient.Company,
                    aClient.Phone, aClient.Email, aClient.Active, "Make Payment");
            }
        }
        
        private void Invoices_Load(object sender, EventArgs e)
        {
            //dgvInvoices.Rows.Add("View Invoice", "Smith", "Joe", "", "123-4323", "joe@smiths.com", "Due", "Pay");
        }

        private void cbxOverdue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoices.Columns["View"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex + 7].Value.ToString());//gets the ID

                    ClientView form = new ClientView(IDtoPass);
                    form.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void dgvInvoices_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoices.Columns["View"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());//gets the ID

                    ClientView form = new ClientView(IDtoPass);
                    form.ShowDialog();

                }
                if (e.ColumnIndex == dgvInvoices.Columns["Payment"].Index)
                {
                    int IDtoPass = int.Parse(dgvInvoices.Rows[e.RowIndex].Cells[e.ColumnIndex - 7].Value.ToString());

                    Payments form = new Payments(IDtoPass);
                    form.ShowDialog();
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
            ClientsObjList.Clear();

            if (cbxOverdue.Checked == true)
            {
                
                string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, SS, BIRTHDATE, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, COUNTY, SCHOOL, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, NOTES, OWED_BALANCE " +
                "FROM CLIENT_TABLE " +
                "WHERE OWED_BALANCE > 0";
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
