using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp2
{
    class ExecutableClass
    {
        public void executableMethods()
        {
            /* Stopwatch s1 = new Stopwatch();
             Stopwatch s2 = new Stopwatch();
             ThreadPerformanceClass obj = new ThreadPerformanceClass();
             Thread t1 = new Thread(obj.IncrementCounter1);
             Thread t2 = new Thread(obj.IncrementCounter2);

             s1.Start();
             obj.IncrementCounter1();
             obj.IncrementCounter2();
             s1.Stop();

             s2.Start();
             t1.Start();
             t2.Start();
             s2.Stop();

             t1.Join();
             t2.Join();

             Console.WriteLine("Time elapsed in single threaded model: " + s1.ElapsedMilliseconds);
             Console.WriteLine("Time elapsed in multi threaded model: " + s2.ElapsedMilliseconds);*/

            TaskExample obj = new TaskExample();
            obj.taskExample();
        }
    }
}
