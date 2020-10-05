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
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();

            int n = dgvClients.Rows.Add();
            dgvClients.Rows[n].Cells[0].Value = "Y";
            dgvClients.Rows[n].Cells[1].Value = "Smith";
            dgvClients.Rows[n].Cells[2].Value = "Joe & Joan";
            dgvClients.Rows[n].Cells[3].Value = "Individual";
            dgvClients.Rows[n].Cells[4].Value = "N/A";
            dgvClients.Rows[n].Cells[5].Value = "123 Main Street";
            dgvClients.Rows[n].Cells[6].Value = "Clarion";
            dgvClients.Rows[n].Cells[7].Value = "PA, 16214";
            dgvClients.Rows[n].Cells[8].Value = "814-393-2500";
            dgvClients.Rows[n].Cells[9].Value = "View Client";
            dgvClients.Rows[n].Cells[10].Value = "View Invoices";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClientView_Click(object sender, EventArgs e)
        {
            ClientView form = new ClientView();
            form.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientList_Load(object sender, EventArgs e)
        {

            //dgvClients.Rows.Add("Joe", "Smith", "", "123 Clari St", "Clarion", "PA", "Email", "View Client", "View Invoices", "View Returns", "Create Return");

        }
    }
}
