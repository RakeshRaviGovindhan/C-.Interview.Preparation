using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures
{
    public static class LocalFunction
    {
        public static void Execute()
        {
            int first = 12;
            int second = 92;
            Add();

            void Add()
            {
                Console.WriteLine($"Sum of the value : {first + second}");
                Subtract(second, first);
                Multiplication(second, first);
            }

            void Subtract(int a, int b)
            {
                Console.WriteLine($"Difference of the values: {second - first}");
            }

            static void Multiplication(int a, int b)
            {
                Console.WriteLine($"Multiplication of the value : { a * b}");
            }
        }
    }
}
