﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class KOTProd:BaseModel
    {
        public string GROUPID { get; set; }
        public int ID { get; set; }
        public byte TAKEAWAY { get; set; }
        public string RECEIPES { get; set; }
        public int KOTID { get; set; }
        public int REFSNO { get; set; }
        public string PHISCALID { get; set; }
        public string BILLED { get; set; }
        public int ComboItemQty { get; set; }
        public string ComboItem { get; set; }
        public byte ISBOT { get; set; }
        public string Remarks { get; set; }
        public string DispatchUser { get; set; }
        public DateTime? DispatchTime { get; set; }
        public byte KitchenDispatch { get; set; }
        public string KOTTIME { get; set; }
        //public double NAMNT { get; set; }
        public double SERVICETAX { get; set; }
        public string DIVISION { get; set; }
        public string ItemDesc { get; set; }
        public int SNO { get; set; }
        public string KOT { get; set; }
        public string WAREHOUSE { get; set; }
        public string ALTUNIT { get; set; }
        public string IDIS { get; set; }
        public double REALRATE { get; set; }
        public double VAT { get; set; }
        //public double DISCOUNT { get; set; }
        //public double AMOUNT { get; set; }
        public double RATE { get; set; }
        public double AltQty { get; set; }
        public double RealQty { get; set; }
        //public double Quantity { get; set; }
        public string UNIT { get; set; }
        public string MCODE { get; set; }
        public DateTime? TRNDATE { get; set; }
        public string TABLENO { get; set; }
        public string PAX { get; set; }
        public string WAITERNAME { get; set; }

        public string DESCA { get; set; }

        public string DisMode { get; set; }
        
        private double _Quantity;
        public double Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        private double _DecQuantity;
        public double DecQuantity
        {
            get { return _DecQuantity; }
            set
            {
                _DecQuantity = value;
                OnPropertyChanged("DecQuantity");
            }
        }

        private int _OrderSNO;
        public int OrderSNO
        {
            get { return _OrderSNO; }
            set
            {
                _OrderSNO = value;
                OnPropertyChanged("OrderSNO");
            }
        }

        private double _DISCOUNT;
        public double DISCOUNT
        {
            get { return _DISCOUNT; }
            set
            {
                _DISCOUNT = value;
                OnPropertyChanged("DISCOUNT");
            }
        }

        private double _AMOUNT;
        public double AMOUNT
        {
            get { return _AMOUNT; }
            set
            {
                _AMOUNT = value;
                OnPropertyChanged("AMOUNT");
            }
        }

        private double _NAMNT;
        public double NAMNT
        {
            get { return _NAMNT; }
            set
            {
                _NAMNT = value;
                OnPropertyChanged("NAMNT");
            }
        }

        private bool _IsVisible;
        public bool IsVisible
        {
            get { return _IsVisible; }
            set
            {
                _IsVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }

        public KOTProd()
        {
            this.MCODE = "";
            this.DESCA = "";
            this.ISBOT = 0;
            SNO = 0;
            Quantity = 0;
            PAX = "0";
            ItemDesc = "";
            TRNDATE = DateTime.Today.Date;
            KOTTIME = "";
            KOTID = 0;
            UNIT = "";
            RealQty = 0;
            REALRATE = 0;
            RATE = 0;
            AMOUNT = 0;
            NAMNT = 0;
            DISCOUNT = 0;
            DisMode = "";
            OrderSNO = 0;
            DecQuantity = 0;
            TABLENO = "";
            OrderSNO = 0;
            DispatchTime = null;
            Remarks = "";
            KOT = "0";
            IsVisible = false;
        }

        public KOTProd(KOTProd KOT)
        {
            this.MCODE = KOT.MCODE;
            this.DESCA = KOT.DESCA;
            this.ISBOT = KOT.ISBOT;
            SNO = KOT.SNO;
            Quantity = KOT.Quantity;
            PAX = KOT.PAX;
            ItemDesc = KOT.ItemDesc;
            TRNDATE = KOT.TRNDATE;
            KOTTIME = KOT.KOTTIME;
            KOTID = KOT.KOTID;
            UNIT = KOT.UNIT;
            RealQty = KOT.RealQty;
            REALRATE = KOT.REALRATE;
            RATE = KOT.RATE;
            AMOUNT = KOT.AMOUNT;
            NAMNT = KOT.NAMNT;
            DISCOUNT = KOT.DISCOUNT;
            DisMode = KOT.DisMode;
            OrderSNO = KOT.OrderSNO;
            DecQuantity = 0;
            TABLENO = KOT.TABLENO;
            Remarks = KOT.Remarks;
            IsVisible = KOT.IsVisible;

        }
                
    }
}
