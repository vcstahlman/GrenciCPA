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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grenciDBDataSet.INVOICE_TABLE' table. You can move, or remove it, as needed.
            this.iNVOICE_TABLETableAdapter.Fill(this.grenciDBDataSet.INVOICE_TABLE);
            dgvInvoices.Rows.Add("View Invoice", "Smith", "Joe", "", "123-4323", "joe@smiths.com", "Due", "Pay");
        }

        private void cbxOverdue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payments form = new Payments();
            form.ShowDialog();
        }

        private void iNVOICE_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iNVOICE_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }
    }
}
