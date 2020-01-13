using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter i and j values");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine(add(i, j));
        }
        static int add(int i, int j)
        {
            int sum = i + j;
            return sum;
        }
    }
}