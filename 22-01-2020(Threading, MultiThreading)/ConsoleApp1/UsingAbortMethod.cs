using System;
using System.Threading;

namespace ConsoleApp1
{
    class UsingAbortMethod
    {
        public void Method()
        {
            for (int i = 0; i <=30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
    }
}
