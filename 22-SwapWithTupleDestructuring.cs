using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class SwapWithTupleDestructuring
    {
        public static (int,int) SwappingValues()
        {
            int a = 10;
            int b = 20;
            (a, b) = (b, a);
            return (a, b);//return two values using tuples
       
        }
    }
}
