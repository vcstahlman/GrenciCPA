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
            string GetClientsSQL = "SELECT CLIENT_ID, CLIENT_ACTIVE, FIRST_NAME, LAST_NAME, COMPANY_NAME, EMAIL, PHONE, OWED_BALANCE " +
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
                    if (reader["EMAIL"] != DBNull.Value)
                    {
                        tempClient.Email = reader["EMAIL"] as string;
                    }
                    if (reader["COMPANY_NAME"] != DBNull.Value)
                    {
                        tempClient.Company = reader["COMPANY_NAME"] as string;
                    }
                    if (reader["OWED_BALANCE"] != DBNull.Value)
                    {
                        tempClient.Balance = (reader["OWED_BALANCE"] as double?) ?? 0.0;
                    }
                    if (reader["CLIENT_ACTIVE"] != DBNull.Value)
                    {
                        tempClient.Active = reader.GetBoolean(reader.GetOrdinal("CLIENT_ACTIVE"));
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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments form = new Payments();
            form.ShowDialog();
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

                    Payments form = new Payments();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }
    }
}
