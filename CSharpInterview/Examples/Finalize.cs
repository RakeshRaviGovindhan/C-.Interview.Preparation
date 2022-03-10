using System;
using System.Diagnostics;

namespace CSharpInterview.Examples
{
    public class Finalize
    {
        public static void Execute()
        {
            FinalizeExample fin = new FinalizeExample();
        }
    }

    public class FinalizeExample
    {
        Stopwatch watch = new Stopwatch();
        public FinalizeExample()
        {
            watch.Start();
        }

        ~FinalizeExample()
        {
            watch.Stop();
            Console.WriteLine("Finalize called");
            Console.ReadKey();
        }
    }

}
