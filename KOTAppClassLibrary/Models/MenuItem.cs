using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class MenuItem
    {
        public string MCODE { get; set; }
        public string MENUCODE { get; set; }
        public string DESCA { get; set; }
        public string PARENT { get; set; }
        public decimal PTYPE { get; set; }
        public string BASEUNIT { get; set; }
        public decimal RATE_A { get; set; }
        public string TYPE { get; set; }
        public decimal IsBarItem { get; set; }
        public string MGROUP { get; set; }
        public decimal IsUnknown { get; set; }

        public MenuItem()
        {
            MCODE = "";
            MENUCODE = "";
            DESCA = "";
            PARENT = "";
            PTYPE = 0;
            BASEUNIT = "";
            RATE_A = 0;
            TYPE = "";
            IsBarItem = 0;
            MGROUP = "";
            IsUnknown = 0;
        }
    }
}
