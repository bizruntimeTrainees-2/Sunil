using System;

namespace ConsoleApp2
{
    class Program
    {
        void test()
        {
            int i = 10;
            String str = "One apple price is ";
            Console.WriteLine(str + i);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test();
        }
    }
}
