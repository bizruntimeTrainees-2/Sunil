using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ThrowDemo
    {
        public void throwDemo()
        {
            Console.WriteLine("Enter a Value");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Value");
            int j = int.Parse(Console.ReadLine());
            if (j % 2 > 0)
            {
                throw new ApplicationException("Divisor cannot be odd number");
            }
            int num = i / j;
            Console.WriteLine("Result is " + num);
        }
    }
}
