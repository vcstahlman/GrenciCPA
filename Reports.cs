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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            int n = dgvReports.Rows.Add();

            dgvReports.Rows[n].Cells[0].Value = "Joe";
            dgvReports.Rows[n].Cells[1].Value = "Smith";
            dgvReports.Rows[n].Cells[2].Value = "";
            dgvReports.Rows[n].Cells[3].Value = "Income Tax";
            dgvReports.Rows[n].Cells[4].Value = "155";
            dgvReports.Rows[n].Cells[5].Value = "130";
            dgvReports.Rows[n].Cells[6].Value = "25";
            dgvReports.Rows[n].Cells[7].Value = "1235";
            dgvReports.Rows[n].Cells[8].Value = "5/14/2020";
            n = dgvReports.Rows.Add();

            dgvReports.Rows[n].Cells[0].Value = "Joe";
            dgvReports.Rows[n].Cells[1].Value = "Smith";
            dgvReports.Rows[n].Cells[2].Value = "";
            dgvReports.Rows[n].Cells[3].Value = "Sales Tax";
            dgvReports.Rows[n].Cells[4].Value = "200";
            dgvReports.Rows[n].Cells[5].Value = "200";
            dgvReports.Rows[n].Cells[6].Value = "0";
            dgvReports.Rows[n].Cells[7].Value = "1254";
            dgvReports.Rows[n].Cells[8].Value = "8/17/2020";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
