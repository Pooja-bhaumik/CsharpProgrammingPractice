using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class SwapWithoutTemp
    {
        public static (int,int)  SwapTwoNumberWithoutTemp(int a, int b)
        {
            //int a = 10;
            //int b = 3;
            a = a + b;//13
            b = a - b;//10
            a = a - b;////3
            return (a, b);
            //Console.WriteLine($"a:::{a} and b:::::{b}");

        }
    }
}
