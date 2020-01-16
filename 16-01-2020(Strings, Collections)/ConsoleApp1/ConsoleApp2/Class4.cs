using System;
using System.Collections;
using System.Text;

namespace ConsoleApp2
{
    class C4
    {
        public void Method()
        {
            Hashtable ht = new Hashtable();
            ht.Add("EmpId", 1010);
            ht.Add("EName", "Suri");
            ht.Add("Jod", "Mgr");
            ht.Add("Email", "asd@gmail.com");
            ht.Add("Salary", 250000);
            ht.Add("PhNo", "1234567890");
            Console.WriteLine(ht["Email"]);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
        }
    }
}
