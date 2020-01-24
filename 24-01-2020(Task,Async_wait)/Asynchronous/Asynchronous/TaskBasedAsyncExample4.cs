using System;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous
{
    class TaskBasedAsyncExample4
    {
        public void Method()
        {
            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId} Started");
            Task task1 = Task.Run(() =>
            {
                PrintCounter();
            });
            task1.Wait();
            Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId} Completed");
        }
        static void PrintCounter()
        {
            Console.WriteLine($"Child Thread: {Thread.CurrentThread.ManagedThreadId} Started ");
            for (int count = 0; count <= 5; count++)
            {
                Console.WriteLine($"Count value: {count}");
            }
            Console.WriteLine($"Child Thread: {Thread.CurrentThread.ManagedThreadId} Completed");
        }
    }
}
