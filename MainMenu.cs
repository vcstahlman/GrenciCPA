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
// The purpose of this form is to act as a fully functioning main menu screen that grants the user access to other forms through button clicks
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
            // this button creates an instance of the clients form that stores in all past client info through the database
            ClientList form = new ClientList();
            form.ShowDialog();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            // this button takes the user to the active jobs form, showing all present clients who still need to be worked on
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            // this button instantiates a form that shows all outstanding invoices that have either been completed or still need to be paid off
            Invoices form = new Invoices();
            form.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // this button instantiates a form that shows staff data and allows the user to enter in their own information
            StaffSelect form = new StaffSelect();
            form.ShowDialog();
        }

        private void btnGlobals_Click(object sender, EventArgs e)
        {
            // this button instantiates a form that shows two data grid views with all outstanding global variables (ex. services, costs, and fees associated)
            Globals form = new Globals();
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // this button instantiates a form that replicates a reports page, where the user can conduct advanced searches based on specific parameters
            Reports form = new Reports();
            form.ShowDialog();
        }
    }
}
