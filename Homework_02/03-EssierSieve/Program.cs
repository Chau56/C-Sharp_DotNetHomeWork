using System;

namespace _03_EssierSieve
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            int[] arr = new int[num + 1];
            int a = 2;

            for (int i = 0; i < num + 1; i++)
            {
                for (int x = 1; x < arr.Length; x++)
                {
                    if (x % a == 0 && x != a)
                        arr[x] = 1;
                }
                for (int y = 1; y < arr.Length; y++)
                {
                    if (y > a && arr[y] == 0)
                    {
                        a = y;
                        break;
                    }
                }
            }

            Console.WriteLine("The prime number obtained by \"Essier Sieve Method\" is:");
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] == 0)
                    Console.Write(j + " ");
            }
        }
    }
}
