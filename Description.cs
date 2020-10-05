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
    public partial class Description : Form
    {
        private string timeDescription;
        public Description()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timeDescription = txtDescription.Text;
            this.Close();
        }

        public string getDesc()
        {
            return this.timeDescription;
        }
    }
}
