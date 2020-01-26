using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class AsyncExample4
    {
        public async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 50; i++)
                {
                    Console.WriteLine("Method1");
                }
            });
        }
        public void Method2()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("Method2");
            }
        }
    }
}
