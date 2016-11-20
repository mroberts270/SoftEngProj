using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    class Account
    {
        private string userName;
        private string password;
        private string type;

        public Account(string use, string pass, string typ)
        {
            setUserName(use);
            setPassword(pass);
            setType(typ);
        }

        public void setUserName(string u)
        {
            userName = u;
        }

        public string getUserName()
        {
            return userName;
        }

        public void setPassword(string p)
        {
            password = p;
        }

        public string getPassword()
        {
            return password;
        }

        public void setType(string t)
        {
            type = t;
        }

        public string getType()
        {
            return type;
        }
    }
}
