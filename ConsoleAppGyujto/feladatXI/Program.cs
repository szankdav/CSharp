using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatXI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, várjon...");
            int[] szamok = new int[int.MaxValue / 5];
            Random r = new Random();
            szamok[0] = r.Next(1, 6);
            for (int i = 1; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(szamok[i - 1] + 1, szamok[i - 1] + 6);
            }
            Console.Clear();
            Console.WriteLine($"A létrehozott tömb elemeinek száma: {szamok.Length}");
            Console.WriteLine($"Kérem, adja meg a keresndő értéket {szamok[0]} és {szamok[szamok.Length - 1]} között!");

            int keresett;

            while (int.TryParse(Console.ReadLine(), out keresett) == false || keresett <= 0)
            {
                Console.WriteLine("A beírt adat nem megfelelő, kérem helyes adatot adjon meg!");
            }

            Stopwatch ora = new Stopwatch();
            ora.Start();
            //Lineáris keresés
            int j = 0;
            while (j < szamok.Length && szamok[j] != keresett)
            {
                j++;
            }
            ora.Stop();
            Console.WriteLine($"A lineáris keresés {ora.Elapsed} ideig futott.");
            Console.WriteLine($"Az eredménye: {((j < szamok.Length) ? "megvan az elem" : "nincs meg az elem")}");
            Console.WriteLine($"A lefutások száma: {j}");
            //Bináris keresés
            ora.Restart();
            j = 0;
            int elso = 0;
            int utolso = szamok.Length - 1;
            int kozepso;
            do
            {
                j++;
                kozepso = (elso + utolso) / 2;
                //Ha a keresett szám nagyobb, mint az aktuálisan meghatározott középső értéke
                if (szamok[kozepso] < keresett)
                {
                    elso = kozepso + 1;
                }
                //Ha a keresett szám kisebb, mint az aktuálisan meghatározott középső értéke}
                else if (szamok[kozepso] > keresett)
                {
                    utolso = kozepso - 1;
                }
            } while (elso <= utolso && szamok[kozepso] != keresett);
            ora.Stop();
            Console.WriteLine($"A bináris keresés {ora.Elapsed} ideig futott.");
            Console.WriteLine($"Az eredménye: {((elso <= utolso) ? "megvan az elem" : "nincs meg az elem")}");
            Console.WriteLine($"A lefutások száma: {j}");

            Console.ReadKey();
        }
    }
}
