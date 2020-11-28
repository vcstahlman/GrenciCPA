/// Grenci CPA 411 Project
/// Authors: Justin Bloss, Will Hoffman, Victor Stahlman, & Cameron Weaver
/// Project goal: make a program for Dr. Anthony Grenci to use at his CPA firm to keep track of billing, and automate the calculation process.
/// Page: This page is for the AChar class which we use to store characteristic throughout the project
///



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AChar
    {
        //this is for the storage of Charateristics

        private int charID;
        private string charName;
        private decimal charCost;
        private decimal charMini;
        private int charAsso;
        private int charClient;
        private int charActive;

        public int CharID { get => charID; set => charID = value; }
        public string CharName { get => charName; set => charName = value; }
        public decimal CharCost { get => charCost; set => charCost = value; }
        public decimal CharMini { get => charMini; set => charMini = value; }
        public int CharAsso { get => charAsso; set => charAsso = value; }
        public int CharClient { get => charClient; set => charClient = value; }
        public int CharActive { get => charActive; set => charActive = value; }
    }
}
