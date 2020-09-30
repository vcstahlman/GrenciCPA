using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Justin Bloss
// This form will read in from the database all past clients, with leftmost information on the data grid being the most pivotal with identifying a client
namespace GrenciCPA
{
    public partial class Jobs : Form
    {
        public Jobs()
        {
            InitializeComponent();
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
            //test data
            dgvJobs.Rows.Add("Joe", "Smith", "N/A", "N/A", "Income Tax", "Tony Grenci", "View", "Invoice");
        }
    }
}
