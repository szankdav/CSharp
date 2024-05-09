using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerem adja meg hanyadik Fibonacci szamot keressuk:");
            Console.WriteLine(FibonacciSorozat(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }

        static int FibonacciSorozat(int szam)
        {
            if (szam <= 2)
            {
                return 1;
            }
            else
            {
                return FibonacciSorozat(szam - 1) + FibonacciSorozat(szam - 2);
            }
        }
    }
}