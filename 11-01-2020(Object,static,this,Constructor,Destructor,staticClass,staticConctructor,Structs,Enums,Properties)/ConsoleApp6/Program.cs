using System;

namespace ConsoleApp6
{
    class Program
    {
        Program(int i, String s)
        {
            int id = i;
            String str = s;
            Console.WriteLine(id + " " + str);
        }
        static void Main(string[] args)
        {
            Program p = new Program(2, "Sunil");
        }
    }
}
