using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[20];
            Random r = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(-1000, 1001);
                Console.Write($"{szamok[i]};");
            }

            Console.WriteLine();
            int absMax = szamok.Max(x => Math.Abs(x));
            Console.WriteLine($"A legnagyobb abszolut erteku szam: {absMax}");
            Console.WriteLine();

            Console.WriteLine($"A negyzetszamok:");
            int[] negyzetSzamok = szamok.Where(x => (Math.Sqrt(x) % 1 == 0)).ToArray();
            foreach (int szam in negyzetSzamok)
            {
                Console.Write($"{szam};");
            }
            Console.WriteLine();

            Console.WriteLine("A paratlan szamok:");
            Console.WriteLine($"A paratlan szamok darabszama: {szamok.Count(x => Math.Abs(x) % 2 == 1)}");
            int[] paratlanSzamok = szamok.Where(x => (x % 2 != 0)).ToArray();
            foreach (int szam in paratlanSzamok)
            {
                Console.Write($"{szam};");
            }
            Console.WriteLine();

            Console.WriteLine("A paros szamok negyzeteinek atlaga:");
            double parosSzamok = szamok.Average(x => x * x);


            Console.ReadKey();
        }
    }
}
