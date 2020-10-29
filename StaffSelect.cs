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
// The StaffSelect form is our solution to keeping track of WHO is working on an instance of the interface, Jobs on the active job form will have a column
// for "assigned to" that will list whatever staff member we select from this page. The user is also allowed to add a new staff member in the event of
// future employees.
namespace GrenciCPA
{
    public partial class StaffSelect : Form
    {

        private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;

        private int staffID = 0;
        private List<AStaff> StaffObjList;


        public StaffSelect()
        {
            InitializeComponent();
            StaffObjList = new List<AStaff>();
            CreateStaffList();
            FillStaffDropdown();
        }
        


        private void CreateStaffList()
        {
            string GetStaffSQL = "SELECT STAFF_ID, STAFF_FIRST_NAME, STAFF_LAST_NAME, STAFF_RATE_PER_HR, STAFF_ACTIVE FROM STAFF_TABLE";


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


        private void FillStaffDropdown()
        {
            foreach (AStaff aStaff in StaffObjList)
            {
                cboStaff.Items.Add(aStaff.StaffFirstName + " " + aStaff.StaffLastName);
            }
           
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (AStaff aStaff in StaffObjList)
            {
                if (cboStaff.Text == aStaff.StaffFirstName + " " + aStaff.StaffLastName)
                    staffID = aStaff.StaffID;
            }
            if (staffID != 0)
            {
                Jobs form = new Jobs(staffID, " ");//way to quickly make an overload on the jobs
                form.ShowDialog();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (AStaff aStaff in StaffObjList)
            {
                if (cboStaff.Text == aStaff.StaffFirstName + " " + aStaff.StaffLastName)
                  staffID = aStaff.StaffID;  
            }
            if (staffID != 0)
            {
                StaffAddEdit form = new StaffAddEdit(staffID);
                form.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffAddEdit form = new StaffAddEdit();
            form.ShowDialog();
        }
    }
}
