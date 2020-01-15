using System;

namespace Delegates
{
    public delegate void HelloFunctionPointer(String Message);
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionPointer h1 = new HelloFunctionPointer(Hello);
            h1("Hello world");

        }
        public static void Hello(String Message)
        {
            Console.WriteLine(Message);
        }
    }
}
