using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TryCatchesExceptionClass
    {
        public void trycatchesExceptionClass()
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
            catch(OverflowException ex1)
            {
                Console.WriteLine(ex1.Message);
                Console.WriteLine("Enter With in a range of integer");
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            Console.WriteLine("End Of Program");
        }
    }
}
