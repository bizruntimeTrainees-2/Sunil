using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExecutionClass
    {
        public void executableMethods()
        {
            /*            TaskExample1 obj = new TaskExample1();
                        Task.Factory.StartNew(() => obj.write('.'));

                        var t = new Task(() => obj.write('?'));
                        t.Start();

                        obj.write('-');
                        Console.WriteLine("Main Program Done");*/

            /* TaskExample2 obj = new TaskExample2();
             Task.Factory.StartNew(obj.write, 123);
             Task t = new Task(obj.write, "Hello");
             t.Start();
             Console.WriteLine("Main Done");*/

            /*TaskExample3 obj = new TaskExample3();
            String str1 = "Testing", str2 = "This";
            var task1 = new Task<int>(obj.TextLength, str1);
            task1.Start();
            Task<int> task2 = new Task<int>(obj.TextLength, str2);
            task2.Start();                        
            Console.WriteLine($"Length of '{str1}' is {task1.Result}");
            Console.WriteLine($"Length of '{str2}' is {task2.Result}");*/

            /* TaskCancellingExample1 obj = new TaskCancellingExample1();
             obj.Method();*/

            /* TaskCancelationExample2 obj = new TaskCancelationExample2();
             obj.Method();*/

            /*TaskCancelationExample3 obj = new TaskCancelationExample3();
            obj.Method();*/

            /*TaskCancelationExample4 obj = new TaskCancelationExample4();
            obj.Method();*/

            WaitingExample obj = new WaitingExample();
            obj.Method();

        }
    }
}
