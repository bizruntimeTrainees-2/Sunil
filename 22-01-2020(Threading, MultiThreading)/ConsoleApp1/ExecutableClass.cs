using System;
using System.Threading;

namespace ConsoleApp1
{
    class ExecutableClass
    {
        public void ExecutableMethods()
        {
            /*ThreadDemo td = new ThreadDemo();
            td.Demo();*/

            /*SingleThreadExecution.Test1();
            SingleThreadExecution.Test2();
            SingleThreadExecution.Test3();*/

            /* ShowingDrawBackInSingleThread.Test1();
             ShowingDrawBackInSingleThread.Test2();
             ShowingDrawBackInSingleThread.Test3();*/

            /*Thread T1 = new Thread(MultiThreadExection.Test1);
            Thread T2 = new Thread(MultiThreadExection.Test2);
            Thread T3 = new Thread(MultiThreadExection.Test3);

            T1.Start();
            T2.Start();
            T3.Start();*/


            /* // ThreadStart obj = new ThreadStart(ConstructorsOfAThreadClassDemo.Test);// We are creating the delegate explicitly
             //ThreadStart obj = ConstructorsOfAThreadClassDemo.Test;
             //ThreadStart obj = delegate () { ConstructorsOfAThreadClassDemo.Test(); };
             ThreadStart obj = () => ConstructorsOfAThreadClassDemo.Test();
             Thread t1 = new Thread(obj);
             // we can pass the method name directly to the constructor argument of the thread class.
             // like this Thread t1 = new Thread(Test); When we pass like this the delegate instance is implecitly created by the CLR 

             t1.Start();*/

            /* ParameterizedThreadStart obj = new ParameterizedThreadStart(ConstructorExecutionMethodWithParameter.Test);// the argument of ParameterizedThreadStart taking object as a argument
             // so we need to convert explicitly int into object in the method
            // ParameterizedThreadStart obj = ConstructorExecutionMethodWithParameter.Test;
             Thread t1 = new Thread(obj);
             t1.Start(50);*/

            Console.WriteLine("main Begin");
            UsingAbortMethod um = new UsingAbortMethod();
            Thread t1 = new Thread(new ThreadStart(um.Method));
            Thread t2 = new Thread(new ThreadStart(um.Method));

            t1.Start();
            t2.Start();

            t1.Abort();
            t2.Abort();

            Console.WriteLine("Main End");

        }
    }
}
