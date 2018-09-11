using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class KOTListTransfer
    {
        public string TABLENO { get; set; }
        public string TRNUSER { get; set; }
        public List<KOTProd> KOTProdList { get; set; }
        public string PAX { get; set; }
    }
}
