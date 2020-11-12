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
        private double paymentAmt;
        private DateTime datePaid;

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
        public double PaymentAmt { get => paymentAmt; set => paymentAmt = value; }
        public DateTime DatePaid { get => datePaid; set => datePaid = value; }
    }
}
