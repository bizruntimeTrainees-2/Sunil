using System;

namespace ConsoleApp8
{
    class Test
    {
       public Test() : this(10)
        {
            Console.WriteLine("Hello Iam From Test()");
        }
        public Test(int i)
        {
            
            Console.WriteLine("Hello Iam From Test(int)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Test t1 = new Test(10);
            Console.WriteLine("done");
        }
    }
}
