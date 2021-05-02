/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the ATime class which is used to store info about time on the jobscreen
/// 

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class ATime
    {
        private int timeID;
        private int jobID;
        private TimeSpan elapse;
        private DateTime startTime;
        private DateTime endTime;
        private string description;
        

        public int TimeID { get => timeID; set => timeID = value; }
        public TimeSpan Elapse { get => elapse; set => elapse = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string Description { get => description; set => description = value; }
        public int JobID { get => jobID; set => jobID = value; }
       
    }
}
