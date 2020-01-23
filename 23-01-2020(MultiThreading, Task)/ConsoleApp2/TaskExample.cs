using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class TaskExample
    {
       public void taskExample()
        {
            //Starting task
            var task = Task<String>.Factory.StartNew(() => {
                Thread.Sleep(2000);
                return "Sunil";
            });
            //use Results
            Console.Write("My name is ");
            Console.WriteLine(task.Result);
        }
    }
}
