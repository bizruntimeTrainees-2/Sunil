using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class SyntaxExmple
    {
        public void Method()
        {
            IList<String> stringList = new List<String>()
            {
                "C# Tutorials",
                "VB Tutorials",
                "Learn c++",
                "MVC Tutorials",
                "JAVA"
            };

            var results = from s in stringList
                          where s.Contains("Tutorials")
                          select s;

            foreach(var str in results)
            {
                Console.WriteLine(str);
            }
        }
    }
}
