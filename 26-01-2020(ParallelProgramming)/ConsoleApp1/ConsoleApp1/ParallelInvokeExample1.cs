using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class ParallelInvokeExample1
    {
        public static void method()
        {
            Parallel.Invoke(
                    
                NormalAction,
                delegate ()
                {
                    Console.WriteLine($"Method 2, Thread={Thread.CurrentThread.ManagedThreadId}");
                },
                () =>
                {
                    Console.WriteLine($"Method 3, Thread={Thread.CurrentThread.ManagedThreadId}");
                }
            );
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        static void NormalAction()
        {
            Console.WriteLine($"Method 1, Thread={Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
