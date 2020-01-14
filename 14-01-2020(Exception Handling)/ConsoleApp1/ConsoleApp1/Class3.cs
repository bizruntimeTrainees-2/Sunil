using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FormatException
    {
       public void formatException()
        {
            Console.WriteLine("Enter a Value");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Value");
            int j = int.Parse(Console.ReadLine());
            int num = i / j;
            Console.WriteLine("Done");
        }
    }
}
