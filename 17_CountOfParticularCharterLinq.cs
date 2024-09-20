using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    //interview ask
    public class _17_CountOfParticularCharterLinq
    {
        public static void CountOfParticularCharterLinq()
        {
            string name = "Pooja";
            char input = 'o';
            int occuranceCount = name.Count(x => x == input);
            Console.WriteLine($"The character '{input}' appears {occuranceCount} times in the string \"{name}\".");
        }
    } 
}
