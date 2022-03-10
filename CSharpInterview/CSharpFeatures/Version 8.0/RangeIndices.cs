using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures
{
    public static class RangeIndices
    {
        public static void Execute()
        {
            RangeEx();
        }

        
        private static void RangeEx()
        {
            int[] vs = new int[] { 10, 8, 15, 13, 19, 2, 16, 5, 8 };

            ///hat operator ^
            Console.WriteLine(vs[^2]);
            Console.WriteLine(vs[vs.Length - 2]);

            
            Console.WriteLine(Environment.NewLine + vs[^4]);
            Console.WriteLine(vs[vs.Length - 4]);

            Index ind = ^4;
            Console.WriteLine(Environment.NewLine + vs[ind]);

            //Hat and range operators
            Console.WriteLine(Environment.NewLine + string.Join(',', vs[^5..^1]));
            Console.WriteLine(string.Join(',', vs[1..^1]));
            Console.WriteLine(string.Join(',', vs[1..5]));
            Console.WriteLine(string.Join(',', vs[..5]));
            Console.WriteLine(string.Join(',', vs[..]));

        }
    }
}
