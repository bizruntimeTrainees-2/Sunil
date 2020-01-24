using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class TaskCancelationExample4
    {
        public void Method()
        {
            var planned = new CancellationTokenSource();
            var preventative = new CancellationTokenSource();
            var emargency = new CancellationTokenSource();

            var linkCancelationTasks = CancellationTokenSource.CreateLinkedTokenSource(
                planned.Token, preventative.Token, emargency.Token);

            Task.Factory.StartNew(() =>
            {
                int i = 0;
                while (true)
                {
                    linkCancelationTasks.Token.ThrowIfCancellationRequested();
                    Console.WriteLine(i);
                    i++;
                    Thread.Sleep(1000);
                }
            }, linkCancelationTasks.Token);
            Console.ReadKey();
            emargency.Cancel();
            Console.WriteLine("Main Done");
            Console.ReadKey();
        }
    }
}
