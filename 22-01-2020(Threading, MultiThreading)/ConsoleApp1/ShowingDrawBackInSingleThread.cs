using System;
using System.Threading;

namespace ConsoleApp1
{
    class ShowingDrawBackInSingleThread
    {
        public static void Test1()
        {
            for (int i = 0; i <= 50; i++)
                Console.WriteLine("test1: " + i);
        }
        public static void Test2()
        {
            int i = 0;
            for (; i <= 100; i++)
            {
                Console.WriteLine("test2: " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main Thread is going to sleep");
                    Thread.Sleep(5000);
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("test3: " + i);
        }
    }
}
