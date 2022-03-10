using System;
using System.Collections.Generic;

namespace CSharpInterview.Examples
{
    public static class SortedList
    {
        public static void Execute()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            Console.ReadKey();

        }

    }
}

