using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinkedListExample
    {
        public void linkedListMethod()
        {
            LinkedList<String> li = new LinkedList<string>();
            li.AddLast("somu");
            li.AddLast("ponu");
            li.AddLast("nomu");
            li.AddLast("thomu");
            li.AddFirst("nani");

            foreach(String Names in li)
            {
                Console.WriteLine(Names + " ");
            }
        }
    }
}
