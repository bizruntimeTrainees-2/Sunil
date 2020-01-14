using System;

namespace ConsoleApp20
{
    public class Rectangle : Interface1
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle...");
        }
    }
    public class Circle : Interface1
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle......");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 inter;
            inter = new Rectangle();
            inter.draw();
            inter = new Circle();
            inter.draw();
        }
    }
}
