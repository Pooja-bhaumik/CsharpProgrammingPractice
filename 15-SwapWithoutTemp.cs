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
            a = a + b;//13
            b = a - b;//10
            a = a - b;////3
            Console.WriteLine($"a:::{a} and b:::::{b}");

        }
    }
}
