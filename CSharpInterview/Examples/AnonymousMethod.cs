using System;

namespace CSharpInterview.Examples
{
    public static class AnonymousMethod
    {
        public static void Execute()
        {
            MyClass myClass = new MyClass();
            // Passing Anonymous Method
            myClass.LongRunning(
                delegate (int i)
                {
                    Console.WriteLine(i);
                });
        }
    }
}
