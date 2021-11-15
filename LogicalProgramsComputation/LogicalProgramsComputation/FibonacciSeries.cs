using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class FibonacciSeries
    {
        public void FindFibonacci(int length)
        {
            int num1 = 0, num2 = 1, num3, i;
            Console.WriteLine("{0}\n{1}", num1, num2);
            for (i = 2; i < length; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine("{0}", num3);
                num1 = num2;
                num2 = num3;
            }
        }
    }
}
