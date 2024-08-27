using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    public class ReverseStringWithBuiltInMethod
    {
        public static string ReverseStringWithBuilt()
        {
            //with out linq in this we do not need to use System.Linq
            string input = "Pooja";
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string reversed = new string(charArr);
            //another apporach using system.linq
            string reveredLinq = new string(input.Reverse().ToArray());

            return reversed;

           
        }
       

    }
}
