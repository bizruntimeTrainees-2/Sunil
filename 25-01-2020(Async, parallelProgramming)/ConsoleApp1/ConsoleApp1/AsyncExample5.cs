using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class AsyncExample5
    {
        public async void CallMethod()
        {
            Task<int> task = method1();
            method2();
            int count = await task;
            Method3(count);            
        }
        public static async Task<int> method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
               for(int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("Method1");
                    count += 1;
                }
            });
            return count;
        }
        public static void method2()
        {
            for(int i = 0; i <= 25; i++)
            {
                Console.WriteLine("Method2");
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Count value is: " + count);
        }
    }
}
