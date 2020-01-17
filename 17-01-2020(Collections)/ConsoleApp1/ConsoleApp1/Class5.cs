using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generic4
    {
        public void Add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mult<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
}
