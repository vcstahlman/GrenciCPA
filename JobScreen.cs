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

        public double time;
        public double timestart;
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
                timestart = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
            }
            else
            {
                double timeend = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                btnTimer.Text = "Start Timer";
                dgvTime.Rows.Add((timeend - timestart).ToString(), timestart.ToString(), timeend.ToString() , "Worked on Income Tax");
                time += timeend - timestart;
                lblTime.Text = "Total Elapsed Time: "+ (((int)time * 100 )/100).ToString();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            InvoiceScreen form = new InvoiceScreen();
            form.ShowDialog();
        }
    }
}
