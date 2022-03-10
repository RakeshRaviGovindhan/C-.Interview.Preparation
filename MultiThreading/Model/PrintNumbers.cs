using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading.Model
{
    public static class PrintNumbers
    {
        // upto the limit numbers will be printed.
        const int numberLimit = 10;

        static object monitor = new object();

        public static void EvenNumber()
        {
            try
            {
                //hold lock
                Monitor.Enter(monitor);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    //Complete the task ( printing even number on console)
                    Console.Write($"Even {i}, ");
                    //Notify other thread- here odd thread
                    //that I'm done, you do your job
                    Monitor.Pulse(monitor);
                    //I will wait here till odd thread notify me
                    // Monitor.Wait(monitor);

                    bool isLast = i == numberLimit;
                    if (!isLast)
                        Monitor.Wait(monitor);
                }
            }
            finally
            {
                Monitor.Exit(monitor);//release the lock
            }
        }

        // Function to print even numbers
        public static void OddNumber()
        {
            try
            {
                //hold lock as console is shared between threads.
                Monitor.Enter(monitor);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    //Complete the task ( printing odd number on console)
                    Console.Write($"Odd {i}, ");
                    //Notify other thread that is to eventhread
                    //that I'm done you do your job
                    Monitor.Pulse(monitor);

                    //I will wait here till even thread notify me
                    // Monitor.Wait(monitor);

                    // without this logic application will wait forever
                    bool isLast = i == numberLimit - 1;
                    if (!isLast)
                        Monitor.Wait(monitor); //I will wait here till even thread notify me
                }
            }
            finally
            {
                //Release lock
                Monitor.Exit(monitor);
            }
        }

        public static void NaturalNumbers()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void NaturalNumbersWithDelay()
        {
            Console.WriteLine("Starting...");
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.WriteLine(i);
            }
        }
    }
}
