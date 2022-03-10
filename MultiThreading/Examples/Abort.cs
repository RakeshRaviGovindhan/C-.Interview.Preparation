using MultiThreading.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Examples
{
    public static class Abort
    {
        internal static void Execute()
        {
            Console.WriteLine("Starting program...");
            Thread t = new Thread(PrintNumbers.NaturalNumbersWithDelay);
            t.Start();
            Thread.Sleep(TimeSpan.FromSeconds(6));

            /*  When the main program and a separate number-printing thread run, we wait for 6 seconds
                and then call a t.Abort method on a thread. This injects a ThreadAbortException method
                into a thread causing it to terminate. It is very dangerous, generally because this exception
                can happen at any point and may totally destroy the application.*/
            t.Abort(); // Exception

            Console.WriteLine("A thread has been aborted");
            Thread t2 = new Thread(PrintNumbers.NaturalNumbers);
            t2.Start();
            //t.Abort();
            PrintNumbers.NaturalNumbers();
            Console.ReadKey();

        }
    }
}
