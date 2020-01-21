using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions
{
    public delegate string GreetingsDelegate(String name);
    class LambdaExpression
    {
        public string Greetings(string str)
        {
            return "Hello " + str + " A very good Morning";
        }
    }
}
