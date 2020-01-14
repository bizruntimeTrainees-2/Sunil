using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TryCatchDemo
    {
        public void tryCatchDemo()
        {
            try
            {
                Console.WriteLine("Enter a Value");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Value");
                int j = int.Parse(Console.ReadLine());
                int num = i / j;
                Console.WriteLine("Result is " + num);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("End of the Program");
        }
    }
}
