using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegyAlapMuvelet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerem adja meg az 1. szamot:");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a 2. szamot:");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kerem adja meg a muveletet! (+, -, *, /)");
            char muveletJel = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"A beadott ertekek: {szam1} es {szam2}, a kert muvelet: {muveletJel}");
            Console.WriteLine($"Az eredmeny: {NegyAlapMuvelet(szam1, szam2, muveletJel)}.");
            Console.WriteLine($"Az eredmeny: {NegyAlapMuvelet2(szam1, szam2, muveletJel)}.");
            Console.ReadKey();
        }

        static double NegyAlapMuvelet(int a, int b, char m)
        {
            double eredmeny = 0;
            switch (m)
            {
                case '+':
                    eredmeny = a + b;
                    break;
                case '-':
                    eredmeny = a - b;
                    break;
                case '*':
                    eredmeny = a * b;
                    break;
                case '/':
                    eredmeny = a * 1.0 / b;
                    break;
                default:
                    eredmeny = double.NaN;
                    break;
            }
            return eredmeny;
        }

        static double NegyAlapMuvelet2 (int a, int b, char m)
        {
            switch (m)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a * 1.0 / b;
                default:
                    return double.NaN;
            }
        }
    }
}
