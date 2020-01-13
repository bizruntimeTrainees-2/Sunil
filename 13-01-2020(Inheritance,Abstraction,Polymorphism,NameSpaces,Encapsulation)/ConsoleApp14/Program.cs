using System;

namespace ConsoleApp14
{
    public class Draw
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing.........");
        }
    }
    public class Money : Draw
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Money........");
        }
    }
    public class Coins : Money
    {
        public override void draw()
        {
            Console.WriteLine("Drawing coins..........");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Draw c;
            c = new Draw();
            c.draw();
            c = new Money();
            c.draw();
            c = new Coins();
            c.draw();
        }
    }
}
