using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generics3
    {
        public bool Compare<T>(T x, T y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }// Now it can accept only specified type of value
    }
}
