using MultiThreading.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Examples
{
    public static class Join
    {
        //  program can wait for some computation in another thread to complete to use its result later,
        internal static void Execute()
        {
            Thread t = new Thread(PrintNumbers.NaturalNumbersWithDelay);
            t.Start();

            // If we comment this line of code : Main thread will execute first
            t.Join();
            //PrintNumbers.NaturalNumbers();
            Console.WriteLine("Thread completed");
            Console.ReadKey();

        }

    }
}
