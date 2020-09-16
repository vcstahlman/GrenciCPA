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
            dgvReports.Rows[n].Cells[3].Value = "Income Taxes";
            dgvReports.Rows[n].Cells[4].Value = "300";
            dgvReports.Rows[n].Cells[5].Value = "250";
            dgvReports.Rows[n].Cells[6].Value = "50";
            dgvReports.Rows[n].Cells[7].Value = "1232";
            dgvReports.Rows[n].Cells[8].Value = "8/12/2020";

            n = dgvReports.Rows.Add();

            dgvReports.Rows[n].Cells[0].Value = "Joe";
            dgvReports.Rows[n].Cells[1].Value = "Smith";
            dgvReports.Rows[n].Cells[2].Value = "";
            dgvReports.Rows[n].Cells[3].Value = "Sales Taxes";
            dgvReports.Rows[n].Cells[4].Value = "150";
            dgvReports.Rows[n].Cells[5].Value = "140";
            dgvReports.Rows[n].Cells[6].Value = "10";
            dgvReports.Rows[n].Cells[7].Value = "1300";
            dgvReports.Rows[n].Cells[8].Value = "4/11/2020";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
