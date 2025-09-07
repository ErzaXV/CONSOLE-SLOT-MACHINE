using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SLOT_MACHINE
{
    internal struct USER_DATA
    {
        private string Username { get; set; }
        private string Password { get; set; }
        private int cash;
        public int Publiccash
        {
            get { return cash; }
            set { cash = value; } 
        }

        public USER_DATA(String username,String password,int publiccash)
        {
            Username = username;
            Password = password;
            Publiccash = publiccash;
        }

    }
}
