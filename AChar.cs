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
        private double charCost;
        private double charMini;
        private int charAsso;
        private int charClient;

        public int CharID { get => charID; set => charID = value; }
        public string CharName { get => charName; set => charName = value; }
        public double CharCost { get => charCost; set => charCost = value; }
        public double CharMini { get => charMini; set => charMini = value; }
        public int CharAsso { get => charAsso; set => charAsso = value; }
        public int CharClient { get => charClient; set => charClient = value; }
    }
}
