using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParallelForExample3
    {
        public static void Method()
        {
            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 2
            };
            int n = 10;
            Parallel.For(0, n, options, i =>
            {
                Console.WriteLine($"Value of i = {i}, thread= {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            Console.WriteLine("Press any key to exit");
            Console.WriteLine();
        }
    }
}
