using System;
using System.Collections.Generic;
using System.Text;

namespace _02_SumOfArea
{
    class Rectangle:Area
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double getArea()
        {
            return width * length;
        }
    }
}
