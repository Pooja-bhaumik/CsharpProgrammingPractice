using System;
using System.Collections.Generic;

namespace ProblemSolving
{
    public static class MovingZerosEndwithDuplicateRemoval
    {
        public static int[] MoveZerosAndRemoveDuplicates(int[] arr)
        {
            List<int> seen = new List<int>();
            List<int> resultList = new List<int>();
            int zeroCount = 0;

            // First, process the array to remove duplicates and count zeros
            foreach (int num in arr)
            {
                if (num == 0)
                {
                    zeroCount++;
                }
                else if (!seen.Contains(num))
                {
                    resultList.Add(num);
                    seen.Add(num);

                }
            }

            // Add the counted zeros to the end of the resultList
            for (int i = 0; i < zeroCount; i++)
            {
                resultList.Add(0);
            }

            return resultList.ToArray();

            //IF WE WANT TO Print in this  
            //Console.WriteLine(string.Join(",", resultList));



            //Without moving zero
            //int[] input = { 1, 2, 4, 4, 5, 3 };
            //List<int> numbers = new List<int>();
            //foreach (int number in input)
            //{
            //    if (!numbers.Contains(number))
            //    {
            //        numbers.Add(number);
            //    }
            //}
            //numbers.ToArray();
            //Console.WriteLine(string.Join(",", numbers));
        }
    }
}
