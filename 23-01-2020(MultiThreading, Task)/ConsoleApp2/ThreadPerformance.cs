using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class ThreadPerformanceClass
    {
        
       public void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 1000000000; i++)
                    Count++;
            Console.WriteLine("Value of Counter1: " + Count);
        }
        
        public void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 1000000000; i++)
                Count++;
            Console.WriteLine("Value of Counter2: " + Count);
        }
    }
}
