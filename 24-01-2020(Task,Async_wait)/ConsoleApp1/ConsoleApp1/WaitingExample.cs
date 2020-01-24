using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class WaitingExample
    {
        public void Method()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var t = new Task(() =>
            {
                Console.WriteLine("Press any key to disarm: you have only 5 seconds");
                bool Cancelled = token.WaitHandle.WaitOne(5000);
                Console.WriteLine(Cancelled ? "Bomb disarmed" : "BOOM!!!!!");
            }, token);
            t.Start();
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine("Main Done");
            Console.ReadKey();
        }
    }
}
