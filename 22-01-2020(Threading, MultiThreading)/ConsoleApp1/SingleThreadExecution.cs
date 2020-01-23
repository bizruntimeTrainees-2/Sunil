using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SingleThreadExecution
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("test1: " + i);
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("test2: " + i);
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
                Console.WriteLine("test3: " + i);
        }
    }
}
