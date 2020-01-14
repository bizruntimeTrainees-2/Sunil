using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter i value");
            int a = int.Parse(Console.ReadLine());
            Program p1 = new Program();
            Console.WriteLine(p1.PassByRef(ref a));
            Console.WriteLine(a);
        }
        public  int PassByRef(ref int i)
        {
            i *= i;
            return i;
        }
    }
}
