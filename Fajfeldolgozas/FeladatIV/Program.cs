using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatIV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adjon meg egy tetszőleges szöveget!");
            // Szövegbekérés
            string szoveg = Console.ReadLine();
            // Kisbetűssé alakítás
            szoveg = szoveg.ToLower();
            // Ékezetmentesítés
            szoveg = Mentesito(szoveg);
            // Space-ek cseréje aláhúzásra
            szoveg = szoveg.Replace(" ", "_");
            // Eredmény kiírása
            Console.WriteLine(szoveg);

            // +1. lépés - Az összes előző lépés egy utasításban
            Console.WriteLine(Mentesito(Console.ReadLine().ToLower().Replace(" ", "_")));
            Console.ReadKey();
        }

        static string Mentesito(string szoveg)
        {
            // string[] ekezetesek = new string['á', 'é', 'í', 'ó', 'ö', 'ő', 'ú', 'ü', 'ű'];
            // Megkapja az ékezetes szöveget, és átalakítja ékezetmentessé
            string ekezetes = "áéíóöőúüű";
            string mentes = "aeiooouuu";
            string ujSzoveg = String.Empty;

            for (int i = 0; i < szoveg.Length; i++)
            {
                int index = LinearisKereses(ekezetes, szoveg[i]);
                if (index == -1)
                {
                    ujSzoveg += szoveg[i];
                }
                else
                {
                    ujSzoveg += mentes[index];
                }
            }
            return ujSzoveg;
        }

        static int LinearisKereses(string betuk, char keresett)
        {
            // Segédfüggvény a Mentesito működéséhez
            int i = 0;
            while (i < betuk.Length && !(betuk[i] == keresett))
            {
                i++;
            }
            //if (i < betuk.Length)
            //{
            //    return i;
            //}
            //else
            //{
            //    return -1;
            //}
            return i < betuk.Length ? i : -1;
        }
    }
}
