using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QueueExample
    {
        public void QueueMethod()
        {
            Queue<String> s = new Queue<string>();

            s.Enqueue("Sonoo");
            s.Enqueue("tonoo");
            s.Enqueue("ponoo");
            s.Enqueue("honoo");

            foreach (String Name in s)
            {
                Console.WriteLine(Name + " ");
            }
            Console.WriteLine("Peek element " + s.Peek());
            Console.WriteLine("Dequeue element " + s.Dequeue());
            Console.WriteLine("After Dqueue, Peek element is " + s.Peek());
        }
    }
}
