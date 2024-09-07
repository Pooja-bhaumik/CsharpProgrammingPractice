using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    public static class RemoveDuplicateUsingLinq
    {
        public static void RemoveDuplicateUsingLinqMethod()
        {
            int[] numbers = { 1, 2, 2, 3, 44 };
            int[] uniqueArr = numbers.Distinct().ToArray();
            Console.WriteLine(uniqueArr);

        }


    }
}
