using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Clone
    {
        public void Test()
        {
            String s1 = "hello";
            String s2 = (String)s1.Clone();
            Console.WriteLine(s2);
        }
    }
}
