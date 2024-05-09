using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevekEsJegyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adja meg az osztály létszámát!");
            int letSzam;
            while (int.TryParse(Console.ReadLine(), out letSzam) == false || letSzam <= 0)
            {
                Console.WriteLine("A beírt adat nem megfelelő! Kérem, helyes adatot adjon meg!");
            }
            string[] nevek = new string[letSzam];
            //byte[] jegyek = new byte[letSzam];
            byte[] jegyek = new byte[nevek.Length];
            for (int i = 0; i < letSzam; i++)
            {
                Console.WriteLine($"Kérem, adja meg a(z) {i + 1}. tanuló nevét!");
                nevek[i] = Console.ReadLine();
                Console.WriteLine($"Kérem azdja meg a(z) {nevek[i]} nevű tanulóhoz tartozó jegyet!");
                while (byte.TryParse(Console.ReadLine(), out jegyek[i]) == false || (jegyek[i] <= 0 || jegyek[i] > 5))
                {
                    Console.WriteLine($"A beírt adat: {jegyek[i]} nem megfelelő! Kérem, egy helyes adatot adjon meg!");
                }
            }

            double atlag = 0;

            for (int i = 0; i < letSzam; i++)
            {
                atlag += jegyek[i];
            }

            atlag /= letSzam;
            Console.WriteLine($"Az osztály átlaga: {atlag}");

            int min = 0;
            for (int i = 1; i < letSzam; i++)
            {
                if (jegyek[min] > jegyek[i])
                {
                    min = i;
                }
            }

            Console.WriteLine($"A legrosszabb tanuló neve: {nevek[min]}");

            int max = 0;
            for (int i = 1; i < letSzam; i++)
            {
                if (jegyek[max] < jegyek[i])
                {
                    max = i;
                }
            }

            Console.WriteLine($"A legrosszabb tanuló neve: {nevek[max]}");

            Console.ReadKey();
        }
    }
}
