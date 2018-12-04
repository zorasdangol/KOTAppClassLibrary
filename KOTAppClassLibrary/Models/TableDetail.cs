using System;
using System.Collections.Generic;

using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class TableDetail:BaseModel
    {
        public string TableNo { get; set; }
        public string LayoutName { get; set; }
        public string ImageName { get; set; }

        private String _TableColor;
        public String TableColor
        {
            get { return _TableColor; }
            set
            {
                _TableColor = value;
                OnPropertyChanged("TableColor");
            }
        }

        private bool _IsSelected;
        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                _IsSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        private bool _IsPacked;
        public bool IsPacked
        {
            get { return _IsPacked; }
            set
            {
                _IsPacked = value;
                OnPropertyChanged("IsPacked");
            }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        private double _GrossAmount;
        public double GrossAmount
        {
            get { return _GrossAmount; }
            set
            {
                _GrossAmount = value;
                OnPropertyChanged("GrossAmount");
            }
        }

        private double _DisAmount;
        public double DisAmount
        {
            get { return _DisAmount; }
            set
            {
                _DisAmount = value;
                OnPropertyChanged("DisAmount");
            }
        }

        public double ServiceCharge { get; set; }

        private double _VATAmount;
        public double VATAmount
        {
            get { return _VATAmount; }
            set
            {
                _VATAmount = value;
                OnPropertyChanged("VATAmount");
            }
        }

        private double _NetAmount;
        public double NetAmount
        {
            get { return _NetAmount; }
            set
            {
                _NetAmount = value;
                OnPropertyChanged("NetAmount");
            }
        }

        public TableDetail()
        {
            TableNo = "";
            GrossAmount = 0;
            DisAmount = 0;
            ServiceCharge = 0;
        }
    }
}
