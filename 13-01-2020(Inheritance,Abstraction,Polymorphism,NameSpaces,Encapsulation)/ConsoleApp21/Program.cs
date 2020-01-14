using System;

namespace First
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello FirstNameSpace");
        }
    }
}
namespace second
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("Hello SecondNameSpace");
        }
    }
}
    class TestNameSpaces
    {
        static void Main(string[] args)
        {
            First.Hello h1 = new First.Hello();
            second.Hello h2 = new second.Hello();
            h1.sayHello();
            h2.sayHello();
        }
    }

