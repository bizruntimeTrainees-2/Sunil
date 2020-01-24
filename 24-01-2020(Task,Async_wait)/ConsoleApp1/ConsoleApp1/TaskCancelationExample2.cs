using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class TaskCancelationExample2
    {
        public void Method()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var t = new Task(()=> 
            {
                int i = 0;
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine(i);
                    i++;
                }
            });
            t.Start();
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine("Main Done");
            Console.ReadKey();
        }
    }
}
