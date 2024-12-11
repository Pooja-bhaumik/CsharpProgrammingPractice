using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
  

    public static class _21_SingleLoopSequence
    {
        // Program to print a sequence of [012345678987654321] using a single loop (for interview)
        public static void SingleLoopSequence()
        {
            string seq = "";

            for (int i = 0; i < 18; i++)//if you want to include 0 after the series then change  i<=18
            {
                if (i <= 9)

                {
                    seq += i; // Append numbers from 0 to 9
                }
                else
                {
                    seq += (18 - i); // Append numbers from 8 to 1

                }
                // Add a comma only if it's not the last number
                if (i < 18)
                {
                    seq += ",";
                }
            }

            Console.WriteLine(seq);
            Console.ReadLine();
        }
    }

}

