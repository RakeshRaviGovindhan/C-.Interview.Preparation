using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample.LinqDemos
{
    public static class LinqDemo
    {
        static string[] list = new string[] { "Rakesh", "Prajeen", "Praveen", "Aswin", "sunil", "Vipin", "Sini" };
        

        public static void Execute()
        {
            var result = from name in list
                         where name.Length > 4
                         select name;
            
            //var result = list.Where(x => x.Length > 4).ToList();
            Console.WriteLine(string.Join(',', result));
            
        }
    }


}
