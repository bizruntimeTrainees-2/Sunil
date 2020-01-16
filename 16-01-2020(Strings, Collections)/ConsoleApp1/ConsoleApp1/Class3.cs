using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class S3
    {
        public void test()
        {
            String s1 = new String("Hello");
            String s2 = new String("C#");
            test1(s1, s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
        public void test1(string s1, string s2)
        {
            s1 += s2;
            Console.WriteLine(s1);
        }

    }
}
