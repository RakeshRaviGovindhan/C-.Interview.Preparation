using System;

namespace CSharpInterview.Examples
{
    public static class Delegate
    {
        public static void Execute()
        {
            // 1. Normal way to call amethod by delegate
            MyClass myClass = new MyClass();
            //myClass.LongRunning(CallBack);

            /* 2. We can write delegate like inline code or we can say anonymous method
            myClass.LongRunning(
                                delegate (int i)
                                {
                                    Console.WriteLine(i);
                                }
                                );*/

            /* 3. We can call method via delegate with the help of lamba
            myClass.LongRunning((i) => Console.WriteLine(i));*/
        }

        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }

    class MyClass
    {
        public delegate void CallBack(int i);

        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 10_00_000; i++)
            {
                // Do something here
                obj(i);
            }
        }
    }
}
