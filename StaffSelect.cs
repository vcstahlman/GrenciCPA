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
// The StaffSelect form is our solution to keeping track of WHO is working on an instance of the interface, Jobs on the active job form will have a column
// for "assigned to" that will list whatever staff member we select from this page. The user is also allowed to add a new staff member in the event of
// future employees.
namespace GrenciCPA
{
    public partial class StaffSelect : Form
    {
        public StaffSelect()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            StaffAddEdit form = new StaffAddEdit();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }
    }
}
