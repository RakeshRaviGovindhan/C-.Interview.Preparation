using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class Sealed
    {
        public static void Execute()
        {
        
        }

    }

    sealed class Colors
    {

    }

    //You will get Error CS0509  'Car': cannot derive from sealed type
    //class Car : Colors
    //{

    //}
}
