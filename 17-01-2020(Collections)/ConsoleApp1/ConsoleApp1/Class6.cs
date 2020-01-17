using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generics5<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mult(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
}
