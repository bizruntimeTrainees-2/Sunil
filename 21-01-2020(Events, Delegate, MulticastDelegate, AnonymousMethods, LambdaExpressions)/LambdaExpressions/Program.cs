using System;

namespace LambdaExpressions
{
    class Program
    {
        static class LambdaExpression
        {
            public  static string Greetings(string name)
            {
                return "Hello " + name + " A very good Morning";
            }
        }
        static void Main(string[] args)
        {
            /*ExecutableClass ec = new ExecutableClass();
            ec.ExecutableMain();*/

            GreetingsDelegate obj = (name) =>
            {
                return "Hello " + name + " A very good Morning";
            };
            string st = obj.Invoke("Raju");
            Console.WriteLine(st);
        }
    }
}
