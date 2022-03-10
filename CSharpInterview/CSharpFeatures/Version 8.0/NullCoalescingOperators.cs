using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures
{
    internal  static class NullCoalescingOperators
    {
        static string A = null;
        static string B = "hello I am B";
        static string C = null;
        static string D = "Hello I am D";
        static string E = null;

        public  static void EvaluateType1()
        {
            Console.WriteLine("\t ??");
            Console.WriteLine("---------------------");
            Console.WriteLine("A ?? B = {0}", A ?? B);
            Console.WriteLine("A ?? C ?? D ?? B = {0}", A ?? C ?? D ?? B);
            Console.WriteLine("A ?? C ?? E ?? B = {0} \n", A ?? C ?? E ?? B);
        }

        public static void EvaluateType2()
        {
            string F = null;
            string G = null;
            string H = "Hello I am H";
            string I = null;
            string J = null;
            F ??= H;
            G ??= I ??= J ??= H;


            Console.WriteLine("\t ??=");
            Console.WriteLine("---------------------");
            Console.WriteLine("F ??= H = {0}", F);
            Console.WriteLine("G ??= I ??= J ??= H = {0}", G);
            Console.WriteLine($"I = {I}\n");
            
        }

        public static void EvaluateType3()
        {
            List<int> list = null;
            list ??= new List<int> { 5, 6 };
            int? a = null;
            list.Add(a ??= 8);
            Console.WriteLine("list.Add(a ??= 8)");
            Console.WriteLine("---------------------");
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            Console.Write(string.Join(',',list));
        }


    }
}
