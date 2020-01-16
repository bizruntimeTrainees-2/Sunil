using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class S2
    {
        public void Sample()
        {
            String s1 = "Hello";
            char[] ch = s1.ToCharArray();

            for(int i= 0; i < ch.Length; i++)
            {
                Console.Write(ch[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
