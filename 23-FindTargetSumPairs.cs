using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    //get all the pairs whose sum will be 18
    public static class FindTargetSumPairs
    {
        public static List<Tuple<int,int>> GetTragetSumPairs()
        {
            int[] arr = { 10, 1, 8, -2, 5, 12, 15, 2, 3 };
            int target = 18;
            List<Tuple<int,int>> pairs = new List<Tuple<int, int>>();
            //int sNo = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        //sNo++;
                        //Console.WriteLine($"Pairs are {sNo}- ({arr[i]},{arr[j]})");
                        pairs.Add(new Tuple<int, int>(arr[i], arr[j]));
                      
                    }
                }
            }
            return pairs;
            //Console.ReadLine();
        }
    }
}
