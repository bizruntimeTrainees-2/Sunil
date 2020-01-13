using System;

namespace ConsoleApp16
{
    public enum Season { WINTER, SUMMER, SPRING, MONSOON };
    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)Season.MONSOON;
            int y = (int)Season.SPRING;
            Console.WriteLine("WINTER = " + x);
            Console.WriteLine("Spring = " + y);
        }
    }
}
