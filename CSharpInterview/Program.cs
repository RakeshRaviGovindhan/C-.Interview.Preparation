global using System.Collections.Generic;

using CSharpInterview.CSharpFeatures;
using CSharpInterview.CSharpFeatures.Version_9._0;
using CSharpInterview.Examples;
using System;
using System.Linq;


namespace CSharpInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region yield

            /****************************************************************************
               yield keyword helps us to do custom stateful iterations over a collection. 
                1. Custom iteration 
                2. Stateful iteration 
             ****************************************************************************/
            //Examples.Yield.PrintResult();

            #endregion

            #region Delegate

            //Examples.Delegate.Execute();

            #endregion

            #region Concurrency

            //Examples.Concurrency.Execute(); 

            #endregion

            #region Parallel

            //Examples.Parallel_TPL.Execute(); 

            #endregion

            #region Lamda

            //Examples.Lamda.Execute();
            //Examples.Lamda.Execute1();

            #endregion

            #region MultiCastDelegate

            //Examples.DelegateMulticast.Execute();

            #endregion

            #region Finalize

            //Examples.Finalize.Execute(); 

            #endregion

            #region Dispose

            //Examples.Dispose.Execute(); 

            #endregion

            #region Queue

            //Examples.Queue.Execute(); 

            #endregion

            #region Stack

            //Examples.Stack.Execute();

            #endregion

            #region SortedList

            //Examples.SortedList.Execute();

            #endregion

            #region Dictionary

            //Examples.Dictionary.Execute();

            #endregion

            #region List

            //Examples.List.Execute();

            #endregion

            #region CopyConstructor

            //Examples.CopyConstructor.Execute();

            #endregion

            #region Indexer

            //Examples.Indexer.Execute();

            #endregion

            #region Sealed

            //Examples.Sealed.Execute();

            #endregion

            #region ThreadJoin

            //Examples.ThreadJoin.Execute();

            #endregion

            #region Linq.GroupBy

            //Examples.LinqGroupBy.
            #endregion

            #region Multiple Inheritance

            //MultipleInheritance.Execute();

            #endregion

            #region PartialClass

            //PartialClass.Execute();

            #endregion

            #region NullCoalescingOperators  C# 8.0

            //NullCoalescingOperators.EvaluateType1();
            //NullCoalescingOperators.EvaluateType2();
            //NullCoalescingOperators.EvaluateType3();

            #endregion

            #region Interface C# 8.0

            //InterfaceFeatures.Show();

            #endregion

            #region LocalFunction C# 8.0

            //LocalFunction.Execute();

            #endregion

            #region Range & Indices C# 8.0

            //RangeIndices.Execute();

            #endregion

            #region Switch  C# 8.0

            //Switch.Execute();

            #endregion

            #region Records C# 9.0

            //Records.Execute();

            #endregion

            #region With Expression C# 9.0

            //WithExpression.Execute();

            #endregion

            #region Pattern Matching C# 9.0

            //PatternMatching.Execute();

            #endregion

            #region Parameterized Thread

            ParameterizedThreadClass.Execute();

            #endregion

            Console.ReadKey();
        }


        //var val = solution("Rakesh");

        //int[] arr = { 6, 3, 1, 2, 5, 4 };
        //int[] arr = { 8,5,3,1};
        //int[] arr = { 3, 100, 1, 97 };
        //var val = solution(arr);
        static int solution(int[] prices)
        {
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i == 0 ? 1 : i; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > profit)
                    {
                        profit = prices[j] - prices[i];
                    }
                }
            }
            Console.WriteLine("Highest profit is {0}", profit);
            return profit;
        }

        //static int solution(string s)
        //{
        //    int count = 0;
        //    int value = 0;

        //    if (0 <= s.Length && s.Length <= Math.Pow(10, 4))
        //    {
        //        char[] vowelsArr = { 'a', 'e', 'i', 'o', 'u' };
        //        char[] convCharArr = s.ToLower().ToCharArray();
        //        for (int i = 0; i < s.Length; i++)
        //        {
        //            for (int j = 0; j < vowelsArr.Length; j++)
        //            {
        //                if (convCharArr[i] == vowelsArr[j])
        //                {
        //                    value = 1;
        //                }
        //            }
        //            count = count + (value == 1 ? 1 : 2);
        //            value = 0;
        //        }
        //        Console.WriteLine("Count  of value will be {0}", count);
        //    }
        //    return count;
        //}




    }
}
