using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class Dictionary
    {
        public static void Execute()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");

            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine("Key : " + kvp.Key + ", " + "Value : " + kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
