using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutableClass ec = new ExecutableClass();
            ec.ExecutableMethods();
            Console.WriteLine("Main Thread Existing");
        }
    }
}
