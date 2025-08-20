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
            //The reason for nums.Length - 1 in the outer loop is because after sorting, the last element is in its correct position, and we don't need to check it again in subsequent passes.
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int outerloopcondition = nums.Length-i - 1;
                for (int j = 0; j < nums.Length -i - 1; j++)

                {
                    int innercondition = nums.Length  - 1;
                    int outerloopinit = i;
                    int innerloopinit = j;
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


