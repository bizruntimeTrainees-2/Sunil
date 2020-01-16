using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Padding
    {
        public void test()
        {
            String s1 = "Hello C#";
            String s2 = s1.PadLeft(10);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
