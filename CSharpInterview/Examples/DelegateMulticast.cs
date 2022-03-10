using System;

namespace CSharpInterview.Examples
{

    public static class DelegateMulticast
    {
        public delegate void MultiCastDelegate(int a, int b);
        public static void Execute()
        {
            MultiCastDelegate del = new MultiCastDelegate(Add);
            del += Substract;
            del += Multiply;
            del += Divide;
            del(40, 10);
            Console.WriteLine();

            del -= Add;
            del -= Divide;
            del(50, 10);
            Console.ReadLine();
        }

        private static void Add(int x, int y)
        {
            Console.WriteLine("Sum is:" + (x + y));
        }
        private static void Substract(int x, int y)
        {
            Console.WriteLine("Difference is:" + (x - y));
        }
        private static void Multiply(int x, int y)
        {
            Console.WriteLine("Product is:" + (x * y));
        }
        private static void Divide(int x, int y)
        {
            Console.WriteLine("Quotient is:" + (x / y));
        }
    }
}
