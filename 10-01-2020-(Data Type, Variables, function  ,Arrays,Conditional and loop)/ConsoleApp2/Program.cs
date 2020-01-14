using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i values");
            int i = int.Parse(Console.ReadLine());
            Program p1 = new Program();
            Console.WriteLine(p1.Show(i));
            Console.WriteLine(i);
        }
        public int Show(int a)
        {
            a++;
            return a;
        }
    }
}
