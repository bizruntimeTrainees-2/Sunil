using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class ParallelForEachExample1
    {
        public static void Method()
        {
            DateTime StartDateTime = DateTime.Now;
            Console.WriteLine($"Parallel foreach method start at : {StartDateTime}");
            List<int> integerList = Enumerable.Range(1, 10).ToList();
            Parallel.ForEach(integerList, i =>
            {
                long total = DoSomeIndependentTimeConsumingTask();
                Console.WriteLine($"{i} - {total}");
            });
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine($"Parallel foreach method end at : {EndDateTime}");
            TimeSpan span = EndDateTime - StartDateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine($"Time Taken by Parallel foreach method in miliseconds {ms}");
        }

        private static long DoSomeIndependentTimeConsumingTask()
        {
            long total = 0;
            for(int i = 1; i < 100000000; i++)
            {
                total += 1;
            }
            return total;
        }
    }
}
