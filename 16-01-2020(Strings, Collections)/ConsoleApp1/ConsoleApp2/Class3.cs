using System;
using System.Collections;
using System.Text;

namespace ConsoleApp2
{
    class C3
    {
        public void Method()
        {
            ArrayList li = new ArrayList();
            li.Add(100); 
            li.Add(200); 
            li.Add(300);
            li.Add(400);
            li.Add(500);
            foreach (object obj in li)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            li.Insert(2, 250);
            foreach(Object obj in li)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            //li.Remove(200);
            li.RemoveAt(2);
            foreach (Object obj in li)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

        }
    }
}
