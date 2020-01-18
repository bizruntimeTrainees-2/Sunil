using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConcurrentStackExample
    {
        public void stackMethod()
        {
            ConcurrentStack<int> s = new ConcurrentStack<int>();

            s.Push(50);
            s.Push(100);
            s.Push(150);
            s.Push(200);
            s.Push(250);
            s.Push(300);

            if (s.IsEmpty)
            {
                Console.WriteLine("The stack is empty!");
            }

            else
            {
                Console.WriteLine("The stack isn't empty");
            }
        }
    }
}
