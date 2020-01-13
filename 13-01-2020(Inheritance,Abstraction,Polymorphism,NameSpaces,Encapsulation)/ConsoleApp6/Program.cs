using System;

namespace ConsoleApp6
{
    public class Cal
    {
        public int add(int i , int j)
        {
            return i + j;
        }
        public int add(int i, int j, int k)
        {
            return i + j + k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            Console.WriteLine(c.add(10, 20));
            Console.WriteLine(c.add(10, 20, 30));
        }
    }
}
