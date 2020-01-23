using System;
using System.Threading;

namespace ThreadLocking
{
    class ThreadLockingDemo
    {
        public void display()
        {
            lock (this)
            {
                Console.Write("[C-Sharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object orented Programming Language]");
            }
        }
    }
}
