using System;

namespace ConsoleApp16
{
    sealed public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating......");
        }
    }
    public class Dog : Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating bread.......");
        }
    }
    class TestSealed
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
        }
    }
}
