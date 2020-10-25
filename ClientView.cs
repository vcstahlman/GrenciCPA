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

// Justin Bloss
// The purpose of the ClientView form is to allow the user to access and see older client records, services provided will be categorized by most current year
// first, with the ability of sorting by date, service provided, dates invoiced, and amounts
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

        public ClientView()
        {
            // test data
            InitializeComponent();
            int n = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[n].Cells[0].Value = "4/12/19";
            dgvClientPast.Rows[n].Cells[1].Value = "Income Tax";
            dgvClientPast.Rows[n].Cells[2].Value = "$125";
            dgvClientPast.Rows[n].Cells[3].Value = "$125";
            dgvClientPast.Rows[n].Cells[4].Value = "4/13/19";

            int j = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[j].Cells[0].Value = "4/8/18";
            dgvClientPast.Rows[j].Cells[1].Value = "Income Tax";
            dgvClientPast.Rows[j].Cells[2].Value = "$125";
            dgvClientPast.Rows[j].Cells[3].Value = "$125";
            dgvClientPast.Rows[j].Cells[4].Value = "4/8/18";

            int m = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[m].Cells[0].Value = "2/23/18";
            dgvClientPast.Rows[m].Cells[1].Value = "Investments";
            dgvClientPast.Rows[m].Cells[2].Value = "$100";
            dgvClientPast.Rows[m].Cells[3].Value = "$100";
            dgvClientPast.Rows[m].Cells[4].Value = "2/23/18";
        }
        public ClientView(int pClientID)
        {
            InitializeComponent();
            clientID = pClientID;
            ClientsObj = new AClient();
            CreateClientList();

            FillClientInfo();
            
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
            lblBalance.Text = "Balance: " + aClient.Balance;
            
            
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
            ServiceSelect form = new ServiceSelect();
            form.ShowDialog();

        }

        // opens up a form to edit client information
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient(clientID);
            form.ShowDialog();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            // work in progress
        }

        // this button will show all Active Jobs for the given client on the Active Job form
        private void btnActive_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void dgvClientPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
