using System;
using System.Linq;

namespace ConsoleApp2
{
    class LinqDemoProgram
    {
        public void DemoProgram()
        {
            String[] names = { "Bill", "Steve", "James", "Mohan" };

            var myLinqQuery = from name in names
                              where name.Contains("a")
                              select name;

            foreach( var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
        }
    }
}
