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

        }

        private void CreateClientList()
        {
            string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, ST_ADDRESS, " +
                "CITY, STATE_AB, ZIP, EMAIL, PHONE, IS_BUSINESS, COMPANY_NAME, PARENT_CLIENT, " +
                "FROM CLIENT_TABLE;";

            string GetParentSQL = "SELECT FIRST_NAME, LAST_NAME FROM CLIENT_TABLE WHERE CLIENT_ID = ";
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
                    //Create a temporary candy object to hold our data


                    AClient tempClient = new AClient();



                    if (reader["CLIENT_ID"] != DBNull.Value)
                    {
                        tempClient.ClientID = (reader["CLIENT_ID"] as int?) ?? 0;//"PlotInfo.Section"
                    }
                    if (reader["FIRST_NAME"] != DBNull.Value)
                    {
                        tempClient.FirstName = reader["FIRST_NAME"] as string;//"PlotInfo.Row"
                    }
                    if (reader["LAST_NAME"] != DBNull.Value)
                    {
                        tempClient.LastName = reader["LAST_NAME"] as string;//"PlotInfo.Row"
                    }
                    if (reader["BIRTHDATE"] != DBNull.Value)
                    {
                        tempClient.Birthdate = reader["BIRTHDATE"] as string;//"PlotInfo.Row"
                    }

                    if (reader["DatePurchased"] != DBNull.Value)
                    {
                        tempPlot.PDate1 = reader["DatePurchased"] as string;//"PlotInfo.DatePurchased"
                    }
                    if (reader["PurchasedAmount"] != DBNull.Value)
                    {
                        tempPlot.PAmount1 = (reader["PurchasedAmount"] as double?) ?? 0.0;//"PlotInfo.AmountPurchased"
                    }


                    //Add the temporary plot stuff from list.
                    ClientsObjList.Add(tempClient);

                    tempClient = null;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve plots from Database.! \n Error reads: " + ex.Message);
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClientView_Click(object sender, EventArgs e)
        {
            ClientView form = new ClientView();
            form.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientList_Load(object sender, EventArgs e)
        {

            //dgvClients.Rows.Add("Joe", "Smith", "", "123 Clari St", "Clarion", "PA", "Email", "View Client", "View Invoices", "View Returns", "Create Return");

        }
    }
}
