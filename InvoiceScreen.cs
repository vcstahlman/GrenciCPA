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
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.IO;
using System.CodeDom;

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
                txtClientName.ReadOnly = false;
                txtAmtOwed.ReadOnly = false;
                txtSrvDS1.ReadOnly = false;
                txtSrvAmt1.ReadOnly = false;
                txtSrvLabel1.ReadOnly = false;
                txtSrvLabel2.ReadOnly = false;
                txtSrvDS2.ReadOnly = false;
                txtSrvAmt2.ReadOnly = false;
                txtSrvLabel3.ReadOnly = false;
                txtSrvAmt3.ReadOnly = false;
                txtSrvDS3.ReadOnly = false;


                btnEdit.Text = "Stop Edit";
            }

            // upon a second button click, all textboxes are set back to readonly mode, and the button text is set to the default string "Edit"
            else
            {
                txtClientName.ReadOnly = true;
                txtAmtOwed.ReadOnly = true;
                txtSrvDS1.ReadOnly = true;
                txtSrvAmt1.ReadOnly = true;
                txtSrvLabel1.ReadOnly = true;
                txtSrvLabel2.ReadOnly = true;
                txtSrvDS2.ReadOnly = true;
                txtSrvAmt2.ReadOnly = true;
                txtSrvLabel3.ReadOnly = true;
                txtSrvAmt3.ReadOnly = true;
                txtSrvDS3.ReadOnly = true;


                btnEdit.Text = "Edit";
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            CreateMailItem();
        }

        private void CreateMailItem()
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            oMailItem.To = "whoffman21279@gmail.com";
            oMailItem.Subject = "Grenci CPA Invoice";

            List<string> attachments = new List<string>();
            //attachments.Add(@"C:\Users\hoffmanw\Documents\Tests\test.txt");

            //oMailItem.Attachments.Add(attachments[0]);
            oMailItem.Display(true);
        }
    }
}