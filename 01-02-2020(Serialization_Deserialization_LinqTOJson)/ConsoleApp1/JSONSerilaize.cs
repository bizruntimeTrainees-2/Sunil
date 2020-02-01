using IdentityModel.Client;
using Newtonsoft.Json;
using System;

namespace ConsoleApp1
{
    class JSONSerilaize
    {
        public void jsonSerilaize()
        {
            //Serilaization
            Employee empObj = new Employee();
            empObj.Id = 1;
            empObj.Name = "Steve";
            empObj.Address = "Bangalore";

            //Convert employee object into Json String format
            string jsonData = JsonConvert.SerializeObject(empObj);

            Console.WriteLine(jsonData);
        }
    }
}
