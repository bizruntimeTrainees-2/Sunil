using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FinallyDemo
    {
        public void finallyDemo()
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
            catch(Exception ex) 
            {
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
            Console.WriteLine("End Of The Program");
        }
    }
}
