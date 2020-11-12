using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AInvoice
    {
        private int invoiceID;
        private int jobID;
        private double amtOwed;
        private double amtPaid;
        private string invoiceTxt;
        private string path;
        private DateTime sentDate;

        public int InvoiceID { get => invoiceID; set => invoiceID = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public double AmtOwed { get => amtOwed; set => amtOwed = value; }
        public double AmtPaid { get => amtPaid; set => amtPaid = value; }
        public string InvoiceTxt { get => invoiceTxt; set => invoiceTxt = value; }
        public string Path { get => path; set => path = value; }
        public DateTime SentDate { get => sentDate; set => sentDate = value; }
    }
}
