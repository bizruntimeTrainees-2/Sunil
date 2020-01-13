using System;

namespace ConsoleApp12
{
    public static class Add
    {
        public static int i = 10;
        public static int j = 20;
        public static int k = i + j;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Value of i = " + Add.i + " Value of j = " + Add.j);
            Console.WriteLine("Sum value is " + Add.k);
        }
    }
}
