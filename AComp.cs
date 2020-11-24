﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrenciCPA
{
    class AComp
    {
        private int component_ID;
        private int serv_ID;
        private string serv_Sentence;
        private string serv_Name;
        private int char_ID;
        private string char_Name;

        private decimal char_cost;
        private decimal char_multi;

        private decimal total;

        private int sortInt;
        private int row;

        public AComp()
        {
            sortInt = 0;
            row = -1;
        }

        public int Component_ID { get => component_ID; set => component_ID = value; }
        public int Serv_ID { get => serv_ID; set => serv_ID = value; }
        public string Serv_Name { get => serv_Name; set => serv_Name = value; }
        public int Char_ID { get => char_ID; set => char_ID = value; }
        public string Char_Name { get => char_Name; set => char_Name = value; }
        public decimal Char_cost { get => char_cost; set => char_cost = value; }
        public decimal Char_multi { get => char_multi; set => char_multi = value; }
        public decimal Total { get => total; set => total = value; }
        public int SortInt { get => sortInt; set => sortInt = value; }
        public int Row { get => row; set => row = value; }
        public string Serv_Sentence { get => serv_Sentence; set => serv_Sentence = value; }
    }
}
