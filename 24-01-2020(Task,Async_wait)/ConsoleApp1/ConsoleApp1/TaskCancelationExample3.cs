using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class TaskCancelationExample3
    {
        public void Method()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            token.Register(() =>
            {
                Console.WriteLine("Cancelation has been Requested");
            });
            var t = new Task(() =>
            {
                int i = 0;
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine(i);
                    i++;
                }
            }, token);
            t.Start();
            Task.Factory.StartNew(() =>
            {
                token.WaitHandle.WaitOne();
                Console.WriteLine("Waite handle released, Calcelation Requested");
            });
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine("Main Done");
            Console.ReadKey();
        }
    }
}
