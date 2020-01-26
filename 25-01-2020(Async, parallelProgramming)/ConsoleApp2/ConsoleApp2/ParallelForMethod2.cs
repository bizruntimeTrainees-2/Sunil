using System;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ParallelForMethod2
    {
        public static void Method()
        {
            DateTime StartDateTime = DateTime.Now;
            Console.WriteLine($"Parallel For Loop Execution Starts at{StartDateTime}");
            Parallel.For(0, 10, i =>
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine($"{i} - {total}");
            });
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine($"Parallel For Loop Execution Ends at{StartDateTime}");

            TimeSpan span = EndDateTime - StartDateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine($"Time Taken to execute the loop in milliseconds {ms}");
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }

        private static long DoSomeIndependentTask()
        {
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += 1;
            }
            return total;
        }
    }
}
