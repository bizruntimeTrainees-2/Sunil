using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ParallelForMethod1
    {
        public static void Method()
        {
            DateTime StartDateTime = DateTime.Now;
            Console.WriteLine(@"For Loop Execution start at : {0}", StartDateTime);
            for (int i = 0; i < 10; i++)
            {
                long total = DoSomeIndependentTask();
                Console.WriteLine("{0} - {1}", i, total);
            }
            DateTime EndDateTime = DateTime.Now;
            Console.WriteLine(@"For Loop Execution end at : {0}", EndDateTime);
            TimeSpan span = EndDateTime - StartDateTime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine(@"Time Taken to Execute the For Loop in miliseconds {0}", ms);
            Console.WriteLine("Press any key to exist");

        }
        private static long DoSomeIndependentTask()
        {
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
