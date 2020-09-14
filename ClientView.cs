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
    public partial class ClientView : Form
    {
        public ClientView()
        {
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


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            ServiceSelect form = new ServiceSelect();
            form.ShowDialog();

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void dgvClientPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
