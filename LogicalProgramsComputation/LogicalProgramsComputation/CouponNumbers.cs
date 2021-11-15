using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class CouponNumbers
    {
        public void Calculation(int Num)
        {
            int[] array = new int[Num];
            for (int i = 0; i < Num; i++)
            {
                Random random = new Random();
                int Random_generate = random.Next(999, 10000);
                if (i == 0)
                {
                    array[i] = Random_generate;
                }
                else
                {
                    int j = 0;
                    int check = 0;
                    while (j < i)
                    {
                        if (array[j] == Random_generate)
                            check = 1;
                        j++;
                    }
                    if (check == 0)
                        array[i] = Random_generate;
                    else
                        i--;
                }
            }
            Console.Write("Distinct Coupons Are:");
            for (int i = 0; i < Num; i++)
            {
                Console.Write($" {array[i]}");
            }
        }
    }
}
