using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class RearrangeArray
    {
        public static int[] RearrangeArrayFun(int[] input)
        {
            var PositiveAndZeros = new List<int>();
            var Negatives = new List<int>();
            foreach(int num in input)
            {
                if (num >= 0)
                {
                    PositiveAndZeros.Add(num);
                }
                else
                {
                    Negatives.Add(num);
                }
            }
            // Combine the two lists and return the result as an array
            PositiveAndZeros.AddRange(Negatives);
           return PositiveAndZeros.ToArray();

        }
    }
}
