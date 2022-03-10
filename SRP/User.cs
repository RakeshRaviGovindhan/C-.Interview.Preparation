using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class User
    {
        public string Email;
        public string Password;
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }

}
