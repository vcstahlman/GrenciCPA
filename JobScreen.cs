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
        public double timeStart;
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
                timeStart = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                
            }
            else
            {
                double timeend = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                btnTimer.Text = "Start Timer";
                
                dgvTime.Rows.Add((timeend - timeStart).ToString(), timeStart.ToString(), timeend.ToString() , "Worked on their taxes");
                time += timeend - timeStart;
                txtDateTime.Text = "Total Elapsed Time: "+ (((int)time * 100 )/100).ToString() + " hours";

            }


        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            InvoiceScreen form = new InvoiceScreen();
            form.ShowDialog();
        }

        private void btnEditTime_Click(object sender, EventArgs e)
        {
            if (btnEditTime.Text == "Edit Time")
            {
                lblAddMinutes.Visible = true;
                cmboAddTime.Visible = true;
                lblAddTime.Visible = true;
                txtAddTime.Visible = true;
                lblSubtractTime.Visible = true;
                txtSubtract.Visible = true;

                btnEditTime.Text = "Finish Editing";
            }

            else
            {
                lblAddMinutes.Visible = false;
                lblAddTime.Visible = false;
                lblSubtractTime.Visible = false;
                txtAddTime.Text = "";
                txtAddTime.Visible = false;
                txtSubtract.Text = "";
                txtSubtract.Visible = false;
                cmboAddTime.Items.Clear();
                cmboAddTime.Visible = false;

                btnEditTime.Text = "Edit Time";
            }
        }
    }
}
