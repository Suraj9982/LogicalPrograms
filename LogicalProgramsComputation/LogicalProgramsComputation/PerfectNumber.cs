using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class PerfectNumber
    {
        public void FindPerfectNumber(int startnumber,int endnumber)
        {
            Console.WriteLine("This is all perfect number within{0} to {1}", startnumber, endnumber);
            for(int i = startnumber; i <= endnumber; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
