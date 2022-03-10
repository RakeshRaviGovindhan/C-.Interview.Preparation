using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class Queue
    {

        public static void Execute()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
