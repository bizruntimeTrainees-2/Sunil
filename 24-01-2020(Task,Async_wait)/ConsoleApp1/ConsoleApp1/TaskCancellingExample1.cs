using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaskCancellingExample1
    {
        public void Method()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var t = new Task(() =>
            {
                int i = 0;
                while (true)
                {
                    if (token.IsCancellationRequested)
                    {
                        throw new OperationCanceledException();

                    }
                    else
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }                
            }, token);
            t.Start();
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine("Main Done");
            Console.ReadKey();
        }
    }
}
