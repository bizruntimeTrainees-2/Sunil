using System;

namespace ConsoleApp10
{
    class Animal
    {
        public String color = "blue";
    }
    class Dog : Animal
    {
        String color = "black";
        public void show()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.show();
        }
    }
}
