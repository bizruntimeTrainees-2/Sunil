using System;

namespace ConsoleApp8
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Hello Iam From Constructor body");
        }
        ~Program()
        {
            Console.WriteLine("Hello Iam From Destructor");
        }
    }
    class Destructor
    {
        static void Main(string[] args)
        {
            Program p = new Program();
        }
    }
}
