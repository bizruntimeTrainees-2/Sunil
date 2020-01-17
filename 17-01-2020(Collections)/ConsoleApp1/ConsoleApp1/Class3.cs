using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Generics2
    {
        public bool Compare(object x, object y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }// with object specification we can compare any type values but it is not type safe
    }
}
