﻿/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the AServ class that holds stuff about the services through the project 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AServ
    {
        private int servID;
        private string servName;
        private string servSent;
        private bool active;
        private List<AChar> chars;

        public int ServID { get => servID; set => servID = value; }
        public string ServName { get => servName; set => servName = value; }
        public string ServSent { get => servSent; set => servSent = value; }
        public bool Active { get => active; set => active = value; }
        public List<AChar> Chars { get => chars; set => chars = value; }
    }
}
