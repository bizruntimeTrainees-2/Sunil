using System;
using System.Collections;
using System.Text;

namespace ConsoleApp2
{
    class C2
    {
        public void Method()
        {
            ArrayList li = new ArrayList(10);
            Console.WriteLine(li.Capacity);
            li.Add(100); li.Add(400);
            Console.WriteLine(li.Capacity);
            li.Add(200); li.Add(300); li.Add(400);
            Console.WriteLine(li.Capacity);
            li.Add(500); li.Add(200); li.Add(300);
            Console.WriteLine(li.Capacity);
            li.Add(400); li.Add(400);
            Console.WriteLine(li.Capacity);
            li.Add(400);
            Console.WriteLine(li.Capacity);
            foreach(object obj in li)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
        }
    }
}
