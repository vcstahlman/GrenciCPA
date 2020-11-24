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
