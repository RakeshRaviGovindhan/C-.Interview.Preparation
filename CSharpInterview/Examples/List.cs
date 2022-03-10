using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class List
    {
        public static void Execute()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            lst.Add(300);
            lst.Add(400);

            foreach (int i in lst)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();
        }
    }
}
