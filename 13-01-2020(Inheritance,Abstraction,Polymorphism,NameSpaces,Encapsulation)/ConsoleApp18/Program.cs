using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            sealed int x = 10;
            x++;
            Console.WriteLine(x);
        }
    }
}
