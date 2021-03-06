﻿/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the AInvoice page. it is used to hold information about invoices for the listing of them
///

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
        private decimal amtOwed;
        private decimal amtPaid;
        private string invoiceTxt;
        private string path;
        private DateTime sentDate;

        public int InvoiceID { get => invoiceID; set => invoiceID = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public decimal AmtOwed { get => amtOwed; set => amtOwed = value; }
        public decimal AmtPaid { get => amtPaid; set => amtPaid = value; }
        public string InvoiceTxt { get => invoiceTxt; set => invoiceTxt = value; }
        public string Path { get => path; set => path = value; }
        public DateTime SentDate { get => sentDate; set => sentDate = value; }
    }
}
