using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CheckAvailabilaty
    {
        public void test()
        {
            String s1 = "Hello";
            String s2 = "Hello";
            String s3 = "C#";

            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
            Console.WriteLine(s2.Contains(s3));
        }
    }
}
