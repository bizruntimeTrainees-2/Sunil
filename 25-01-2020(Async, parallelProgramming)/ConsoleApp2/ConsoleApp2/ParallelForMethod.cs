using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ParallelForMethod
    {
        public static void Method()
        {
            Console.WriteLine("C# For Loop");
            int number = 10;
            for(int count = 0; count < number; count++)
            {
                Console.WriteLine($"Value of count is: {count}, thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("C# Parallel For Loop");
            Parallel.For(0, number, count =>
            {
                Console.WriteLine($"Value of Count is: {count}, thread = {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            Console.ReadKey();
        }
    }
}
