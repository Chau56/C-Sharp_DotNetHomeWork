using System;
using System.Linq;

namespace _02_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of the integer array:");
            int len = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the array numbers (Separate numbers with newlines):");
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe array information is as follows:");
            Console.WriteLine("Min:{0}", array.Min());
            Console.WriteLine("Max:{0}", array.Max());
            Console.WriteLine("Average value:{0}", GetAverage(array));
            Console.WriteLine("Sum of elements:{0}", array.Sum());
        }

        static int GetAverage(int[] arr)
        {
            if (arr.Length == 0)
                return -1;
            return arr.Sum() / arr.Length;
        }
    }
}
