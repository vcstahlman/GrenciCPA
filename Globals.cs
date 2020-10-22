using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Justin Bloss
// The Globals form is what the user will use to enter in service and fee information, this information will be pulled over to the JobScreen form
// to allow the user to select from here. ALL fees have a related service, the purpose of this being if a service is selected on the jobscreen, the
// only fees that will show are ones that are ASSOCIATED with a specific service. Eventually, we will also have a free service to link miscellaneous
// fees to.
namespace GrenciCPA
{
    public partial class Globals : Form
    {
        public Globals()
        {
            // test data
            InitializeComponent();
            int n = dgvServices.Rows.Add();
            dgvServices.Rows[n].Cells[0].Value = "Income Taxes";
            dgvServices.Rows[n].Cells[1].Value = "$100";

            int x = dgvServices.Rows.Add();
            dgvServices.Rows[x].Cells[0].Value = "Payroll";
            dgvServices.Rows[x].Cells[1].Value = "$150";


            int m = dgvFees.Rows.Add();
            dgvFees.Rows[m].Cells[0].Value = "Dependents";
            dgvFees.Rows[m].Cells[1].Value = "$5";
            dgvFees.Rows[m].Cells[3].Value = "Income Taxes";

            int j = dgvFees.Rows.Add();
            dgvFees.Rows[j].Cells[0].Value = "Dependents Attending College";
            dgvFees.Rows[j].Cells[1].Value = "$5";
            dgvFees.Rows[j].Cells[3].Value = "Income Taxes";

            int l = dgvFees.Rows.Add();
            dgvFees.Rows[l].Cells[0].Value = "Amended Return";
            dgvFees.Rows[l].Cells[1].Value = "$2";
            dgvFees.Rows[l].Cells[3].Value = "Income Taxes";

            int k = dgvFees.Rows.Add();
            dgvFees.Rows[k].Cells[0].Value = "Schedule C";
            dgvFees.Rows[k].Cells[1].Value = "$2";
            dgvFees.Rows[k].Cells[3].Value = "Income Taxes";

            int v = dgvFees.Rows.Add();
            dgvFees.Rows[v].Cells[0].Value = "Earned Income Credit";
            dgvFees.Rows[v].Cells[1].Value = "$1";
            dgvFees.Rows[v].Cells[3].Value = "Income Taxes";

            int a = dgvFees.Rows.Add();
            dgvFees.Rows[a].Cells[0].Value = "Employees";
            dgvFees.Rows[a].Cells[1].Value = "$5";
            dgvFees.Rows[a].Cells[3].Value = "Payroll";

            int b = dgvFees.Rows.Add();
            dgvFees.Rows[b].Cells[0].Value = "Tipped Employees";
            dgvFees.Rows[b].Cells[1].Value = "$1";
            dgvFees.Rows[b].Cells[3].Value = "Payroll";

            int c = dgvFees.Rows.Add();
            dgvFees.Rows[c].Cells[0].Value = "Payroll Tax Returns";
            dgvFees.Rows[c].Cells[1].Value = "$150";
            dgvFees.Rows[c].Cells[3].Value = "Payroll";
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grenciDBDataSet.SERVICE_TABLE' table. You can move, or remove it, as needed.
            this.sERVICE_TABLETableAdapter.Fill(this.grenciDBDataSet.SERVICE_TABLE);
            // TODO: This line of code loads data into the 'grenciDBDataSet.CHARACTERISTIC_TABLE' table. You can move, or remove it, as needed.
            this.cHARACTERISTIC_TABLETableAdapter.Fill(this.grenciDBDataSet.CHARACTERISTIC_TABLE);
            // TODO: This line of code loads data into the 'grenciDBDataSet.CHARACTERISTIC_TABLE' table. You can move, or remove it, as needed.
            this.cHARACTERISTIC_TABLETableAdapter.Fill(this.grenciDBDataSet.CHARACTERISTIC_TABLE);
            // TODO: This line of code loads data into the 'grenciDBDataSet.SERVICE_TABLE' table. You can move, or remove it, as needed.
            this.sERVICE_TABLETableAdapter.Fill(this.grenciDBDataSet.SERVICE_TABLE);
            // TODO: This line of code loads data into the 'grenciDBDataSet.SERVICE_TABLE' table. You can move, or remove it, as needed.
            this.sERVICE_TABLETableAdapter.Fill(this.grenciDBDataSet.SERVICE_TABLE);
            // work in progress
        }

        // prompts the user to save any information entered before closing the form if they have not already
        private void btnDone_Click(object sender, EventArgs e)
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

        private void btnSaveFee_Click(object sender, EventArgs e)
        {
            // work in progress
        }

        private void btnSaveServ_Click(object sender, EventArgs e)
        {
            // work in progress
        }

        private void sERVICE_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICE_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }

        private void sERVICE_TABLEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sERVICE_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }

        private void cHARACTERISTIC_TABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cHARACTERISTIC_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }

        private void cHARACTERISTIC_TABLEBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.cHARACTERISTIC_TABLEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.grenciDBDataSet);

        }
    }
}
