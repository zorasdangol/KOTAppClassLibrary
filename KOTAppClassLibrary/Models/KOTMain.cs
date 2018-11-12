using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class KotMain
    {
        public int ID { get; set; }
        public int KOTID { get; set; }
        public string PHISCALID { get; set; }
        public string REFBILLED { get; set; }
        public string STATUS { get; set; }
        public string BILLED { get; set; }
        public short PAX { get; set; }
        public double ROUNDUP { get; set; }
        public string BILLTOADD { get; set; }
        public byte FLG { get; set; }
        public string BILLTOVAT { get; set; }
        public string BILLTO { get; set; }
        public string MEMID { get; set; }
        public double STAX { get; set; }
        public string DIVISION { get; set; }
        public string DCRATE2 { get; set; }
        public string BILLNO { get; set; }
        public string EDITUSER { get; set; }
        public string TERMINAL { get; set; }
        public string REMARKS { get; set; }
        public byte INDDIS { get; set; }
        public string TRNUSER { get; set; }
        public string WAITER { get; set; }
        public double NETAMNT { get; set; }
        public double VATAMNT { get; set; }
        public double DCRATE { get; set; }
        public double DCAMNT { get; set; }
        public double TOTAMNT { get; set; }
        public string TRNTIME { get; set; }
        public string BSDATE { get; set; }
        public DateTime TRNDATE { get; set; }
        public string TABLENO { get; set; }

        public ObservableCollection<KOTProd> KotProdList { get; set; }
    }
    public class KOTMAINSTATUS
    {
        public int KOTID { get; set; }
        public string TABLENO { get; set; }
        public string STATUS { get; set; } //DELETE,SPLIT,UPDATE,BILLED,ACTIVE,CANCELED,MERGE,KOTFLUSH
        public string REMARKS { get; set; }
        public DateTime EDATE { get; set; }
        public string DIVISION { get; set; }
    }
}
