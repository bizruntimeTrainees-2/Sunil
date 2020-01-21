using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void addDelegate(int ax, int y);
    public delegate String sayDelegate(string str);
    class Example2
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public String SayHello(String name)
        {
            return "Hello " + name;
        }
    }
}
