using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{

    public class PrintKot : BaseModel
    {
        private int _KOTID;
        private string _TABLENO;
        private string _DESCA;
        private string _MENUCODE;
        private byte _ISBOT;
        private double _QUANTITY;
        private string _REMARKS;
        private int _SNO;
        private string _UNIT;
        private string _MCODE;
        private DateTime _TRNDATE;
        private DateTime _KOTTIME;
        private string _KOT;
        private string _USERNAME;
        private int _PAX;
        private string _ComboItem;

        public int KOTID
        {
            get { return _KOTID; }
            set { _KOTID = value; OnPropertyChanged("KOTID"); }
        }

        public string ComboItem
        {
            get { return _ComboItem; }
            set { _ComboItem = value; OnPropertyChanged("ComboItem"); }
        }

        public int PAX
        {
            get { return _PAX; }
            set { _PAX = value; OnPropertyChanged("PAX"); }
        }

        public string USERNAME
        {
            get { return _USERNAME; }
            set { _USERNAME = value; OnPropertyChanged("USERNAME"); }
        }

        public string KOT
        {
            get { return _KOT; }
            set { _KOT = value; OnPropertyChanged("KOT"); }
        }

        public DateTime KOTTIME
        {
            get { return _KOTTIME; }
            set { _KOTTIME = value; OnPropertyChanged("KOTTIME"); }
        }

        public DateTime TRNDATE
        {
            get { return _TRNDATE; }
            set { _TRNDATE = value; OnPropertyChanged("TRNDATE"); }
        }

        public string MCODE
        {
            get { return _MCODE; }
            set { _MCODE = value; OnPropertyChanged("MCODE"); }
        }

        public string UNIT
        {
            get { return _UNIT; }
            set { _UNIT = value; OnPropertyChanged("UNIT"); }
        }

        public int SNO
        {
            get { return _SNO; }
            set { _SNO = value; OnPropertyChanged("SNO"); }
        }

        public string REMARKS
        {
            get { return _REMARKS; }
            set { _REMARKS = value; OnPropertyChanged("REMARKS"); }
        }

        public double QUANTITY
        {
            get { return _QUANTITY; }
            set { _QUANTITY = value; OnPropertyChanged("QUANTITY"); }
        }

        public byte ISBOT
        {
            get { return _ISBOT; }
            set { _ISBOT = value; OnPropertyChanged("ISBOT"); }
        }

        public string MENUCODE
        {
            get { return _MENUCODE; }
            set { _MENUCODE = value; OnPropertyChanged("MENUCODE"); }
        }

        public string DESCA
        {
            get { return _DESCA; }
            set { _DESCA = value; OnPropertyChanged("DESCA"); }
        }

        public string TABLENO
        {
            get { return _TABLENO; }
            set { _TABLENO = value; OnPropertyChanged("TABLENO"); }
        }
        public int REFSNO { get; set; }
    }
}
