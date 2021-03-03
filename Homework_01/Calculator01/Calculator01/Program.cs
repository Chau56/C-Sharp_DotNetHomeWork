using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            String a= Console.ReadLine();
            Console.WriteLine("Please input another number:");
            String b = Console.ReadLine();
            Console.WriteLine("Please input an operator(+、-、*、/):");
            String c = Console.ReadLine();

            if (c == "+")
                Console.WriteLine(a + c + b + "=" + (Convert.ToDouble(a) + Convert.ToDouble(b)));
            else if(c == "-")
                Console.WriteLine(a + c + b + "=" + (Convert.ToDouble(a) - Convert.ToDouble(b)));
            else if (c == "*")
                Console.WriteLine(a + c + b + "=" + (Convert.ToDouble(a) * Convert.ToDouble(b)));
            else if (c == "/")
                Console.WriteLine(a + c + b + "=" + (Convert.ToDouble(a) / Convert.ToDouble(b)));
            else
                Console.WriteLine("Error!");
        }
    }
}
