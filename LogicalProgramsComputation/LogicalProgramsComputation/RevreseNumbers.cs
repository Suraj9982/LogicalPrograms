using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class RevreseNumbers
    {
        public void ReversetheNumber(int num)
        {
            int reverse = 0, rem;
            while (num != 0)
            {
                rem = num % 10;
                reverse = (reverse * 10) + rem;
                num = num / 10;
            }
            Console.WriteLine("reverse number = {0}", reverse);
        }
    }
}
