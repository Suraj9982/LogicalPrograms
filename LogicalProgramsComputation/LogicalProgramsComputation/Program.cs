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
                Console.WriteLine("CHOOSE ONE OPTION\n1.Fibonacci Series\n2.Perfect Number\n3.Exit");
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
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("your choice should be between 1 to 3");
                        break;
                       
                }
            }
        }
    }
}
