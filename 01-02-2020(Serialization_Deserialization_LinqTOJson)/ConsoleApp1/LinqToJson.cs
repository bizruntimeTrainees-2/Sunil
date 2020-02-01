using System;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class LinqToJson
    {
        public void linqToJson()
        {
            string data = @"{
                'Name': 'Manas',
                'Languages': ['C', 'Java', 'C++', 'C#', 'PHP']
            }";
            JObject studentObj = JObject.Parse(data);
            //fetch student name
            string name = (string)studentObj["Name"];
            //fetch first language name
            string firstLanguage = (string)studentObj["Language"][0];
            //fetch all languages which contain character c
            List<string> allLangs = studentObj["Languages"].Where(temp => temp.ToString().Contains("C")).Select(t => (string)t).ToList();

            //Creating JArray Object and adding elements to it.
            JArray array = new JArray();
            array.Add("Manual Text");
            array.Add(new DateTime(2020, 02, 01));

            JObject jObject = new JObject();
            jObject["MyArray"] = array;

            string json = jObject.ToString();

            Console.WriteLine(name);
            //Console.WriteLine(firstLanguage);
            //Console.WriteLine(allLangs);

        }
    }
}
