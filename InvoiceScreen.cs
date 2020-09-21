
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
            this.Close();
        }

        private void btnMakeInvoice_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("SampleInvoice.pdf", FileMode.Create));
            document.Open();
            Paragraph p = new Paragraph("This is a sample invoice." + "\n" + "\n" + "Joe and Joan Smith" + "\n" + "\n" + "\n" + "\n" + "Schedule C.............................................................................................................$100.00");
            Paragraph p2 = new Paragraph("Total amount due: $275.00");
            document.Add(p);
            document.Add(p2);
            document.Close();
        }
    }
}
