using System;

namespace ConsoleApp12
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Hello Iam From Animal");
        }
    }
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Hello Iam Form DOG");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
        }
    }
}
