using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.Examples
{
    public static class MultipleInheritance
    {
        internal static void Execute()
        {
            AB ab = new AB();
            ab.MethodA();
            ab.MethodB();
            Console.ReadKey();
        }
    }

    // Multiple inheritance acheived with the help of Interfaces
    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void MethodA()
        {
            a.MethodA();
        }

        public void MethodB()
        {
            b.MethodB();
        }
    }

    interface IA
    {
        void MethodA();
    }
    interface IB
    {
        void MethodB();
    }

    public class A : IA
    {
        public void MethodA()
        {
            Console.WriteLine("MethodA() Execued.");
        }
    }

    public class B : IB
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB() Execued.");
        }
    }

    
}
