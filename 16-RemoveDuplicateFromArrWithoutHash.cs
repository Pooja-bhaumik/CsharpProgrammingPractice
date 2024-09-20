using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class _16_RemoveDuplicateFromArrWithoutHash
    {
        public static void RemoveDuplicateFromArr()
        {
            int[] input = { 1, 2, 3, 1, 3, 5, 2 };
            int[] result = new int[input.Length];
            int resultIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        isDuplicate = true;
                        break;
                    }

                }
                if (!isDuplicate)
                {
                    result[resultIndex] = input[i];
                    resultIndex++;
                }
            }
            Array.Resize(ref result, resultIndex);
            Console.WriteLine($"Unique::::{string.Join(", ", result)}");
            Console.ReadLine();
        }

    }
}
