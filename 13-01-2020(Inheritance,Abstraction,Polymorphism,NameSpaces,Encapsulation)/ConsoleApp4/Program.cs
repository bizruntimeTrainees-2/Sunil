using System;

namespace ConsoleApp4
{
    class Vehicals
    {
        public String vehicalName = "Bus";
        public String vehiicalName1 = "Car";
    }
    class Contains : Vehicals
    {
        public String contains = "contains Engine";
    }
    class MovesOn : Contains
    {
        public String moviesOn = "Moves on road";
    }
    class Program
    {
        static void Main(string[] args)
        {
            MovesOn m = new MovesOn();
            Console.WriteLine(m.vehicalName + " " + m.contains + " " + m.moviesOn);
            Console.WriteLine(m.vehiicalName1 + " " + m.contains + " " + m.moviesOn);
        }
    }
}
