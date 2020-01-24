using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaskExample1
    {
        public void write(Char c)
        {
            int i = 1000;
            while(i --> 0)
            {
                Console.Write(c);
            }
        }
    }
}
