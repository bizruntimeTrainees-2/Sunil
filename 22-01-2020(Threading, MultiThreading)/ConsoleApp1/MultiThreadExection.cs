using System;
using System.Threading;

namespace ConsoleApp1
{
    class MultiThreadExection
    {
        public static void Test1()
        {
            Console.WriteLine("Thread-1 Executing");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test1: " + i);
            }
            Console.WriteLine("Thread-1 is Existing");
        }
        public static void Test2()
        {
            Console.WriteLine("Thread-2 Executing");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("test2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread-2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread-2 WokeUp");
                }
            }
            Console.WriteLine("Thread-2 is Existing");
        }
        public static void Test3()
        {
            Console.WriteLine("Thread-3 Executing");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test3: " + i);
            }
            Console.WriteLine("Thread-3 is Existing");
        }
    }
}
