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
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void ClientList_Load(object sender, EventArgs e)
        {
            dgvClients.Rows.Add("Joe", "Smith", "", "123 Clari St", "Clarion", "PA", "Email", "View Client", "View Invoices", "View Returns", "Create Return");
        }
    }
}
