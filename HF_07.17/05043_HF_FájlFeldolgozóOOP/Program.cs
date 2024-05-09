using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05043_HF_FájlFeldolgozóOOP
{
    internal class Program
    {
        //"Készítsünk programot, mely egy alapvető fájl feldolgozást tud elvégezni.
        //Képes egy megadott útvonalon lévő mappából felolvasni a fájlok adatait.
        //A fájlokról tárolandó adatok: név, módosítás dátuma, méret.
        //Ezeket az adatokat a program legyen képes megjeleníteni a következő formátumban a Console-on:
        //Név – módosítás dátuma – méret.
        //A program a kilépés előtt kérdezze meg, hogy el szeretné-e menteni a felhasználó az adatokat, amennyiben igen, CSV formátumban mentse el maga mellé a mappa neve és az adott dátum szerinti néven.
        //<dátum>_<mappa>.csv"

        static void Main(string[] args)
        {
            Console.WriteLine("Kerem, adja meg a feldolgozni kivant mappa eleresi utvonalat:");
            string eleresiUtvonal = Console.ReadLine();

            if (Directory.Exists(eleresiUtvonal))
            {
                string[] mappaFileok = Directory.GetFiles(eleresiUtvonal);
                FileClass[] fajlok = new FileClass[mappaFileok.Length];
                for (int i = 0; i < mappaFileok.Length; i++)
                {
                    FileInfo fileInfo = new FileInfo(mappaFileok[i]);
                    fajlok[i] = new FileClass(Path.GetFileName(mappaFileok[i]), File.GetLastWriteTime(mappaFileok[i]), fileInfo.Length);
                }
                Console.WriteLine("Nev - modositas datuma - meret");
                for (int i = 0; i < fajlok.Length; i++)
                {
                    Console.WriteLine($"{fajlok[i].FileNev} - {fajlok[i].ModositasDatuma} - {fajlok[i].FileMeret} KB");
                }
                Console.WriteLine("Szeretne elmenteni az adatok egy .csv kiterjesztesu fajlba? (I/N)");
                char valasz = '\0';
                while (char.TryParse(Console.ReadLine(), out valasz) == false || valasz.ToString().Trim() == "" || (valasz.ToString().ToUpper().Trim() != "I" && valasz.ToString().ToUpper().Trim() != "N"))
                {
                    Console.WriteLine("HIBA! Kerem igennel (I) vagy nemmel (N) valaszoljon!");
                }
                DirectoryInfo directory = new DirectoryInfo(eleresiUtvonal);
                string mentettFileNev = $"{DateTime.Now.ToString("yyyy-MM-dd")}_{directory.Name}.csv";
                if (valasz.ToString().ToUpper().Trim() == "I")
                {
                    StreamWriter mentettFile = new StreamWriter(mentettFileNev, false, Encoding.UTF8);
                    mentettFile.WriteLine("Nev;modositas datuma;meret");
                    for (int i = 0; i < fajlok.Length; i++)
                    {
                        mentettFile.WriteLine($"{fajlok[i].FileNev};{fajlok[i].ModositasDatuma};{fajlok[i].FileMeret} KB");
                        mentettFile.Flush();
                    }
                    mentettFile.Close();
                    Console.WriteLine("A mentes sikeres! A program kilep!");
                }
                else if (valasz.ToString().ToUpper().Trim() == "N")
                {
                    Console.WriteLine("A program kilep! Viszontlatasra!");
                }
            }
            else
            {
                Console.WriteLine("HIBA! A megadott eleresi utvonallal nem letezik mappa!");
            }
            Console.ReadKey();
        }
    }
}
