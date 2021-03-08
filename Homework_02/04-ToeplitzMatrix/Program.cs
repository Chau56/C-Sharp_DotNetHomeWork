using System;

namespace _04_ToeplitzMatrix
{
    class Program
    {
        static bool IsToeplitz(int[,] arr, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + 1 >= m || j + 1 >= n)
                        break;
                    if (i != 0 && j != 0 && arr[i, j] != arr[i - 1, j - 1])
                        return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter M and N in the M*N matrix:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Console.WriteLine($"Please enter this M*N matrix:");

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                string[] values = str.Split(' ');
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(values[j]);
                }
            }

            if (IsToeplitz(array, m, n))
                Console.WriteLine("This matrix is the Toplitz matrix!");
            else
                Console.WriteLine("This matrix isn\'t the Toplitz matrix!");
        }
    }
}
