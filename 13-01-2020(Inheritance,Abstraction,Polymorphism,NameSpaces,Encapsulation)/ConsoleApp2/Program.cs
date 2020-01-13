using System;

namespace ConsoleApp2
{
    class Param
    {
        public String busName = "garuda";
    }
    class State : Param
    {
        public String stateName = "belongs to AP";
    }
    class Program
    {
        static void Main(string[] args)
        {
            State s = new State();
            Console.WriteLine(s.busName + " " + s.stateName);
        }
    }
}