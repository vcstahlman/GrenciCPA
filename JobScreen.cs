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
    public partial class JobScreen : Form
    {
        public JobScreen()
        {
            InitializeComponent();
        }

        private void dgvFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JobScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (btnTimer.Text == "Start Timer")
            {
                btnTimer.Text = "Stop Timer";
                lblTime.Text = DateTime.Now.ToString();
            }
            else btnTimer.Text = "Start Timer";
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            InvoiceScreen form = new InvoiceScreen();
            form.ShowDialog();
        }
    }
}
