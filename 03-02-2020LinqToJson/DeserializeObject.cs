using System;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class DeserializeObject
    {
        public void deserializeObject()
        {
            string json = @"{
              'Email': 'james@example.com',
              'Active': true,
              'CreatedDate': '2013-01-20T00:00:00Z',
              'Roles': [
                'User',
                'Admin'
              ]
            }";
            Account account = JsonConvert.DeserializeObject<Account>(json);
            Console.WriteLine(account.Email);
            Console.WriteLine(account.Active);
            Console.WriteLine(account.CreatedDate);
        }
    }
}
