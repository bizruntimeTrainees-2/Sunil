using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TryCatchesDemo
    {
        public void trycatchesdemo()
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
            catch(System.FormatException ex1)
            {
                Console.WriteLine("Input should be Integer");
            }
            Console.WriteLine("End Of Program");
        }
    }
}
