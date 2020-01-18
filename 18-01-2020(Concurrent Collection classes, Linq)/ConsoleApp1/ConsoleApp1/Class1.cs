using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StackExample
    {
        public void StackMethod()
        {
            Stack<String> s = new Stack<String>();

            s.Push("Sonoo");
            s.Push("tonoo");
            s.Push("ponoo");
            s.Push("honoo");

            foreach(String Name in s)
            {
                Console.WriteLine(Name + " ");
            }
            Console.WriteLine("Peek element " + s.Peek());
            Console.WriteLine("Pop element " + s.Pop());
            Console.WriteLine("After pop, Peek element is " + s.Peek());
        }
    }
}
