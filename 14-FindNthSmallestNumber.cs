using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class FindNthSmallestNumber
    {
        public static void FindNthMinimumNumber()
        {
            int[] numbers = { 4, 2, 7, 1, 5, 3 };
            int min = int.MaxValue;
            int secondMin = int.MaxValue;
            int thirdMin = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                // Update min, secondMin, and thirdMin
                if (numbers[i] < min)
                {
                    thirdMin = secondMin;  // Previous secondMin becomes thirdMin
                    secondMin = min;       // Previous min becomes secondMin
                    min = numbers[i];      // Update min to the new smallest number
                }
                else if (numbers[i] < secondMin && numbers[i] != min)
                {
                    thirdMin = secondMin;  // Previous secondMin becomes thirdMin
                    secondMin = numbers[i]; // Update secondMin to the new second smallest number
                }
                else if (numbers[i] < thirdMin && numbers[i] != secondMin && numbers[i] != min)
                {
                    thirdMin = numbers[i]; // Update thirdMin to the new third smallest number
                }
            }
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Second Min: {secondMin}");
            Console.WriteLine($"Third Min: {thirdMin}");
        }
    }
}


