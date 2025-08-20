using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public static class ReverseNumberWithoutBuiltIn
    {
        public static long ReverseNumberWithoutBuiltInMethod()
        {
            int number = 123;
            long reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10; // Get the last digit
                reversedNumber = reversedNumber * 10 + digit; // Append it to the reversed number
                number /= 10; // Remove the last digit from the original number
            }
            return reversedNumber;
        }
    }
}
