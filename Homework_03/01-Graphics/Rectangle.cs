using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Graphics
{
    class Rectangle:Shape
    {
        private double length;
        private double width;
        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public double getArea()
        {
            return width * length;
        }
        public bool judgeLegal()
        {
            if (length > 0 && width > 0)
                return true;
            else
                return false;
        }
    }
}
