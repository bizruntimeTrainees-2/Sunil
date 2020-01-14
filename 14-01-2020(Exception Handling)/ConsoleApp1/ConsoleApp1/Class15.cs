using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class EvenException
    {
        public void evenException()
        {
            Console.WriteLine("Enter a Value");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Value");
            int j = int.Parse(Console.ReadLine());
            if (j % 2 == 0)
            {
                throw new DivideByEvenNumber();
            }
            int num = i / j;
            Console.WriteLine("Result is " + num);
        }
    }
}
