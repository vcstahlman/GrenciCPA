
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

// Justin Bloss
// The purpose of this form is to allow the user to create and either print or email an invoice to a client, amounts are generated based on what is entered
// on the JobScreen form in terms of costs.
namespace GrenciCPA
{
    public partial class InvoiceScreen : Form
    {
        public InvoiceScreen()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        private void btnMakeInvoice_Click(object sender, EventArgs e)
        {
            // Once this button is clicked, it will generated a new pdf and save it to the user's computer, in case they want to print it out or
            // save it for later on
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("SampleInvoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph("This is a sample invoice." + "\n" + "\n" + "Joe and Joan Smith" + "\n" + "\n" + "\n" + "\n" + "Schedule C.............................................................................................................$100.00");
            Paragraph p2 = new Paragraph("Total amount due: $275.00");
            document.Add(p);
            document.Add(p2);
            document.Close();
        }

        // allows the user to edit the key values that go into creating an invoice (ex. Client name, amount on the invoice, and services provided)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // if the user clicks the button, the textboxes' readonly values will be set to false, allowing for editing, also changing the text of the
            // button to show the user is in edit mode
            if (btnEdit.Text == "Edit")
            {
                txtClient.ReadOnly = false;
                txtAmtOwed.ReadOnly = false;
                txtServices.ReadOnly = false;
                btnEdit.Text = "Stop Edit";
            }
            
            // upon a second button click, all textboxes are set back to readonly mode, and the button text is set to the default string "Edit"
            else
            {
                txtClient.ReadOnly = true;
                txtAmtOwed.ReadOnly = true;
                txtServices.ReadOnly = true;
                btnEdit.Text = "Edit";
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
