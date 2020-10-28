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
        System.Windows.Forms.Timer tmr = null;

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
            //JobScreen form = new JobScreen();
            //form.ShowDialog();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartTimer()
        {
            tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tbxDate.Text = DateTime.Now.ToString();
        }
    }
}
