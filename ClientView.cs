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
// The purpose of the ClientView form is to allow the user to access and see older client records, services provided will be categorized by most current year
// first, with the ability of sorting by date, service provided, dates invoiced, and amounts
namespace GrenciCPA
{
    public partial class ClientView : Form
    {
        public ClientView()
        {
            // test data
            InitializeComponent();
            int n = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[n].Cells[0].Value = "4/12/19";
            dgvClientPast.Rows[n].Cells[1].Value = "Income Tax";
            dgvClientPast.Rows[n].Cells[2].Value = "$125";
            dgvClientPast.Rows[n].Cells[3].Value = "$125";
            dgvClientPast.Rows[n].Cells[4].Value = "4/13/19";

            int j = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[j].Cells[0].Value = "4/8/18";
            dgvClientPast.Rows[j].Cells[1].Value = "Income Tax";
            dgvClientPast.Rows[j].Cells[2].Value = "$125";
            dgvClientPast.Rows[j].Cells[3].Value = "$125";
            dgvClientPast.Rows[j].Cells[4].Value = "4/8/18";

            int m = dgvClientPast.Rows.Add();
            dgvClientPast.Rows[m].Cells[0].Value = "2/23/18";
            dgvClientPast.Rows[m].Cells[1].Value = "Investments";
            dgvClientPast.Rows[m].Cells[2].Value = "$100";
            dgvClientPast.Rows[m].Cells[3].Value = "$100";
            dgvClientPast.Rows[m].Cells[4].Value = "2/23/18";
        }

        //Prompt to ensure the user saves all changes made to form before closing
        private void button3_Click(object sender, EventArgs e)
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

        // this button will take the user to the ServiceSelect form, allowing them to select a staff member from a dropdown and bringing them to the JobScreen form
        // for a new job.
        private void btnNewJob_Click(object sender, EventArgs e)
        {
            ServiceSelect form = new ServiceSelect();
            form.ShowDialog();

        }

        // opens up a form to edit client information
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            // work in progress
        }

        // this button will show all Active Jobs for the given client on the Active Job form
        private void btnActive_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void dgvClientPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Allows the user to edit client notes
        private void btnEditNotes_Click(object sender, EventArgs e)
        {
            rtbNotes.ReadOnly = false;
            if (btnEditNotes.Text == "Edit Notes")
            {
                rtbNotes.ReadOnly = false;
                btnEditNotes.Text = "Save Notes";
            }
            else if (btnEditNotes.Text == "Save Notes")
            {
                rtbNotes.ReadOnly = true;
                btnEditNotes.Text = "Edit Notes";
            }
        }
    }
}
