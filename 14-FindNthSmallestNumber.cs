using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class FindNthSmallestNumber
    {
        public static int KthSmallest()
        {
            int[] nums = { 3, 7, 4, 1, 9, 2 };
            int[] sorteddecendingarr = { 1, 2, 3, 4, 7, 9 };
            int k = 3;
            // Perform bubble sort to arrange the elements in ascending order
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int outerloopcondition = nums.Length - 1;
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    int innercondition = nums.Length - i - 1;
                    if (nums[j] > nums[j + 1])
                    {
                        // Swap elements
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(nums[k - 1]);
            return nums[k - 1];
        }
    }
}


