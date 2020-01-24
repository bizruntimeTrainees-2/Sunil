using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TaskExample2
    {
        public void write(Object o)
        {
            int i = 1000;
            while (i --> 0)
            {
                Console.Write(o);
            }
        }
    }
}
