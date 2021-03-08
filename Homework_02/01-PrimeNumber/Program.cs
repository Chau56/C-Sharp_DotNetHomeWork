using System;

namespace _01_PrimeNumber
{
    class Program
    {
        //判断i是否是素数
        static bool IsPrime(int j)
        {
            for (int a = 2; a * a <= j; a++)
            {
                if (j % a == 0)
                    return false;
            }
            return true;
        }

        //主函数
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("All prime factors of \"" + num + "\" are:");
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0 && IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
