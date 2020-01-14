using System;

namespace ConsoleApp18
{
    //transversing all values using getNames()
    class Program
    {
        public enum Days {sun,mon,tue,wed,thur,fri,sat}
        static void Main(string[] args)
        {
            foreach(String s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
