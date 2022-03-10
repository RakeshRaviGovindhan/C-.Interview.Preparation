using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public partial class UserName
    {
        private string _firstName;
        private string _lastName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }

    public partial class UserName
    {
        public void FullName()
        {
            Console.WriteLine("Full Name:" + FirstName + " " + LastName);
        }
    }

    public static class PartialClass
    {
        public static void Execute()
        {
            var partial = new UserName();
            partial.FirstName = "Farhan";
            partial.LastName = "Ahmed";
            partial.FullName();
            Console.ReadLine();
        }
    }

}
