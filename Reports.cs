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
<<<<<<< HEAD

=======
            int n = dgvReports.Rows.Add();

            dgvReports.Rows[n].Cells[0].Value = "Joe";
            dgvReports.Rows[n].Cells[1].Value = "Smith";
            dgvReports.Rows[n].Cells[2].Value = "";
            dgvReports.Rows[n].Cells[3].Value = "300";
            dgvReports.Rows[n].Cells[4].Value = "250";
            dgvReports.Rows[n].Cells[5].Value = "50";
            dgvReports.Rows[n].Cells[6].Value = "165";
            dgvReports.Rows[n].Cells[7].Value = "8/12/2020";
            dgvReports.Rows[n].Cells[8].Value = "9/15/2020";
>>>>>>> pr/3
        }
    }
}
