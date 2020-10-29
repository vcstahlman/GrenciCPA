﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AFee
    {
        // ID for passing and retrieving
        private int feeID;

        // identification vars
        private string feeName;
        private decimal feeCost;
        private decimal feeMin;
        private int servID;
        private bool active;

        // accessors and mutators for AClient class
        public int FeeID { get => feeID; set => feeID = value; }
        public string FeeName { get => feeName; set => feeName = value; }
        public decimal FeeCost { get => feeCost; set => feeCost = value; }
        public decimal FeeMin { get => feeMin; set => feeMin = value; }
        public int ServID { get => servID; set => servID = value; }
        public bool Active { get => active; set => active = value; }
    }
}
