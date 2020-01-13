using System;

namespace ConsoleApp18
{
    //transversing all values using getvalues()
    class Program
    {
        public enum Days { sun, mon, tue, wed, thur, fri, sat }
        static void Main(string[] args)
        {
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }
        }
    }
}