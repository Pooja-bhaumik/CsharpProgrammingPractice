using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class ParentChildExecution
    {
        public int ParentValue = 10;
        public ParentChildExecution()
        {
            Console.WriteLine("Parent Constructor :" + ParentValue);
        }
    }
    public class Child : ParentChildExecution
    {
        public int ChildValue = 20;
        public Child()
        {
            Console.WriteLine("Child Constructor :" + ChildValue);
        }

    }
}
