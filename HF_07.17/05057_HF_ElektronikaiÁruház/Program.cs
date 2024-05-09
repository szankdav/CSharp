using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05057_HF_ElektronikaiÁruház
{
    internal class Program
    {
        //"Készítsen programot, mely egy elektronikai áruház termékeit tudja kezelni. Alapvetően minden elektronikai cikkről tudjuk a gyártóját, megnevezését, árát, cikkszámát.
        //A program induláskor olvassa fel a keszlet.csv tartalmát(ha létezik).
        //Gyártó - string, minimum 5 karakter
        //Termék megnevezése - string, minimum 5 karakter
        //Ár - uint, minimum 1
        //Cikkszám - string, pontosan 10 karakter,
        //felépítése: <rövid megnevezés 3 karakter, UpperCase> <_> <aktuális napi dátum eeHHnn formátumban>
        //Oldja meg, hogy a programban, fel lehessen vinni ezeket a termékeket(lehetnek egyező adatok is), majd a program adjon lehetőséget keresésre a termékek között cikkszám alapján.
        //Ha van felolvasott adat, akkor az új felvitel append.Ha nincs, akkor új állomány létrehozása keszlet.csv néven, és az új felvitel folyamatos rögzítése (flush)."

        static void Main(string[] args)
        {
            Console.WriteLine("Kerem adja meg a \"keszlet.csv\" fajl eleresi utvonalat:");
            string keszletFile = Console.ReadLine();

            if (File.Exists(keszletFile))
            {
                string[] aktualisKeszlet = File.ReadAllLines(keszletFile);
                Termek[] aktualisTermekek = new Termek[aktualisKeszlet.Length];
                for (int i = 0; i < aktualisKeszlet.Length; i++)
                {
                    Console.WriteLine(aktualisKeszlet[i]);
                    string[] temp = aktualisKeszlet[i].Split(';');
                    Termek tempTermek = new Termek(temp[0], temp[1], Convert.ToUInt32(temp[2]), temp[3]);
                    aktualisTermekek[i] = tempTermek;
                }
                Console.WriteLine("Szeretne felvinni termekeket a fajlba? I/N");
                char valasz = '\0';
                while (char.TryParse(Console.ReadLine(), out valasz) == false || valasz.ToString().Trim() == "" || (valasz.ToString().ToUpper().Trim() != "I" && valasz.ToString().ToUpper().Trim() != "N"))
                {
                    Console.WriteLine("HIBA! Kerem, igennel (I) vagy nemmel (N) valaszoljon!");
                }

                if (valasz.ToString().ToUpper().Trim() == "I")
                {
                    Termek.TermekFeltolto(keszletFile);
                }
                else if (valasz.ToString().ToUpper().Trim() == "N")
                {
                    //Console.WriteLine("A program kilep! Viszont latasra!");
                    Console.WriteLine("Szeretne keresni a keszlet.csv fajlban cikkszam alapjan? (I/N)");
                    char keresesValasz = '\0';
                    while (char.TryParse(Console.ReadLine(), out keresesValasz) == false || keresesValasz.ToString().Trim() == "" || (keresesValasz.ToString().ToUpper().Trim() != "I" && keresesValasz.ToString().ToUpper().Trim() != "N"))
                    {
                        Console.WriteLine("HIBA! Kerem, igennel (I) vagy nemmel (N) valaszoljon!");
                    }
                    if (keresesValasz.ToString().ToUpper().Trim() == "I")
                    {
                        Termek.Cikkszamkereso(aktualisTermekek);
                    }
                    else if (keresesValasz.ToString().ToUpper().Trim() == "N")
                    {
                        Console.WriteLine("A program kilep! Viszontlatasra!");
                    }
                }
            }
            else
            {
                Console.WriteLine("A keresett file nem talalhato! A program letrehoz egy uj keszlet.csv fajlt!");
                Termek.TermekFeltolto($"{keszletFile}\\keszlet.csv");
            }

            Console.ReadKey();
        }
    }
}
