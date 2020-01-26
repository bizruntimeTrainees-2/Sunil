using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class ParallelInvokeExample2
    {
        public static void method()
        {
            Parallel.Invoke(
                () => DoSomeTask(1),
                () => DoSomeTask(2),
                () => DoSomeTask(3),
                () => DoSomeTask(4),
                () => DoSomeTask(5),
                () => DoSomeTask(6),
                () => DoSomeTask(7)
            );
        }

        static void DoSomeTask(int v)
        {
            Console.WriteLine($"DoSomeTask {v} started by Thread {Thread.CurrentThread.ManagedThreadId}");
            //Sleep for 5000 milliseconds
            Thread.Sleep(5000);
            Console.WriteLine($"DoSomeTask {v} completed by Thread {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
