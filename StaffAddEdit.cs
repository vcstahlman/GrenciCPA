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
// The StaffAddEdit form is meant for both new staff members that need to enter in their information on this screen, as well as editing current staff
// information.
namespace GrenciCPA
{
    public partial class StaffAddEdit : Form
    {
        public StaffAddEdit()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
