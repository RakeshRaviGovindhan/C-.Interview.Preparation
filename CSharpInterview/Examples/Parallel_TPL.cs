using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class Parallel_TPL
    {
        public static void Execute()
        {
            var cts = new CancellationTokenSource(1000);
            var token = cts.Token;
            var t1 = Task.Factory.StartNew(Method1,token);
            //var t2 = Task.Factory.StartNew(Method2, token);
            t1.ContinueWith(t =>
            {
                Console.ReadKey();
                Console.WriteLine("Do you want to cancel the token?");
                cts.Cancel();
                Console.WriteLine("All tasks completed.");
            });
           

            Console.WriteLine("All tasks completed.");
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
                    for (int i = 0; i < 10000; i++)
                    {
                        Task.Delay(500);
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
                    for (int i = 0; i < 10000; i++)
                    {
                        Task.Delay(500);
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
