using System;
using System.Threading.Tasks;
using System.Threading;

namespace Asynchronous
{
    class TaskBasedAsyncExample1
    {
        public void Method()
        {
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            Task task1 = new Task(PrintCounter);
            task1.Start();
            Console.WriteLine($"MainThread: { Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadKey();
        }
        static void PrintCounter()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for(int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine($"Child Thread: {Thread.CurrentThread.ManagedThreadId} Completed");
        }
    }
}
