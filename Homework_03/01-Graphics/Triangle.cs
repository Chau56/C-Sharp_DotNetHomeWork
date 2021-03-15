using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Graphics
{
    class Triangle:Shape
    {
        private double side1, side2, side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double getArea()
        {
            double a = (double)(side1 + side2 + side3) / 2;
            double s = Math.Sqrt(a * (a - side1) * (a - side2) * (a - side3));
            return s;
        }
        public bool judgeLegal()
        {
            if((side1+side2>side3)&&(side1+side3>side2)&&(side2+side3>side1))
                return true;
            else
                return false;
        }
    }
}
