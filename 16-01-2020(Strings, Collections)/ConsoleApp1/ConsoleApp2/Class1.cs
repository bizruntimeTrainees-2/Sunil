using System;
using System.Collections;

namespace ConsoleApp2
{
    class C1
    {
        public void Method()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine(list.Capacity);
            list.Add(100);
            Console.WriteLine(list.Capacity);
            list.Add(200); list.Add(300); list.Add(400);
            Console.WriteLine(list.Capacity);
            list.Add(500);
            Console.WriteLine(list.Capacity);
            foreach (Object obj in list)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
