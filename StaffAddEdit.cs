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
// The StaffAddEdit form is meant for both new staff members that need to enter in their information on this screen, as well as editing current staff
// information.
namespace GrenciCPA
{
    public partial class StaffAddEdit : Form
    {

        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private bool isNew = false;
        private int staffID = 0;
        private List<AStaff> StaffObjList;

        public StaffAddEdit()
        {
            InitializeComponent();
            StaffObjList = new List<AStaff>();
            isNew = true;
        }

        public StaffAddEdit(int pStaffID)
        {
            InitializeComponent();
            staffID = pStaffID;
            StaffObjList = new List<AStaff>();
            CreateStaffList();
            isNew = false;
            FillStaff(staffID);
        }

        private void CreateStaffList()
        {
            string GetStaffSQL = "SELECT STAFF_ID, STAFF_FIRST_NAME, STAFF_LAST_NAME, STAFF_RATE_PER_HR, STAFF_ACTIVE " + "FROM STAFF_TABLE";


            //Pulled from App.config
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(GetStaffSQL, connection);
                //Open the connection
                connection.Open();
                //Create a SQL Data Reader object
                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                //Keep reading as long as I have data from the database to read



                while (reader.Read())
                {

                    AStaff tempStaff = new AStaff();

                    if (reader["STAFF_ID"] != DBNull.Value)
                    {
                        tempStaff.StaffID = (reader["STAFF_ID"] as int?) ?? 0;
                    }
                    if (reader["STAFF_FIRST_NAME"] != DBNull.Value)
                    {
                        tempStaff.StaffFirstName = reader["STAFF_FIRST_NAME"] as string;
                    }
                    if (reader["STAFF_LAST_NAME"] != DBNull.Value)
                    {
                        tempStaff.StaffLastName = reader["STAFF_LAST_NAME"] as string;
                    }
                    if (reader["STAFF_RATE_PER_HR"] != DBNull.Value)
                    {
                        tempStaff.StaffRate = (reader["STAFF_RATE_PER_HR"] as decimal?) ?? 0.00m;
                    }
                    if (reader["STAFF_ACTIVE"] != DBNull.Value)
                    {
                        tempStaff.Active = reader.GetBoolean(reader.GetOrdinal("STAFF_ACTIVE"));
                    }


                    //Add the temporary plot stuff from list.
                    StaffObjList.Add(tempStaff);

                    tempStaff = null;
                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not retrieve clients from Database.! \n Error reads: " + ex.Message);
            }
        }
        private void FillStaff(int staffID)
        {
            foreach (AStaff staff in StaffObjList)
            {
                if (staffID == staff.StaffID)
                {
                    tbxFirst.Text = staff.StaffFirstName;
                    tbxLast.Text = staff.StaffLastName;

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isNew)
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
            else
                this.Close();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string SetOtherSQL = "INSERT INTO STAFF_TABLE (STAFF_FIRST_NAME, STAFF_LAST_NAME, STAFF_RATE_PER_HR) " +
                           "OUTPUT INSERTED.STAFF_ID " +
                           "VALUES (@FIRST, @LAST, @RATE ); ";

            if (!isNew) SetOtherSQL = "UPDATE STAFF_TABLE STAFF_FIRST_NAME = @FIRST, STAFF_LAST_NAME = @LAST, STAFF_RATE_PER_HR = @RATE " +
                                     "WHERE STAFF_ID= " + staffID + " ; ";
            connectionString = Properties.Settings.Default.GrenciDBConnectionString;
            try
            {
                connection = new SqlConnection(connectionString);
                command = new SqlCommand(SetOtherSQL, connection);
                //Open the connection
                connection.Open();


                command.Parameters.AddWithValue("@FIRST", tbxFirst.Text);
                command.Parameters.AddWithValue("@LAST", tbxLast.Text);
                int rate = 0;
                int.TryParse(tbxRate.Text, out rate);
                command.Parameters.AddWithValue("@RATE", rate);



                if (isNew)
                {
                    var lastID = command.ExecuteScalar(); //this gets the data of the client that was just added into the system
                    staffID = Convert.ToInt32(lastID);
                }


                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();
            }






            catch (Exception ex)
            {

                MessageBox.Show("Could not open or insert data! \nError: " + ex.Message);
            }
            this.Close();
        }
    }
}
