using System;

namespace ConsoleApp10
{
    class Program
    {
        Program()
        {
            this.test(10);
            Console.WriteLine("Program()");
        }
        void test(int i)
        {
            Console.WriteLine("test(int)");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
