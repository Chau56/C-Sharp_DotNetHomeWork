using System;

namespace _02_SumOfArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            double sumArea = 0;
            for(int i = 0; i < 10; i++)
            {
                double tempArea = Factory.GetShape(ran.Next(1, 4)).getArea();
                Console.WriteLine($"随机创建的形状面积为：{tempArea}");
                sumArea += tempArea;
            }
            Console.WriteLine($"随机创建10个形状对象的面积之和为：{sumArea}");
        }
    }
}
