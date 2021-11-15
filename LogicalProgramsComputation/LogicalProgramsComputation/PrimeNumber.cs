using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class PrimeNumber
    {
        public void FindPrimeNumber(int startnum,int endnum)
        {
            int flag = 0;
            Console.WriteLine("all prime numbers within {0} to {1}", startnum, endnum);
            for(int i = startnum; i < endnum; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;
                for(int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
