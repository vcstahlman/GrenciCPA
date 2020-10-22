using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

// Justin Bloss
// The JobScreen form is where the user enters in services provided for a client and takes time of each service to calculate a total for the invoice
namespace GrenciCPA
{
    public partial class JobScreen : Form
    {

        public double time;
        public DateTime timeStarted;
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
            // TODO: This line of code loads data into the 'grenciDBDataSet.JOB_COMPONENT_TABLE' table. You can move, or remove it, as needed.
            this.jOB_COMPONENT_TABLETableAdapter.Fill(this.grenciDBDataSet.JOB_COMPONENT_TABLE);
            // TODO: This line of code loads data into the 'grenciDBDataSet.TIME_TABLE' table. You can move, or remove it, as needed.
            this.tIME_TABLETableAdapter.Fill(this.grenciDBDataSet.TIME_TABLE);
            // test data
            int n = dgvFees.Rows.Add();
            
            dgvFees.Rows[n].Cells[2].Value = "100";
            dgvFees.Rows[n].Cells[3].Value = "2.5";
            dgvFees.Rows[n].Cells[4].Value = "165";
            dgvFees.Rows[n].Cells[5].Value = "8/12/2020";
            dgvFees.Rows[n].Cells[6].Value = "9/15/2020";
        }

        // this button allows the user to change client information, like home address or telephone number, and inputs the new info to the jobScreen
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        // To ensure user saves all information before completing a job, we have entered in this message prompt as a reminder
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

        // Working timer, this is pivotal to the form as clients are charged for services based on an hourly rate
        private void btnTimer_Click(object sender, EventArgs e)
        {

            if (btnTimer.Text == "Start Timer")
            {
                btnTimer.Text = "Stop Timer";
                timeStart = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                timeStarted = DateTime.Now;
                
            }
            else
            {
                
                double timeend = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                btnTimer.Text = "Start Timer";

                Description f1 = new Description();
                f1.ShowDialog();
                string timeDesc = f1.getDesc();

                dgvTime.Rows.Add((DateTime.Now - timeStarted).ToString(), timeStarted.ToString(), DateTime.Now.ToString(), timeDesc);
                time += timeend - timeStart;
                txtDateTime.Text = "Total Elapsed Time: " + (((int)time * 100) / 100).ToString() + " hours";
            }


        }

        // Once the Complete button is clicked, the user will be taken to the Invoice form with services and amount listed
        private void btnComplete_Click(object sender, EventArgs e)
        {
            
            InvoiceScreen form = new InvoiceScreen();
            form.ShowDialog();
        }

        // Allows the user to edit the timer incase of user error (ex. forgot to click the Start Timer button or let it run for too long)
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

        private void tIME_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tIME_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }
    }
}
