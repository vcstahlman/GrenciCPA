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

        private bool isSaved = false;
        private bool isNew = false;

        private List<AServ> ServiceObjList;
        private List<AFee> FeeObjList;

        private List<AChar> charList = new List<AChar>();

        public Globals()
        {
            InitializeComponent();

            // new lists
            ServiceObjList = new List<AServ>();
            FeeObjList = new List<AFee>();

            // these will read in & fill the DGV's
            CreateServiceList();
            CreateFeeList();
            FillDGV();

            //this allows multiple lines for the char
            dgvFees.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvServices.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvFees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvServices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Create combobox for associated services in characteristics dgv
            (dgvFees.Columns[4] as DataGridViewComboBoxColumn).DataSource = ServiceObjList;
            (dgvFees.Columns[4] as DataGridViewComboBoxColumn).DisplayMember = "ServName";
            (dgvFees.Columns[4] as DataGridViewComboBoxColumn).ValueMember = "ServID";
        }


        private void CreateServiceList()
        {
            string GetServicesSQL = "SELECT SERV_ID, SERV_NAME, SERV_SENTENCE, SERV_ACTIVE " + "FROM SERVICE_TABLE";
            
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
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateFeeList()
        {

            string GetFeesSQL = "SELECT CHAR_ID, CHAR_NAME, CHAR_COST, CHAR_MIN, ct.SERV_ID, st.SERV_NAME, " +
                "CHAR_ACTIVE FROM CHARACTERISTIC_TABLE ct INNER " +
                "JOIN SERVICE_TABLE st on ct.SERV_ID = st.SERV_ID WHERE SERV_ACTIVE = 1";

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
                    if (reader["SERV_NAME"] != DBNull.Value)
                    {
                        tempFee.ServName = reader["SERV_NAME"] as string;
                    }
                    if (reader["CHAR_ACTIVE"] != DBNull.Value)
                    {
                        tempFee.Active = reader.GetBoolean(reader.GetOrdinal("CHAR_ACTIVE"));
                    }
                    else
                    {
                        tempFee.Active = true; 
                    }


                    //Add the temporary plot stuff from list.
                    FeeObjList.Add(tempFee);

                    tempFee = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FillDGV()//fills in the Datagridview via the list of objects
        {
            foreach (AServ aService in ServiceObjList)
            {
                // if service is active, add values to the row
                if (aService.Active)
                {
                    dgvServices.Rows.Add(aService.ServID, aService.ServName, aService.ServSent, "Save", "Delete");
                }
                
            }
            foreach (AFee aFee in FeeObjList)
            {
                // if fee is active, add values to the row
                if (aFee.Active)
                {
                    dgvFees.Rows.Add(aFee.FeeID, aFee.FeeName, aFee.FeeCost, aFee.FeeMin, aFee.ServID, aFee.ServName, "Save", "Delete");
                }
            }
        }

        private void Fees_Load(object sender, EventArgs e)
        {
           //work in progress
        }

        // prompts the user to save any information entered before closing the form if they have not already
        private void btnDone_Click(object sender, EventArgs e)
        {
            // if isSaved is set to true, do not display a prompt
            if (isSaved)
            {
                this.Close();
            }
            // this prompt is to make sure the user wants to close without saving possible changes
            else
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
            
        }

        // Inserts a new service into the db that the user creates
        private void CreateServices(AServ aServ)
        {
            // query to insert new service into db
            string AddServSQL = "INSERT INTO SERVICE_TABLE (SERV_NAME, SERV_SENTENCE, SERV_ACTIVE) " +
                " VALUES (@pSERV_NAME, @pSERV_SENT, 1) ;";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(AddServSQL, connection);

                //Open new connection
                connection.Open();

                // pulls the values changes from the instance of AServ and adds them to respective @p values stored in db
                using (command = new SqlCommand(AddServSQL, connection))
                {
                    command.Parameters.AddWithValue("@pSERV_NAME", aServ.ServName);
                    command.Parameters.AddWithValue("@pSERV_SENT", aServ.ServSent);

                    int rowsAffected = command.ExecuteNonQuery();

                }
                // close connection
                connection.Close();
            }
            //catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Inserts a new characteristic into the db that the user creates
        private void CreateFees(AFee aFee)
        {
            // query to insert characteristic into db
            string AddFeesSQL = "INSERT INTO CHARACTERISTIC_TABLE (CHAR_NAME, CHAR_COST, CHAR_MIN, SERV_ID, CHAR_ACTIVE) " +
                " VALUES (@pCHAR_NAME, @pCHAR_COST, @pCHAR_MIN, @pSERV_ID, 1) ;";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(AddFeesSQL, connection);

                // open new connection
                connection.Open();

                // pulls the values changes from the instance of AFee and adds them to respective @p values stored in db
                using (command = new SqlCommand(AddFeesSQL, connection))
                {
                    command.Parameters.AddWithValue("@pCHAR_NAME", aFee.FeeName);
                    command.Parameters.AddWithValue("@pCHAR_COST", aFee.FeeCost);
                    command.Parameters.AddWithValue("@pCHAR_MIN", aFee.FeeMin);
                    command.Parameters.AddWithValue("@pSERV_ID", aFee.ServID);

                    int rowsAffected = command.ExecuteNonQuery();

                }
                //close connection
                connection.Close();
            }
            //catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // this function updates the values of a service that the user chooses
        private void UpdateServices(AServ aServ)
        {
            // query to update a service in database
            string SetServSQL = "UPDATE SERVICE_TABLE SET  SERV_SENTENCE = @pSERV_SENT, "
                + "SERV_NAME = @pSERV_NAME, SERV_ACTIVE = @pSERV_ACTIVE WHERE SERV_ID = @pSERV_ID;";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetServSQL, connection);

                // open new connection
                connection.Open();

                // pulls the values changes from the instance of AServ and adds them to respective @p values stored in db
                using (command = new SqlCommand(SetServSQL, connection))
                {
                    command.Parameters.AddWithValue("@pSERV_ID", aServ.ServID);
                    command.Parameters.AddWithValue("@pSERV_NAME", aServ.ServName);
                    command.Parameters.AddWithValue("@pSERV_SENT", aServ.ServSent);
                    command.Parameters.AddWithValue("@pSERV_ACTIVE", aServ.Active);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                // close connection
                connection.Close();

            }
            //catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // This function updates the values of a characteristic that the user chooses
        private void UpdateFees(AFee aFee)
        {
            // query to update a characteristic in database
            string SetFeeSQL = "UPDATE CHARACTERISTIC_TABLE SET CHAR_COST = @pCHAR_COST, "
                + "CHAR_MIN = @pCHAR_MIN, CHAR_NAME = @pCHAR_NAME, SERV_ID = @pSERV_ID WHERE CHAR_ID = @pCHAR_ID;";
            

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetFeeSQL, connection);

                // open new connection
                connection.Open();

                using (command = new SqlCommand(SetFeeSQL, connection))
                {
                    command.Parameters.AddWithValue("@pCHAR_ID", aFee.FeeID);
                    command.Parameters.AddWithValue("@pCHAR_NAME", aFee.FeeName);
                    command.Parameters.AddWithValue("@pCHAR_COST", aFee.FeeCost);
                    command.Parameters.AddWithValue("@pCHAR_MIN", aFee.FeeMin);
                    command.Parameters.AddWithValue("@pSERV_ID", aFee.ServID);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                // close connection
                connection.Close();
            }
            //catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        // This function deletes (technically hides in database) a service that the user chooses
        private void DeleteServices(AServ aServ)
        {
            // query to "delete"
            string SQLServDel = "UPDATE SERVICE_TABLE SET SERV_ACTIVE = 0 WHERE SERV_ID = @SERV_ID";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SQLServDel, connection);

                // open new connection
                connection.Open();

                // gets service ID that we are setting to 0, since we aren't technically deleting the service
                using (command = new SqlCommand(SQLServDel, connection))
                {
                    command.Parameters.AddWithValue("@SERV_ID", aServ.ServID);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                // close connection
                connection.Close();

            }
            // catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        // This function deletes (technically hides in database) a characteristic that the user chooses
        private void DeleteFees(AFee aFee)
        {
            // query to "delete"
            string SQLFeeDel = "UPDATE CHARACTERISTIC_TABLE SET CHAR_ACTIVE = 0 WHERE CHAR_ID = @CHAR_ID";

            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SQLFeeDel, connection);

                // open a new connection
                connection.Open();

                // gets characteristic ID that we are setting to 0, since we aren't technically deleting the characteristic
                using (command = new SqlCommand(SQLFeeDel, connection))
                {
                    command.Parameters.AddWithValue("@CHAR_ID", aFee.FeeID);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                // close connection
                connection.Close();

            }
            // catch
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // if the user clicks "Save" on the Characteristics DGV
                if (e.ColumnIndex == 6)
                {
                    if (isNew == true)
                    {
                        // this is set to true so there won't be a prompt when the user clicks the Done button
                        isSaved = true;

                        // new instance of AFee
                        AFee aFee = new AFee();

                        aFee.FeeID = int.Parse(dgvFees.Rows[e.RowIndex].Cells[0].Value.ToString());
                        aFee.FeeName = dgvFees.Rows[e.RowIndex].Cells[1].Value.ToString();
                        aFee.FeeCost = decimal.Parse(dgvFees.Rows[e.RowIndex].Cells[2].Value.ToString());
                        aFee.FeeMin = decimal.Parse(dgvFees.Rows[e.RowIndex].Cells[3].Value.ToString());  
                        aFee.ServID = (int) dgvFees.Rows[e.RowIndex].Cells[4].Value;

                        // calls CreateFees with instance of aFee
                        CreateFees(aFee);

                        // this will keep us from inserting every existing characteristic that the user wants to edit into the database as a duplicate
                        isNew = false;
                    }
                    else
                    {
                        // sets isSaved to true so there won't be a prompt when the user clicks the Done button
                        isSaved = true;

                        // new instance of AFee
                        AFee aFee = new AFee();

                        aFee.FeeID = int.Parse(dgvFees.Rows[e.RowIndex].Cells[0].Value.ToString());
                        aFee.FeeName = dgvFees.Rows[e.RowIndex].Cells[1].Value.ToString();
                        aFee.FeeCost = decimal.Parse(dgvFees.Rows[e.RowIndex].Cells[2].Value.ToString());
                        aFee.FeeMin = decimal.Parse(dgvFees.Rows[e.RowIndex].Cells[3].Value.ToString());

                        // to read in associated services
                        foreach (AServ aServ in ServiceObjList)
                        {
                            if (aServ.ServName == dgvFees.Rows[e.RowIndex].Cells[5].Value.ToString())
                            {
                                aFee.ServID = aServ.ServID;
                            }
                        }

                        // calls UpdateFees with instance of aFee passed in to update a characteristic
                        UpdateFees(aFee);
                    }
                }
                // If the user clicks on "Delete" column in a characteristic
                else if (e.ColumnIndex == 7)
                {
                    string message = "Are you sure you want to delete this characteristic?";
                    string title = "Confirm Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // prompt to confirm the user wants to delete the characteristic
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        AFee aFee = new AFee();
                        aFee.FeeID = int.Parse(dgvFees.Rows[e.RowIndex].Cells[0].Value.ToString());

                        // calls delete function with aFee instance passed in to hide to column
                        DeleteFees(aFee);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        private void dgvFees_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            AFee aFee = new AFee();
            isNew = true;

            e.Row.Cells[0].Value = 0;
            e.Row.Cells[1].Value = "";
            e.Row.Cells[2].Value = 0.00m;
            e.Row.Cells[3].Value = 0.00m;
            e.Row.Cells[4].Value = 1;
            e.Row.Cells[5].Value = "";
            e.Row.Cells[6].Value = "Save";
            e.Row.Cells[7].Value = "Delete";

        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    if (isNew == true)
                    {
                        isSaved = true;

                        AServ aServ = new AServ();

                        //aServ.ServID = int.Parse(dgvFees.Rows[e.RowIndex].Cells[0].Value.ToString());
                        aServ.ServName = dgvServices.Rows[e.RowIndex].Cells[1].Value.ToString();
                        aServ.ServSent = dgvServices.Rows[e.RowIndex].Cells[2].Value.ToString();

                        CreateServices(aServ);

                        isNew = false;
                    }
                    else
                    {
                        // sets is saved to true so we can close out the Globals form without a prompt
                        isSaved = true;

                        AServ aServ = new AServ();

                        aServ.ServID = int.Parse(dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString());
                        aServ.ServName = dgvServices.Rows[e.RowIndex].Cells[1].Value.ToString();
                        aServ.ServSent = dgvServices.Rows[e.RowIndex].Cells[2].Value.ToString();
                        aServ.Active = true;

                        // calls UpdateServices form with aServ instance passed in to update a specific row
                        UpdateServices(aServ);
                    }

                }
                // If the user clicks "Delete" on the services DGV
                else if (e.ColumnIndex == 4)
                {
                    string message = "Are you sure you want to delete this service?";
                    string title = "Confirm Window";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    // Serves as a confirmation window if the user really wants to delete a service
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        AServ aServ = new AServ();
                        aServ.ServID = int.Parse(dgvServices.Rows[e.RowIndex].Cells[0].Value.ToString());

                        // calls DeleteServices function and passes in aServ instance to hide the row
                        DeleteServices(aServ);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You tried to click the button that was not in a row with data. \n This is the error: " + ex.Message);
            }
        }

        // when the user clicks on an empty service row, this is how the new row will be formatted in
        private void dgvServices_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            AServ aServ = new AServ();
            isNew = true;

            e.Row.Cells[0].Value = 0;
            e.Row.Cells[1].Value = "";
            e.Row.Cells[2].Value = "";
            e.Row.Cells[3].Value = "Save";
            e.Row.Cells[4].Value = "Delete";
        }
    }
    
}
