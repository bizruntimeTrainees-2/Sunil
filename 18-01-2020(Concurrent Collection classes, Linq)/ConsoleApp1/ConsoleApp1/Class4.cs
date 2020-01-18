using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinkedExample
    {
        public void AddBeforeAddAfter()
        {
            LinkedList<String> li = new LinkedList<string>();
            li.AddLast("somu");
            li.AddLast("ponu");
            li.AddLast("nomu");
            li.AddLast("thomu");
            li.AddFirst("nani");

            Console.WriteLine("Before adding names into List");
            foreach (String Names in li)
            {
                Console.WriteLine(Names + " ");
            }
            Console.WriteLine("After Adding Names into List");

            LinkedListNode<String> node = li.Find("nomu");
            li.AddBefore(node, "-------------------------");
            li.AddAfter(node, "--------------------------");

            foreach (String Names in li)
            {
                Console.WriteLine(Names + " ");
            }
        }
    }
}
