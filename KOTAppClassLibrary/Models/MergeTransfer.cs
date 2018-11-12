using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class MergeTransfer
    {
        public string DestinationTableNo { get; set; }
        public List<string> MergingTables { get; set; }

        public MergeTransfer()
        {
            DestinationTableNo = "";
            MergingTables = new List<string>();
        }
    }
}
