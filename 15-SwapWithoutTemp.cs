using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class SwapWithoutTemp
    {
        public static void  SwapTwoNumberWithoutTemp()
        {
            int a = 10;
            int b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a:::{a} and b:::::{b}");

        }
    }
}
