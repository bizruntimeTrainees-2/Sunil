using System;

namespace ConsoleApp11
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating..........");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Eating Bread..........");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            Console.WriteLine("Hello World!");
        }
    }
}
