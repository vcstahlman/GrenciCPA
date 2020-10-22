// Authors: Justin Bloss, WIll Hofman, Victor Stahlman, and Cam Weaver
// Page: This form will read in from the database all past clients, with leftmost information on the data grid being the most pivotal with identifying a client

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
    public partial class Jobs : Form
    {

        //sql stuff
        /*private string connectionString;
        private SqlCommand command;
        private SqlConnection connection;*/

        public Jobs()
        {
            InitializeComponent();
        }

        public Jobs(int pID, int ptype)
        {
            InitializeComponent();
            //we will use this when we pass in an id and need to run a different load

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            JobScreen form = new JobScreen();
            form.ShowDialog();
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grenciDBDataSet.JOB_TABLE' table. You can move, or remove it, as needed.
            
            //test data
            
        }

        
    }
}
