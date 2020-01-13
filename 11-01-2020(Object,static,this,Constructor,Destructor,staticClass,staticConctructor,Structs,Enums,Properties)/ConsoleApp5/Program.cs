using System;

namespace ConsoleApp5
{
    class Test
    {
       public Test()
        {
            Console.WriteLine("Hello Iam from Test Class Constructor");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
        }
    }
}
