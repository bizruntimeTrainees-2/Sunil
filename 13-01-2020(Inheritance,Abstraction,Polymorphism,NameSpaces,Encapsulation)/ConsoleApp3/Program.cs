using System;

namespace ConsoleApp3
{
    class Test
    {
        public void test()
        {
            Console.WriteLine("Hello Iam from test");
        }
    }
    class Exam : Test
    {
        public void exam()
        {
            Console.WriteLine("Hello Iam From Exam");
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exam ex = new Exam();
            ex.test();
            ex.exam();
        }
    }
}
