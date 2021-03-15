using System;

namespace _01_Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            //长方形
            Rectangle r = new Rectangle(10,2);
            if (r.judgeLegal())
            {
                Console.WriteLine("此长方形的面积为：" + r.getArea());
            }
            else
            {
                Console.WriteLine("此长方形不合法！");
            }

            //正方形
            Square s = new Square(10);
            if (s.judgeLegal())
            {
                Console.WriteLine("此正方形的面积为：" + s.getArea());
            }
            else
            {
                Console.WriteLine("此正方形不合法！");
            }

            //三角形
            Triangle t = new Triangle(5, 12, 13);
            if (t.judgeLegal())
            {
                Console.WriteLine("此三角形的面积为：" + t.getArea());
            }
            else
            {
                Console.WriteLine("此三角形不合法！");
            }
        }
    }
}
