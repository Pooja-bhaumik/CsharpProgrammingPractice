using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class NthHighestNumber
    {
        public static void FindNthHighestNumber()
        {
            int[] numbers = { 11,3,10,5,4 };
            int[] assendingarr = { 11, 10, 5, 4, 3 };//bade se chota
            int n = 3;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for(int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine($"Third max num::{numbers[n - 1]}");
            Console.WriteLine($"second max num::{numbers[n - 1-1]}");
            Console.WriteLine($"First max num::{numbers[n - 3]}");
        }
    }
}
