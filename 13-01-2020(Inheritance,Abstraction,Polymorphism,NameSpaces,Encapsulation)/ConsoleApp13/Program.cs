using System;

namespace ConsoleApp13
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating......");
        }
    }
    class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread.........");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
        }
    }
}
