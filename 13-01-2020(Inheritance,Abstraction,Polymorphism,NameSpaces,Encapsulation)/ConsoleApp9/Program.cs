using System;

namespace ConsoleApp9
{
    class baseClass
    {
        public virtual void test()
        {
            Console.WriteLine("eat)");
        }
    }
    class derivedClass: baseClass
    {
        public override void test()
        {
            Console.WriteLine("Eating-------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derivedClass obj1 = new derivedClass();
             obj1.test();
            Console.WriteLine("Hello World!");
        }
    }
}
