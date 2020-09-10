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
    public partial class ServiceSelect : Form
    {
        public ServiceSelect()
        {
            InitializeComponent();
        }

        private void ServiceSelect_Load(object sender, EventArgs e)
        {
            tbxDate.Text = DateTime.Now.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            JobScreen form = new JobScreen();
            form.ShowDialog();
        }
    }
}
