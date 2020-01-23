using System;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadDemo
    {
        public void Demo()
        {
            // CurrentThread is a static property in the thread class.
            //it returns the referance of the current exceuting thread.

            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread"; // we are giving a name to the thread explicitly.
            Console.WriteLine("Current Executing Thread is: " + Thread.CurrentThread.Name);
        }
    }
}
