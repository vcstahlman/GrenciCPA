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
            
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            
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

        
    }
}
