using System;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class Concurrency
    {
        public static void Execute()
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        private static async void Method1()
        {
            try
            {
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();
                Console.WriteLine("Execution started - Method 1");
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        Console.WriteLine("Method 1 : {0}", i);
                    }
                });
                watch.Stop();
                Console.WriteLine("Execution Completed - Method 1 [Execution Time : " + watch.ElapsedMilliseconds + "]");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static async void Method2()
        {
            try
            {
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();
                Console.WriteLine("Execution started - Method 2");
                await Task.Run(() =>
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        Console.WriteLine("Method 2 : {0}", i);
                    }
                });
                watch.Stop();
                Console.WriteLine("Execution Completed - Method 2 [Execution Time : " + watch.ElapsedMilliseconds + "]");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }


}
