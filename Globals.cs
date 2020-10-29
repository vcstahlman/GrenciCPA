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
// The Globals form is what the user will use to enter in service and fee information, this information will be pulled over to the JobScreen form
// to allow the user to select from here. ALL fees have a related service, the purpose of this being if a service is selected on the jobscreen, the
// only fees that will show are ones that are ASSOCIATED with a specific service. Eventually, we will also have a free service to link miscellaneous
// fees to.
namespace GrenciCPA
{
    public partial class Globals : Form
    {

        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private List<AServ> ServiceObjList;
        private List<AFee> FeeObjList;

        public Globals()
        {
            InitializeComponent();
            ServiceObjList = new List<AServ>();
            FeeObjList = new List<AFee>();
            CreateServiceList();
            CreateFeeList();
            FillDGV();

            //this allows multiple lines for the char
            dgvFees.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvServices.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvFees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvServices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void CreateServiceList()
        {
            string GetServicesSQL = "SELECT SERV_ID, SERV_NAME, SERV_SENTENCE, SERV_ACTIVE " + "FROM SERVICE_TABLE";
            //string GetFeesSQL = "SELECT CHAR_ID, CHAR_NAME, CHAR_COST, CHAR_MIN, SERV_ID " + "FROM CHARACTERISTIC_TABLE";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetServicesSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {


                    AServ tempService = new AServ();



                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempService.ServID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempService.ServName = reader["SERV_NAME"] as string;
                    }
                    if (reader["SERV_SENTENCE"] != DBNull.Value)
                    {
                        tempService.ServSent = reader["SERV_SENTENCE"] as string;
                    }
                    if (reader["SERV_ACTIVE"] != DBNull.Value)
                    {
                        tempService.Active = reader.GetBoolean(reader.GetOrdinal("SERV_ACTIVE"));
                    }


                    //Add the temporary plot stuff from list.
                    ServiceObjList.Add(tempService);

                    tempService = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }
        }

        private void CreateFeeList()
        {

            string GetFeesSQL = "SELECT CHAR_ID, CHAR_NAME, CHAR_COST, CHAR_MIN, SERV_ID, CHAR_ACTIVE " + "FROM CHARACTERISTIC_TABLE";

            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetFeesSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {


                    AFee tempFee = new AFee();



                    if (reader["CHAR_ID"] != DBNull.Value)
                    {
                        tempFee.FeeID = (reader["CHAR_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_NAME"] != DBNull.Value)
                    {
                        tempFee.FeeName = reader["CHAR_NAME"] as string;
                    }
                    if (reader["CHAR_COST"] != DBNull.Value)
                    {
                        tempFee.FeeCost = (reader["CHAR_COST"] as decimal?) ?? 0.00m;
                    }
                    if (reader["CHAR_MIN"] != DBNull.Value)
                    {
                        tempFee.FeeMin = (reader["CHAR_MIN"] as decimal?) ?? 0.00m;
                    }
                    if (reader["SERV_ID"] != DBNull.Value)
                    {
                        tempFee.ServID = (reader["SERV_ID"] as int?) ?? 0;
                    }
                    if (reader["CHAR_ACTIVE"] != DBNull.Value)
                    {
                        tempFee.Active = reader.GetBoolean(reader.GetOrdinal("CHAR_ACTIVE"));
                    }


                    //Add the temporary plot stuff from list.
                    FeeObjList.Add(tempFee);

                    tempFee = null;
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
            foreach (AServ aService in ServiceObjList)
            {
                dgvServices.Rows.Add(aService.ServName, aService.ServSent);
            }
            foreach (AFee aFee in FeeObjList)
            {
                dgvFees.Rows.Add(aFee.FeeName, aFee.FeeCost, aFee.FeeMin, aFee.ServID);
            }
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            // work in progress
        }

        // prompts the user to save any information entered before closing the form if they have not already
        private void btnDone_Click(object sender, EventArgs e)
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

        private void btnSaveFee_Click(object sender, EventArgs e)
        {
            // work in progress
        }

        private void btnSaveServ_Click(object sender, EventArgs e)
        {
            // work in progress
        }
    }
}
