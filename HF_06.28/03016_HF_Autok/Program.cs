using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03016_HF_Autok
{
    internal class Program
    {
        struct Autok
        {
            public string rendszam;
            public byte allapot;
        }
        static void Main(string[] args)
        {
            //"Készítsünk programot, mely képes autókat rendszámuk alapján letárolni, illetve hozzájuk tartozó állapot értéket (0..100).
            //A rendszerbe lehessen őket felvinni kézileg.
            //Minden adat felvitel felügyelt, csak helyes adat adható meg. (Van rendszám, 0 - 100 között van az állapot.)
            //A végén adja meg, hogy melyik autó van a legrosszabb állapotban.
            //A számítást egy funkció végezze el!"

            Console.WriteLine("Kerem adja meg, hany autot szeretne felvinni:");
            int autokDarabszama;
            while (int.TryParse(Console.ReadLine(), out autokDarabszama) == false || autokDarabszama <= 0)
            {
                Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot irjon be!");
            }

            Autok[] autok = new Autok[autokDarabszama];

            for (int i = 0; i < autok.Length; i++)
            {
                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. auto rendszamat:");

                while ((autok[i].rendszam = Console.ReadLine().Trim()) == "")
                {
                    Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot adjon irjon be!");
                }

                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. auto allapotat:");
                while (byte.TryParse(Console.ReadLine(), out autok[i].allapot) == false || autok[i].allapot < 0)
                {
                    Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot irjon be!");
                }
            }

            for (int i = 0; i < autok.Length; i++)
            {
                Console.WriteLine(autok[i].rendszam);
                Console.WriteLine(autok[i].allapot);
            }

            Console.WriteLine($"A legrosszabb allapotban levo auto a(z) {autok[LegrosszabbAutoKereso(autok)].rendszam} rendszamu auto, melynek allapota: {autok[LegrosszabbAutoKereso(autok)].allapot}");

            Console.ReadKey();
        }

        static int LegrosszabbAutoKereso(Autok[] autok)
        {
            int legrosszabb = 0;
            for (int i = 1; i < autok.Length; i++)
            {
                if (autok[legrosszabb].allapot > autok[i].allapot)
                {
                    legrosszabb = i;
                }
            }
            return legrosszabb;
        }
    }
}
