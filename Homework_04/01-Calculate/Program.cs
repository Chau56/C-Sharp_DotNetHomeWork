using System;

namespace _01_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();

            Random ran = new Random();
            for(int i = 0; i < 10; i++)
            {
                list.Add(ran.Next(100));
            }

            int max = list.Head.Data;
            int min = list.Head.Data;
            int sum = 0;
            Console.Write("随机生成的链表元素为：");
            list.ForEach(a => Console.Write(a+" "));

            //最大值
            list.ForEach(a =>
            {
                if (max < a)
                {
                    max = a;
                }
            });
            Console.WriteLine("\nMax = {0}", max);

            //最小值
            list.ForEach(a =>
            {
                if (min > a)
                {
                    min = a;
                }
            });
            Console.WriteLine("Min = {0}", min);

            //求和
            list.ForEach(a => sum += a);
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
