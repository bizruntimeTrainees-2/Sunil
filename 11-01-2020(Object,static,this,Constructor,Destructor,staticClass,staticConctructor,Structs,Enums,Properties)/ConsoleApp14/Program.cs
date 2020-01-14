using System;

namespace ConsoleApp14
{
    public struct Rectangle
    {
        public int width, height;
    }
    class TestStructs
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.width = 4;
            r.height = 5;
            Console.WriteLine("Area Of Rectangle is: " +(r.width * r.height));
        }
    }
}
