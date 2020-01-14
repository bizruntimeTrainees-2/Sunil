using System;

namespace ConsoleApp15
{
    namespace ConsoleApp14
    {
        public struct Rectangle
        {
            public int width;
            public int height;
           public Rectangle(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
            public void AreaOfRectangle()
            {
                Console.WriteLine("Area Of Rectangle is: " + (width * height));
            }
        }
        class TestStructs
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(4, 5);
                r.AreaOfRectangle();
            }
        }
    }
}
