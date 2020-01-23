using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLocking
{
    class JoinDemo
    {
        public void Test1()
        {
            Console.WriteLine("Thread1 Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 exiting");
        }
        public void Test2()
        {
            Console.WriteLine("Thread2 Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test2:" + i);
            }
            Console.WriteLine("Thread2 exiting");
        }
        public void Test3()
        {
            Console.WriteLine("Thread3 Starting");
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread3 exiting");
        }
    }
}
