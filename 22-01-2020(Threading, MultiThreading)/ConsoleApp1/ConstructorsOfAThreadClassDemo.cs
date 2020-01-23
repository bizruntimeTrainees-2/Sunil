using System;
using System.Threading;

namespace ConsoleApp1
{
    class ConstructorsOfAThreadClassDemo
    {
        public static void Test()
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test: " + i);
            }
        }
    }
}
 