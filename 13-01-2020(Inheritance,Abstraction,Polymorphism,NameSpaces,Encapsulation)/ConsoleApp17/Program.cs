using System;

namespace ConsoleApp17
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating......");
        }
    }
    public class Dog : Animal
    {
        public sealed override void eat()
        {
            Console.WriteLine("Eating Bread........");
        }
    }
    public class BabyDog : Dog
    {
        public override void eat()
        {
            Console.WriteLine("Running");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BabyDog bd = new BabyDog();
            bd.eat();
        }
    }
}
