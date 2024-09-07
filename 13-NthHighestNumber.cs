using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class NthHighestNumber
    {
        public static void FindNthHighestNumber()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int max = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = numbers[i];
                   
                }
            }
            Console.WriteLine($"first max:{max},second max:{secondMax},third max:{thirdMax}");
        }
    }
}
