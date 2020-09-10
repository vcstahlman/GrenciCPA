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
    public partial class ClientView : Form
    {
        public ClientView()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewJob_Click(object sender, EventArgs e)
        {
            ServiceSelect form = new ServiceSelect();
            form.ShowDialog();

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            AddClient form = new AddClient();
            form.ShowDialog();
        }

        private void ClientView_Load(object sender, EventArgs e)
        {

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            Jobs form = new Jobs();
            form.ShowDialog();
        }

        private void dgvClientPast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
