/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the AStaff class which holds staff info in the project
///
/// 


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
