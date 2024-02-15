using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if ((string.IsNullOrEmpty(userName)) || string.IsNullOrEmpty(password))
            {
                msg = "User name and password required";
            }
            else
            {
                if ((userName == "admin") && (password == "admin@1416"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Fail";
                }
            }
            return msg;
        }
    }
}
