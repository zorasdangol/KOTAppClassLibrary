using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class SplitTransfer
    {
        public string TableNo { get; set; }
        public List<KOTProd> transferData { get; set; }
        public string TRNUSER { get; set; }

        public SplitTransfer()
        {
            TableNo = "";
            transferData = new List<KOTProd>();
            TRNUSER = "";
        }
    }
}
