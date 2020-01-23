using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MultiThreadingDemo
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("Test1: " + i);
        }
       public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("Test2: " + i);
        }
       public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("Test3: " + i);
        }
    }
}
