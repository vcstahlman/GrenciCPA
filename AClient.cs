using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AClient
    {
        //IDS for passing and retreaving
        private int clientID;
        private int parentID;

        //identification variables
        private string firstName;
        private string lastName;
        private string birthdate;
        private string SSN;
        private string company;
        private bool isBusiness;


        //kocation variables
        private string address;
        private string city;
        private string state;
        private string zip;
        private string county;
        private string school;

        //contact variables
        private string phone;
        private string email;

        //misc
        private bool active;
        private double balance;
        private string notes;
        private List<string> characteristics;
        private string preferred;
        private int jobID;
        private string dateSent;
        private float totalBill;
        private string servName;
        private float paymentAmount;



        //accessors and mutators for the class.
        public int ClientID { get => clientID; set => clientID = value; }
        public int ParentID { get => parentID; set => parentID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string SSN1 { get => SSN; set => SSN = value; }
        public string Company { get => company; set => company = value; }
        public bool IsBusiness { get => isBusiness; set => isBusiness = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string County { get => county; set => county = value; }
        public string School { get => school; set => school = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public bool Active { get => active; set => active = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Notes { get => notes; set => notes = value; }
        public List<string> Characteristics { get => characteristics; set => characteristics = value; }
        public string Preferred { get => preferred; set => preferred = value; }
        public int JobID { get => jobID; set => jobID = value; }
        public string DateSent { get => dateSent; set => dateSent = value; }
        public float TotalBill { get => totalBill; set => totalBill = value; }
        public string ServName { get => servName; set => servName = value; }
        public float PaymentAmount { get => paymentAmount; set => paymentAmount = value; }
    }
}
