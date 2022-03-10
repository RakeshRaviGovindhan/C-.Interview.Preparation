using MultiThreading.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Examples
{
    public static class Monitor
    {
        public static void Execute()
        {
            Thread oddThread = new Thread(PrintNumbers.OddNumber);
            Thread evenThread = new Thread(PrintNumbers.EvenNumber);


            //Start even thread.
            evenThread.Start();

            //puase for 10 ms, to make sure even thread has started
            //or else odd thread may start first resulting other sequence.
            Thread.Sleep(100);

            //Start odd thread.
            oddThread.Start();

            oddThread.Join();
            evenThread.Join();
            Console.WriteLine("\nPrinting done!!!");
            Console.ReadKey();
        }
    }
}
