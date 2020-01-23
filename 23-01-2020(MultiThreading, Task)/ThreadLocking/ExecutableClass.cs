using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadLocking
{
    class ExecutableClass
    {
        public void ExecutableStatments()
        {
            /* Console.WriteLine("Main Thread Starting");
             JoinDemo jd = new JoinDemo();
             Thread t1 = new Thread(jd.Test1);
             Thread t2 = new Thread(jd.Test2);
             Thread t3 = new Thread(jd.Test3);
             t1.Start(); t2.Start(); t3.Start();
             t1.Join(3000); t2.Join(); t3.Join();
             Console.WriteLine("Main Thread Exiting");*/

            /* ThreadLockingDemo obj = new ThreadLockingDemo();
             *//*obj.display();
             obj.display();
             obj.display();*//*
             Thread t1 = new Thread(obj.display);
             Thread t2 = new Thread(obj.display);
             Thread t3 = new Thread(obj.display);
             t1.Start();t2.Start(); t3.Start();*/

            Thread t1 = new Thread(ThreadPrioritesClass.IncrementCount1);
            Thread t2 = new Thread(ThreadPrioritesClass.IncrementCount2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("Main thread is going to sleeep");
            Thread.Sleep(10000);
            Console.WriteLine("Main thread wokeup");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Value of count1: " + ThreadPrioritesClass.count1);
            Console.WriteLine("Value of count2: " + ThreadPrioritesClass.count2);
        }
    }
}
