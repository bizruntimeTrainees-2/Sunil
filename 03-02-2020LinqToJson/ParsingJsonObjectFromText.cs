using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ParsingJsonObjectFromText
    {
        public void parsingJsonObjectFromText()
        {
            string json= @"{
                CPU: 'Intel',
                Drives: [
                    'DVD read/writer',
                    '500 gigabyte hard drive'
                  ]                          
          }";
            JObject obj = JObject.Parse(json);
            Console.WriteLine(obj);
        }
    }
}
