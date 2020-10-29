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

        public int ServID { get => servID; set => servID = value; }
        public string ServName { get => servName; set => servName = value; }
        public string ServSent { get => servSent; set => servSent = value; }
        public bool Active { get => active; set => active = value; }
    }
}
