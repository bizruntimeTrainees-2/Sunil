using System;

namespace ConsoleApp1
{
    class Object
    {
        int i;
        String str;
        static void Main(string[] args)
        {
            Object obj = new Object();
            obj.i = 10;
            obj.str = "Sunil";
            Console.WriteLine("i value is " + obj.i + " str value is " + obj.str);
        }
    }
}
