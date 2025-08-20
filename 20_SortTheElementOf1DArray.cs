

using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class _20_SortTheElementOf1DArray
    {
        //Write the program to sort the elements of 1d array
        //input:  5, 8, 9, 3, 1, 2, 3, 6  
        //output: 1 2 3 3 5 6 8 9

        public static void SortTheElemetOf1DArray()

        {
            int[] input = { 5, 8, 9, 3, 1, 2, 3, 6 };
            for (int i = 0; i < input.Length - 1; i++)
            {

                for (int j = 0; j < input.Length - i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

    }
}
