using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SerializeAnObject
    {
        public void serializeAnObject()
        {
            Account account = new Account
            {
                Email = "james@gmail.com",
                Active = true,
                CreatedDate = new DateTime(2020, 02, 03, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<String>
                {
                    "user",
                    "Admin"
                }
            };
            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);
        }

    }
}
