using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class Stack
    {
        public static void Execute()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
