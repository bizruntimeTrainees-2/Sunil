using System;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;

namespace ConsoleApp1
{
    class MainClass
    {
        //static async Task Main(string[] args)
        static void Main(string[] args)
        {
            /* AsyncExample1 obj = new AsyncExample1();
             obj.Method();*/

            /* AsyncExample2 obj = new AsyncExample2();
             Console.WriteLine(obj.GetTodayInfo().Result);*/

            /* AsyncExample3 obj = new AsyncExample3();
             await obj.Method();           */

            /* AsyncExample4 obj = new AsyncExample4();
               obj.Method1();
               obj.Method2();*/

            AsyncExample5 obj = new AsyncExample5();
            obj.CallMethod();
            Console.ReadKey();

        }
    }      
}
