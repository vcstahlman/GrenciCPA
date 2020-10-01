using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrenciCPA
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            tbxFirst.Text = "Joe";
            tbxLast.Text = "Smith";
            tbxAddress.Text = "123 Some Rd";
            tbxCity.Text = "Clarion";
            tbxState.Text = "PA";
            tbxZip.Text = "16214";
            tbxSchool.Text = "Clarion";

            

        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
