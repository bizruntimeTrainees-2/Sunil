using System;

namespace ConsoleApp4
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Hello Iam From Constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
