using System;

namespace ConsoleApp1
{
    class Variables
    {
        public static int i = 10;
        public static int j = 20;
    }
    class Sum : Variables
    {
       public int sum = i + j;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sum s = new Sum();
            Console.WriteLine(s.sum);
        }
    }
}
