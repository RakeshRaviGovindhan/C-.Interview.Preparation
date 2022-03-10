using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpInterview.Examples
{
    public static class Lamda
    {
        public static void Execute()
        {
            MyClass myClass = new MyClass();
            // Instead of calling CallBack(int i); we can write like this
            myClass.LongRunning((i) => Console.WriteLine(i));
        }

        public static void Execute1()
        {
            List<int> intList = new List<int> { 2, 5, 12, 3, 41, 21, 4, 11, 32, 33, 8, 2 };
            var AvoidFirstThreeEvenNumbers = intList.Where(x => x % 2 == 0).Skip(3);
            foreach (var item in AvoidFirstThreeEvenNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }

}
