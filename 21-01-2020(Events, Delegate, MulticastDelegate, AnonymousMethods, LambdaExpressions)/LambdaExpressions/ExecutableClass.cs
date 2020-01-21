using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions
{
    class ExecutableClass
    {
        public void ExecutableMain()
        {
            /*GreetingsDelegate obj = delegate (string name) 
            {
                return "Hello " + name + " A very good Morning";
            };
            string str = obj.Invoke("Scott");
            Console.WriteLine(str);*/

            LambdaExpression lc = new LambdaExpression();
            GreetingsDelegate obj1 = new GreetingsDelegate(lc.Greetings);
            string st = obj1.Invoke("Raju");
            Console.WriteLine(st);
        }

    }
}
