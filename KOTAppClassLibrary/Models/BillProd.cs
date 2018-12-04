using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class BillProd:BaseModel
    {
        private int _Sno;
        public int Sno
        {
            get { return _Sno; }
            set
            {
                _Sno = value;
                OnPropertyChanged("Sno");
            }
        }

        private string _Code;
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("Code");
            }
        }


        private string _Particular;
        public string Particular
        {
            get { return _Particular; }
            set
            {
                _Particular = value;
                OnPropertyChanged("Particular");
            }
        }

        private string _Unit;
        public string Unit
        {
            get { return _Unit; }
            set
            {
                _Unit = value;
                OnPropertyChanged("Unit");
            }
        }


        private decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set
            {
                _Quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        private decimal _Rate;
        public decimal Rate
        {
            get { return _Rate; }
            set
            {
                _Rate = value;
                OnPropertyChanged("Rate");
            }
        }

        private decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set
            {
                _Amount = value;
                OnPropertyChanged("Amount");
            }
        }
        
    }
}
