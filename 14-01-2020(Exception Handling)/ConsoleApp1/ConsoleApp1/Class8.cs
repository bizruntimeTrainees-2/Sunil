using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExprementingReturnStmt
    {
        public void returns()
        {
            try
            {
                Console.WriteLine("Enter a Value");
                int i = int.Parse(Console.ReadLine());  
                Console.WriteLine("Enter a Value");
                int j = int.Parse(Console.ReadLine());
                if(j == 1)
                {
                    return;
                }
                int num = i / j;
                Console.WriteLine("Result is " + num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
            Console.WriteLine("End Of The Program");
        }
    }
}
