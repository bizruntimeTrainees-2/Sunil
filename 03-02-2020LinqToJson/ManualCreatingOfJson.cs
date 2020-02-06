using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ManualCreatingOfJson
    {
       public void manualCreatingOfJson()
        {
            JArray array = new JArray();
            JValue text = new JValue("Manual Text");
            JValue date = new JValue(new DateTime(2020, 02, 03));

            array.Add(text);
            array.Add(date);

            string json = array.ToString();
            Console.WriteLine(json);
        }
    }
}
