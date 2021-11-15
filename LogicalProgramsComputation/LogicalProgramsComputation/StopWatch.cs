using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProgramsComputation
{
    class StopWatch
    {
        public void StopwatchSimulate()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(6);
            }
            stopwatch.Stop();
            Console.WriteLine("The lepse time is:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
