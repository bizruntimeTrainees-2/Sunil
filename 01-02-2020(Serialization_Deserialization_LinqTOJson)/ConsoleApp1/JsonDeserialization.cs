using System;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class JsonDeserialization
    {
        public void jsonDserialization()
        {
            String json= @"{
                'Id': 1,
                'Name': 'Rangu',
                'Address': 'India'
            }";
            Employee empObj = JsonConvert.DeserializeObject<Employee>(json);
            Console.WriteLine();
        }
    }
}
