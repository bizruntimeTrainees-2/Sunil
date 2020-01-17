using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DictionaryCollection
    {
        public void dictionaryCollectionMethod()
        {
            Dictionary<string, object> ht = new Dictionary<string, object>();
            ht.Add("EmpId", 1010);
            ht.Add("EName", "Suri");
            ht.Add("Jod", "Mgr");
            ht.Add("Email", "asd@gmail.com");
            ht.Add("Salary", 250000);
            ht.Add("PhNo", "1234567890");

            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}
