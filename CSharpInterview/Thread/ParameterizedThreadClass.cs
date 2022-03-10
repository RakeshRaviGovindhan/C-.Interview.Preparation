using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInterview
{
    public static class ParameterizedThreadClass
    {
        private static int count = 0;

        public static void Execute()
        {
            ThreadExample threadExample = new ThreadExample();
            Thread t = new Thread(() => threadExample.PrintValue(count));
            t.Start();

            Thread t2 = new Thread(() =>
            {
                while (count++ < 1000)
                {
                    threadExample.PrintValue(count);
                }
            });
            t.Start();

        }
    }


    public class ThreadExample
    { 

        public void PrintValue(int count)
        {
            Console.WriteLine($"{count} Printed");
        }
    }
}
