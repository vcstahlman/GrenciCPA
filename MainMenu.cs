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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientList form = new ClientList();
            form.ShowDialog();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Invoices form = new Invoices();
            form.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffSelect form = new StaffSelect();
            form.ShowDialog();
        }
    }
}
