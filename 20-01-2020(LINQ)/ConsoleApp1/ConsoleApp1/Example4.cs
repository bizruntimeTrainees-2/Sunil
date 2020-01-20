using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    delegate void Print();
    class Example4
    {
        public void method4()
        {
            Print print = () => Console.WriteLine("ParameterLess Lambda Expression");

            print();
        }
    }
}
