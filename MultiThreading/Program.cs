using MultiThreading.Examples;
using MultiThreading.Model;
using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Example for monitor{ Enter, Exit, Wait, Pulse} and Thread.Join
            //Monitor_Example.Execute();

            // 2. program can wait for some computation in another thread to complete to use its result later
            //Join.Execute();

            // 3. how to abort another thread's execution
            Abort.Execute();
        }
    }
}
