using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ConsoleApp1
{
    class ReadJsonFromAFile
    {
        public void readJsonFromAFile()
        {
            using (StreamReader reader = File.OpenText(@"D:\student_Details.json"))
            {
                JObject obj = (JObject)JToken.ReadFrom(new JsonTextReader(reader));
                Console.WriteLine(obj);
            }
        }
    }
}
