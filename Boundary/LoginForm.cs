using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boundary
{
    class LoginForm
    {
        public string userName;
        public string password;

        public string getUserName()
        {
            return userName;
        }

        public void setUserName(string uName)
        {
            userName = uName;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string pword)
        {
            password = pword;
        }

       private void enter()
        {

        }

        private string openError()
        {
            return "Invalid Username/Password please try again.";
        }
    }
}
