using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class ThreadJoin
    {
        static Stopwatch stopwatch;

        public static void Execute()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread t1 = new Thread(Print);
            Thread t2 = new Thread(Print);
            t1.Name = "First Thread";
            t2.Name = "Second Thread";
            Thread.CurrentThread.Name = "Main Thread";
            t1.Start();
            
            t2.Start();
            //t2.Join();

            Thread.Sleep(10000);
            Console.WriteLine(Thread.CurrentThread.Name + " Execution completed" + " Time taken : " + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }

        public static void Print()
        {
            if(Thread.CurrentThread.Name == "First Thread")
            {
                Thread.Sleep(5000);
            }
            else if (Thread.CurrentThread.Name == "Second Thread")
            {
                Thread.Sleep(7000);
            }
            else if (Thread.CurrentThread.Name == "Main Thread")
            {
                Thread.Sleep(10000);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " Execution completed" + " Time taken : " + stopwatch.ElapsedMilliseconds);
        }
      

    }
}
