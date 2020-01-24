using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaskExample3
    {
        public int TextLength(Object o)
        {
            Console.WriteLine($"Task with id {Task.CurrentId} processing object {o}...");
            return o.ToString().Length;
        }
    }
}
