using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearisKeresesDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] szamok = new int[5];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(-100, 100);
                Console.Write($"{szamok[i]};");
            }
            Console.WriteLine("\n--");
            Console.WriteLine($"A szamok kozott van 50-nel nagyobb: {ProgTetel.Eldontes(szamok, Nagyobb50)}");
            Console.WriteLine($"A szamok kozott van paros: {ProgTetel.Eldontes(szamok, Paros)}");
            Console.WriteLine($"A szamok kozott van prim: {ProgTetel.Eldontes(szamok, Prim)}");

            Console.ReadKey();
        }

        static bool Nagyobb50(int szam)
        {
            return szam > 50;
        }

        static bool Paros(int szam)
        {
            return szam % 2 == 0;
        }

        static bool Prim(int szam)
        {
            if (szam > 0)
            {
                bool prim = true;
                for (int i = 2; i <= Math.Sqrt(szam); i++)
                {
                    if (szam % i == 0)
                    {
                        prim = false;
                    }
                }
                return prim;
            }
            else
            {
                return false;
            }
        }
    }
}
