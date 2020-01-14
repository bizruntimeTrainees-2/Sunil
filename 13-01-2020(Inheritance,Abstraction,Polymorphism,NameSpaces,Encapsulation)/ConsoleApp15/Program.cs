using System;

namespace ConsoleApp15
{
    public class Animal
    {
        public string color = "white";

    }
    public class Dog : Animal
    {
        public string color = "black";
    }
    public class TestSealed
    {
        public static void Main()
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);

        }
    }
}