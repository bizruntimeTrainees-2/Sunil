using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class S4
    {
        public void CallingFunction()
        {
            String s1 = "abc";
            String s2 = "";
            String s3 = null;
            Console.WriteLine(sampleMethod(s1));
            Console.WriteLine(sampleMethod(s2));
            Console.WriteLine(sampleMethod(s3));
        }
        public String sampleMethod(String s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return "String is Emply Or NUll";
            }
            else
            {
                return String.Format("(\"{0}\")", s);
            }
        }
    }
}
