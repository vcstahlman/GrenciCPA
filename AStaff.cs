using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AStaff
    {
        // IDs for passing and retrieving
        private int staffID;

        // identification vars
        private string staffFirstName;
        private string staffLastName;
        private decimal staffRate;
        private bool active;

        // accessors and mutators for AStaff class
        public int StaffID { get => staffID; set => staffID = value; }
        public string StaffFirstName { get => staffFirstName; set => staffFirstName = value; }
        public string StaffLastName { get => staffLastName; set => staffLastName = value; }
        public decimal StaffRate { get => staffRate; set => staffRate = value; }
        public bool Active { get => active; set => active = value; }

    }
}
