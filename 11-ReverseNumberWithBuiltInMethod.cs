using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class ReverseNumberWithBuiltInMethod
    {
        public static long ReverseNumberWithBuiltMethod()
        {
            int number = 123;
            char[] numArray = number.ToString().ToCharArray();
            Array.Reverse(numArray);
            long result = Convert.ToInt64(numArray);
            return result;

        }
        
        
    }
}
