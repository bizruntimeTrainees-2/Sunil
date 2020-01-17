using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class GenericList
    {
        public void genericList()
        {
            List<int> li = new List<int>();
            li.Add(10);
            li.Add(20);
            li.Add(30);
            li.Add(40);

            for(int i = 0; i<li.Count; i++)
            {
                Console.WriteLine(li[i] + " ");
            }
            Console.WriteLine();
            foreach(int i in li)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
