using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParseJArrayFromText
    {
       public void parseJArrayFromText()
        {
            string json = @"[
                'Small',
                'Medium',
                'Large'               
            ]";
            JArray obj = JArray.Parse(json);
            Console.WriteLine(obj);
        }
    }
}
