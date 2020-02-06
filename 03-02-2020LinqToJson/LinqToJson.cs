using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
    class LinqToJson
    {
        public void linqToJson()
        {
            JObject obj = JObject.Parse(@"{
                'CPU': 'Intel',
                'Drives': [
                    'DVD read/Writer',
                    '500 gigabyte Hard drive'
                ]
            }");

            string cpu = (string)obj["CPU"];

            string firstDrive = (string)obj["Drives"][0];

            IList<string> allDrives = obj["Drives"].Select(t => (string)t).ToList();

            Console.WriteLine(cpu);
            Console.WriteLine(firstDrive);
            foreach(var str in allDrives)
            {
                Console.WriteLine(str);
            }
        }
    }
}
