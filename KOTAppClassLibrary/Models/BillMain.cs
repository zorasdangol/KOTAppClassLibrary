using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class BillMain:BaseModel
    {
        public string BillNo { get; set; }
        public string Date { get; set; }
        public string BsDate { get; set; }
        public string VatNo { get; set; }

        private decimal _GrossTotal;
        public decimal GrossTotal
        {
            get { return _GrossTotal; }
            set
            {
                _GrossTotal = value;
                OnPropertyChanged("GrossTotal");
            }
        }


        private decimal _Discount;
        public decimal Discount
        {
            get { return _Discount; }
            set
            {
                _Discount = value;
                OnPropertyChanged("Discount");
            }
        }
        
        private decimal _SubTotal;
        public decimal SubTotal
        {
            get { return _SubTotal; }
            set
            {
                _SubTotal = value;
                OnPropertyChanged("SubTotal");
            }
        }


        private decimal _Taxable;
        public decimal Taxable
        {
            get { return _Taxable; }
            set
            {
                _Taxable = value;
                OnPropertyChanged("Taxable");
            }
        }

        private decimal _NonTaxable;
        public decimal NonTaxable
        {
            get { return _NonTaxable; }
            set
            {
                _NonTaxable = value;
                OnPropertyChanged("NonTaxable");
            }
        }


        private decimal _ServiceCharge;
        public decimal ServiceCharge
        {
            get { return _ServiceCharge; }
            set
            {
                _ServiceCharge = value;
                OnPropertyChanged("ServiceCharge");
            }
        }

        private decimal _Vat;
        public decimal Vat
        {
            get { return _Vat; }
            set
            {
                _Vat = value;
                OnPropertyChanged("Vat");
            }
        }

        private decimal _Net;
        public decimal Net
        {
            get { return _Net; }
            set
            {
                _Net = value;
                OnPropertyChanged("Net");
            }
        }
        
        private List<BillProd> _items;
        public List<BillProd> items
        {
            get { return _items; }
            set
            {             
                _items = value;
                OnPropertyChanged("items");
            }
        }
    }
}
