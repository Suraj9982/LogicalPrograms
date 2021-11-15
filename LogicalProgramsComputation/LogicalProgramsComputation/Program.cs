using System;

namespace LogicalProgramsComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE ONE OPTION\n1.Fibonacci Series\n2.Perfect Number\n3.PrimeNumbers\n4.Reverse NUmber\n5.Coupon Numbers\n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        Console.WriteLine("enter the length for fibonacci series");
                        int length = Convert.ToInt32(Console.ReadLine());                       
                        series.FindFibonacci(length);
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        Console.WriteLine("enter the startnumber");
                        int startnumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the endnumber");
                        int endnumber = Convert.ToInt32(Console.ReadLine());
                        perfect.FindPerfectNumber(startnumber, endnumber);
                        break;
                    case 3:
                        PrimeNumber prime = new PrimeNumber();
                        Console.WriteLine("enter the startnumber");
                        int start = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the endnumber");
                        int end = Convert.ToInt32(Console.ReadLine());
                        prime.FindPrimeNumber(start, end);
                        break;
                    case 4:
                        RevreseNumbers rev = new RevreseNumbers();
                        Console.WriteLine("enter the number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        rev.ReversetheNumber(num);
                        break;
                    case 5 :
                        CouponNumbers coupon = new CouponNumbers();
                        Console.WriteLine("how many coupon number you want to genrate");
                        int Num = Convert.ToInt32(Console.ReadLine());
                        coupon.Calculation(Num);
                        break;

                    case 6:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 6");
                        break;
                       
                }
            }
        }
    }
}
