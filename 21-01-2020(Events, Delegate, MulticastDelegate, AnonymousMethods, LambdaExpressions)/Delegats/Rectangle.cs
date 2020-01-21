using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void RectDelegate(double width, double heigth);
    class Rectangle
    {
        public void GetArea(double width, double height) 
        {
            Console.WriteLine("Area of the rectangle: " + width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of the rectangle: " + 2 * (width + height));
        }
    }
}
