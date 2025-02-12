using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Signin
    {
            public string Username;
            public string Password;
            public string Role;

            public Signin(string username , string password , string role)
            {
                  Username = username;
                 Password = password;    
                Role = role;
            }
    }   
}
