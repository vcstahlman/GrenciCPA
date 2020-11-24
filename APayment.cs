using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class APayment
    {

        private int paymentID;
        private int clientID;
        private string paymentType;
        private decimal paymentAmt;
        private string clientFirst;
        private string clientLast;
        private string companyName;
        private bool isBusiness;
        private decimal owedBalance;
        private DateTime datePaid;

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public decimal PaymentAmt { get => paymentAmt; set => paymentAmt = value; }
        public string ClientFirst { get => clientFirst; set => clientFirst = value; }
        public string ClientLast { get => clientLast; set => clientLast = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public bool IsBusiness { get => isBusiness; set => isBusiness = value; }
        public decimal OwedBalance { get => owedBalance; set => owedBalance = value; }
        public DateTime DatePaid { get => datePaid; set => datePaid = value; }
    }
}
