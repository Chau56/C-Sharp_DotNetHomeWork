using System;
using System.Collections.Generic;
using System.Text;

namespace _02_SumOfArea
{
    class Factory
    {
        public static Area GetShape(int i)
        {
            Area a = null;
            Random ran = new Random();
            double n1 = ran.NextDouble() * 10;
            double n2 = ran.NextDouble() * 10;
            double n3 = ran.NextDouble() * 10;
            switch (i)
            {
                case 1:
                    return new Rectangle(n1,n2);
                case 2:
                    return new Square(n1);
                case 3:
                    return new Triangle(n1, n2, n3);
            }
            return a;
        }

    }
}
