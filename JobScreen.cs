using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Windows.Forms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
            int n = dgvFees.Rows.Add();
            
            dgvFees.Rows[n].Cells[1].Value = "100";
            dgvFees.Rows[n].Cells[2].Value = "2.5";
            
            dgvFees.Rows[n].Cells[4].Value = "10";
            dgvFees.Rows[n].Cells[5].Value = "1";
            dgvFees.Rows[n].Cells[6].Value = "165";
            dgvFees.Rows[n].Cells[7].Value = "8/12/2020";
            dgvFees.Rows[n].Cells[8].Value = "9/15/2020";
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
                timeStarted = DateTime.Now;
                
            }
            else
            {
                double timeend = DateTime.Now.Hour + (DateTime.Now.Minute / 60.0) + (DateTime.Now.Second / 3600.0);
                btnTimer.Text = "Start Timer";
                
                dgvTime.Rows.Add((DateTime.Now - timeStarted).ToString(), timeStarted.ToString(), DateTime.Now.ToString() , "Worked on their taxes");
                time += timeend - timeStart;
                txtDateTime.Text = "Total Elapsed Time: "+ (((int)time * 100 )/100).ToString() + " hours";

            }


        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            //InvoiceScreen form = new InvoiceScreen();
            //form.ShowDialog();

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:/SampleInvoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph("This is a sample invoice." + "\n" + "\n" + "Joe and Joan Smith" + "\n" + "\n" + "\n" + "\n"  + "Schedule C.............................................................................................................$100.00");
            Paragraph p2 = new Paragraph("Total amount due: $100.00");
            document.Add(p);
            document.Add(p2);
            document.Close();
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
