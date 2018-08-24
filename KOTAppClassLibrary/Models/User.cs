using System;
using System.Collections.Generic;
using System.Text;

namespace KOTAppClassLibrary.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UniqueID { get; set; }

        public string ip1 { get; set; }
        public string ip2 { get; set; }
        public string ip3 { get; set; }
        public string ip4 { get; set; }
        public string Port { get; set; }

        //public string IPAddress { get; set; }

        public User()
        {
            UserName = "";
            Password = "";
            ip1 = "";
            ip2 = 
            ip3 = "";
            ip4 = "";
            Port = "";
            //IPAddress = "";
            UniqueID = "";
        }
    }
}
