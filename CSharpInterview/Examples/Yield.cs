using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class Yield
    {
        public static List<int> intList => new List<int> { 12, 45, 11, 45, 25, 14, 61, 32, 31, 22, 10, 2, 41, 21 };

        public static void PrintResult()
        {
            Console.WriteLine("Filter the values greater than 30");
            Console.WriteLine("*********************************");
            foreach (var item in Filter())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Running Total");
            Console.WriteLine("*************");
            foreach (var item in RunningTotal())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static IEnumerable<int> Filter()
        {
            //Custom Iteration
            foreach (int item in intList)
            {
                if (item > 30)
                {
                    yield return item;
                }
            }
        }

        static IEnumerable<int> RunningTotal()
        {
            //Stateful Iteration
            int runningTotal = 0;

            foreach (int item in intList)
            {
                runningTotal += item;
                yield return (runningTotal);
            }
        }

    }
}
