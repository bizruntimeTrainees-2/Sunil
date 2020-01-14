using System;

namespace ConsoleApp7
{
    public class Cal
    {
        public int sub(int i, int k)
        {
            return k - i;
        }
        public float sub(float f1, float f2)
        {
            return f2 - f1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cal c = new Cal();
            Console.WriteLine(c.sub(10, 20));
            Console.WriteLine(c.sub(10.6f, 20.1f));
        }
    }
}
