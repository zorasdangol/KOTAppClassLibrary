using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class MenuItem:BaseModel
    {
        public string MCODE { get; set; }
        public string MENUCODE { get; set; }
        public string DESCA { get; set; }
        public string PARENT { get; set; }
        public decimal PTYPE { get; set; }
        public string BASEUNIT { get; set; }
        public double RATE_A { get; set; }
        public string TYPE { get; set; }
        public byte IsBarItem { get; set; }
        public string MGROUP { get; set; }
        public decimal IsUnknown { get; set; }
        public int ItemCount { get; set; }
        public string DisMode { get; set; }
        
        private decimal _QUANTITY;
        public decimal QUANTITY
        {
            get { return _QUANTITY; }
            set
            {
                _QUANTITY = value;
                OnPropertyChanged("QUANTITY");
            }
        }

        private decimal _SetQuantity;
        public decimal SetQuantity
        {
            get { return _SetQuantity; }
            set
            {
                _SetQuantity = value;
                OnPropertyChanged("SetQuantity");
            }
        }

        public string KOTTIME { get; set; }
        public string REMARKS { get; set; }
        public int SNO { get; set; }
        public string KOT { get; set; }
        public bool IsSaved { get; set; }

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
            DisMode = "";

            QUANTITY = 0;
            SetQuantity = 0;
            KOTTIME = "";
            REMARKS = "";
            SNO = 0;
            KOT = "";
            IsSaved = false;
            ItemCount = 0;
        }

        public static KOTProd  MenuItemsToKOTProd(MenuItem item)
        {
            try
            {                
                KOTProd kp = new KOTProd();
                kp.MCODE = item.MCODE;
                kp.ItemDesc = item.DESCA;
                kp.DESCA = item.DESCA;
                kp.UNIT = item.BASEUNIT;
                kp.RATE = (double)item.RATE_A;
                kp.Quantity = (double)item.QUANTITY;
                kp.SNO = item.SNO;
                kp.Remarks = item.REMARKS;
                kp.KOTTIME = item.KOTTIME;
                kp.DisMode = item.DisMode;
                if(item.SNO == 0)
                {
                    kp.KOTTIME = "not set";
                }
                return kp;
            }
            catch { return null; }
        }
    }
}
