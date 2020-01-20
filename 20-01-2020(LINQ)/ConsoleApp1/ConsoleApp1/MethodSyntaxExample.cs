using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MethodSyntaxExample
    {
        public void MethodSyntax()
        {
            IList<string> stringList = new List<string>()
            {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials",
                "Java"
            };
            var result = stringList.Where(s => s.Contains("Tutorials"));

            foreach(var str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
