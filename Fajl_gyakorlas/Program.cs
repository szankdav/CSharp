using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajl_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int diakokSzama = 1000;
            //string[] diakokAdatai = new string[diakokSzama];
            //int diakokTombIndex = 0;
            //int diakokAdataiSzamlalo = 0;
            //StreamReader readerElsoFeladat = new StreamReader("adatok.txt", Encoding.UTF8);
            //while (!readerElsoFeladat.EndOfStream)
            //{
            //    string sor = readerElsoFeladat.ReadLine();
            //    diakokAdatai[diakokTombIndex] = sor;
            //    diakokTombIndex++;
            //}

            //for (int i = 0; i < diakokAdatai.Length; i++)
            //{
            //    if (diakokAdatai[i] != null)
            //    {
            //        Console.WriteLine(diakokAdatai[i]);
            //        diakokAdataiSzamlalo++;
            //    }
            //}
            //// ********** 1. feladat **********
            //Console.WriteLine("a. feladat: ");
            //Console.WriteLine();
            //Console.WriteLine($"\t{diakokAdataiSzamlalo} diák adatai kerültek rögzítésre!");
            //Console.WriteLine();
            //Console.WriteLine("b. feladat: ");
            //Console.WriteLine("\tKérem írja be a keresett évszámot: ");
            //int evszam;
            //while (!int.TryParse(Console.ReadLine(), out evszam))
            //{
            //    Console.WriteLine("\tHibás adat!");
            //    Console.WriteLine("\tKérem írja be a keresett évszámot: ");
            //}
            //int diakSzamlaloEvszamAlapjan = 0;
            //foreach (string diakAdat in diakokAdatai)
            //{
            //    if (diakAdat != null && diakAdat.Contains(evszam.ToString()))
            //    {
            //        diakSzamlaloEvszamAlapjan++;
            //    }
            //}

            //if (diakSzamlaloEvszamAlapjan > 0)
            //{
            //    Console.WriteLine($"Összesen {diakSzamlaloEvszamAlapjan} diák kezdte meg {evszam} évben az iskolát!");
            //}
            //else
            //{
            //    Console.WriteLine("Ebben az évben nem kezdte meg egy diák sem az iskolát.");
            //}

            //Console.WriteLine("c. feladat: ");
            //Console.WriteLine("\tKérem írja be a keresett nevet: ");
            //string keresettNev = Console.ReadLine();
            //int keresettNevIndex = 0;
            //bool voltDiakIlyenNevvel = false;
            //while (keresettNevIndex < diakokAdataiSzamlalo)
            //{
            //    if (diakokAdatai[keresettNevIndex].Contains(keresettNev))
            //    {
            //        Console.WriteLine($"Iskolakezdés éve: {diakokAdatai[keresettNevIndex].Substring(0, 4)}");
            //        Console.WriteLine($"Osztály betűjele: {diakokAdatai[keresettNevIndex].Substring(5, 1)}");
            //        voltDiakIlyenNevvel = true;
            //    }
            //    keresettNevIndex++;
            //}

            //if (!voltDiakIlyenNevvel)
            //{
            //    Console.WriteLine("A keresett névvel nem található diákadat!");
            //}


            //Console.WriteLine("d. feladat: ");
            //Console.WriteLine("Kérem adja meg a keresett névrészletet: ");
            //string nevReszlet = Console.ReadLine();
            //int nevReszletIndex = 0;
            //bool voltDiakIlyenNevReszlettel = false;
            //while (nevReszletIndex < diakokAdataiSzamlalo)
            //{
            //    if (diakokAdatai[nevReszletIndex].Substring(7).ToLower().Contains(nevReszlet.ToLower()))
            //    {
            //        Console.WriteLine($"Név: {diakokAdatai[nevReszletIndex].Substring(7)}");
            //        Console.WriteLine($"Iskolakezdés éve: {diakokAdatai[nevReszletIndex].Substring(0, 4)}");
            //        Console.WriteLine($"Osztály betűjele: {diakokAdatai[nevReszletIndex].Substring(5, 1)}");
            //        voltDiakIlyenNevReszlettel = true;
            //    }
            //    nevReszletIndex++;
            //}

            //if (!voltDiakIlyenNevReszlettel)
            //{
            //    Console.WriteLine("A keresett név részlettel nem található diákadat!");
            //}
            //Console.WriteLine();

            //Console.WriteLine("e. feladat: ");
            //int leghosszabbNeviDiakIndexe = 0;
            //for (int i = 1; i < diakokAdataiSzamlalo; i++)
            //{
            //    if (diakokAdatai[leghosszabbNeviDiakIndexe].Substring(7).Length < diakokAdatai[i].Substring(7).Length)
            //    {
            //        leghosszabbNeviDiakIndexe = i;
            //    }
            //}
            //Console.WriteLine("A leghosszabb nevű diák adatai:");
            //Console.WriteLine($"\tNév: {diakokAdatai[leghosszabbNeviDiakIndexe].Substring(7)}");
            //Console.WriteLine($"\tKezdés éve: {diakokAdatai[leghosszabbNeviDiakIndexe].Substring(0, 4)}");
            //Console.WriteLine($"\tOsztály: {diakokAdatai[leghosszabbNeviDiakIndexe].Substring(5, 1)}");
            //Console.WriteLine();

            //Console.WriteLine("f. feladat: ");
            //string path = "C:\\Users\\TUF Gaming\\source\\repos\\Fajl_gyakorlas\\bin\\Debug\\nevsor.txt";
            //StreamWriter writer = new StreamWriter(path);

            //for (int i = 0; i < diakokAdataiSzamlalo; i++)
            //{
            //    writer.WriteLine(diakokAdatai[i].Substring(7));
            //    writer.Flush();
            //}
            //writer.Close();

            // ********** 2. feladat **********
            //int versenyzokSzama = 100;
            //string[] versenyzok = new string[versenyzokSzama];
            //int versenyzokTombIndex = 0;

            //StreamReader readerMasodikFeladat = new StreamReader("pontszamok.txt", Encoding.UTF8);
            //while (!readerMasodikFeladat.EndOfStream)
            //{
            //    versenyzok[versenyzokTombIndex] = readerMasodikFeladat.ReadLine();
            //    versenyzokTombIndex++;
            //}
            //readerMasodikFeladat.Close();

            //Console.WriteLine("a. feladat:");
            //for (int i = 0; i < versenyzokTombIndex; i++)
            //{
            //    Console.Write($"\t{(i == 0 ? versenyzok[0] : i % 2 != 0 ? versenyzok[i] + Environment.NewLine : versenyzok[i])}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("b. feladat");
            //Console.WriteLine($"A fájl {versenyzokTombIndex / 2} versenyző adatait tartalmazza.");
            //Console.WriteLine();

            //Console.WriteLine("c. feladat");
            //int legkisebbPontszamIndex = 1;
            //int legnagyobbPontszamIndex = 1;

            //for (int i = 2; i < versenyzokTombIndex; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        if (int.Parse(versenyzok[i]) > int.Parse(versenyzok[legnagyobbPontszamIndex]))
            //        {
            //            legnagyobbPontszamIndex = i;
            //        }

            //        if (int.Parse(versenyzok[i]) < int.Parse(versenyzok[legkisebbPontszamIndex]))
            //        {
            //            legkisebbPontszamIndex = i;
            //        }
            //    }
            //}

            //Console.WriteLine($"\tA legkisebb elért pontszám: {versenyzok[legkisebbPontszamIndex]}");
            //Console.WriteLine($"\tA legnagyobb elért pontszám: {versenyzok[legnagyobbPontszamIndex]}");
            //Console.WriteLine();

            //Console.WriteLine("d. feladat");
            //double osszPontszam = 0;

            //for (int i = 1; i < versenyzokTombIndex; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        osszPontszam += int.Parse(versenyzok[i]);
            //    }
            //}

            //Console.WriteLine($"A versenyzők átlagos pontszáma: {(osszPontszam / (versenyzokTombIndex / 2)).ToString("0.00")}");
            //Console.WriteLine();

            //Console.WriteLine("e. feladat");
            //Console.WriteLine("\tKérem adja meg a keresett versenyző nevét: ");
            //string keresettVersenyzoNeve = Console.ReadLine();
            //bool keresettVersenyzoTalalat = false;

            //for (int i = 0; i < versenyzokTombIndex; i++)
            //{
            //    if (i == 0 && versenyzok[i].Contains(keresettVersenyzoNeve.Trim().ToLower()))
            //    {
            //        Console.WriteLine($"\tA keresett versenyző: {versenyzok[i]}, megtalálható a döntősök között, elért pontszáma: {versenyzok[i + 1]}");
            //        keresettVersenyzoTalalat = true;
            //    }
            //    else if(i % 2 == 0 && versenyzok[i].Trim().ToLower().Contains(keresettVersenyzoNeve.Trim().ToLower()))
            //    {
            //        Console.WriteLine($"\tA keresett versenyző: {versenyzok[i]}, megtalálható a döntősök között, elért pontszáma: {versenyzok[i + 1]}");
            //        keresettVersenyzoTalalat = true;
            //    }
            //}

            //if (!keresettVersenyzoTalalat)
            //{
            //    Console.WriteLine("\tA megadott névvel nem található versenyző!");
            //}

            // ********** 3.feladat **********
            StreamReader readerHarmadikFeladat = new StreamReader("felveteli.csv");
            string[,] felvetelizoDiakok = new string[96,3];
            int felvetelizoDiakokTombIndex = 0;
            int felvetelizoDiakAdataiIndex = 0;

            while (!readerHarmadikFeladat.EndOfStream)
            {
                string[] csvSor = readerHarmadikFeladat.ReadLine().Split(';');
                felvetelizoDiakok[felvetelizoDiakokTombIndex, felvetelizoDiakAdataiIndex] = csvSor[0].Trim();
                felvetelizoDiakAdataiIndex++;
                felvetelizoDiakok[felvetelizoDiakokTombIndex, felvetelizoDiakAdataiIndex] = csvSor[1].Trim();
                felvetelizoDiakAdataiIndex++;
                felvetelizoDiakok[felvetelizoDiakokTombIndex, felvetelizoDiakAdataiIndex] = csvSor[2].Trim();
                felvetelizoDiakAdataiIndex = 0;
                felvetelizoDiakokTombIndex++;
            }
            readerHarmadikFeladat.Close();

            Console.WriteLine("a. feladat");
            Console.WriteLine("\tNév\tHozott pontszám\tElért pontszám");
            for (int i = 0; i < felvetelizoDiakokTombIndex; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int aktualisDiakOsszpontszama = int.Parse(felvetelizoDiakok[i, 1]) + int.Parse(felvetelizoDiakok[i, 2]);
                    Console.Write($"\t{felvetelizoDiakok[i, j]}");
                    if (j == 2)
                    {
                        Console.Write($" összpontszám: {aktualisDiakOsszpontszama}");
                        Console.Write(Environment.NewLine);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("b. feladat");
            int legnagyobbOsszpontSzamuDiakIndex = 0;
            for (int i = 1; i < felvetelizoDiakokTombIndex; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((int.Parse(felvetelizoDiakok[i, 1]) + int.Parse(felvetelizoDiakok[i, 2])) > int.Parse(felvetelizoDiakok[legnagyobbOsszpontSzamuDiakIndex, 1]) + int.Parse(felvetelizoDiakok[legnagyobbOsszpontSzamuDiakIndex, 2]))
                    {
                        legnagyobbOsszpontSzamuDiakIndex = i;
                    }
                }
            }
            Console.WriteLine($"A legnagyobb összpontszámú diák neve: {felvetelizoDiakok[legnagyobbOsszpontSzamuDiakIndex, 0]}, összpontszáma: {int.Parse(felvetelizoDiakok[legnagyobbOsszpontSzamuDiakIndex, 1]) + int.Parse(felvetelizoDiakok[legnagyobbOsszpontSzamuDiakIndex, 2])}");

            Console.WriteLine("c. feladat");
            double atlagOsszPontszam = 0;

            for (int i = 0; i < felvetelizoDiakokTombIndex; i++)
            {
                atlagOsszPontszam += double.Parse(felvetelizoDiakok[i, 1]) + double.Parse(felvetelizoDiakok[i, 2]);
            }

            Console.WriteLine($"A diákok átlagos összpontszáma: {Math.Round(atlagOsszPontszam / felvetelizoDiakokTombIndex, 1)}");


            Console.WriteLine("d. feladat");
            Console.WriteLine("Kérem írja be a keresett diák nevét: ");
            string keresettDiak = Console.ReadLine();
            bool vanDiak = false;
            int index = 0;
            while (vanDiak != true && index < felvetelizoDiakokTombIndex)
            {
                if (felvetelizoDiakok[index, 0].ToLower() == keresettDiak.ToLower())
                {
                    vanDiak = true;
                }
                index++;
            }

            if (vanDiak)
            {
                Console.WriteLine($"A keresett diák pontszámai: hozott: {felvetelizoDiakok[index, 1]}, szerzett: {felvetelizoDiakok[index, 2]}");
            }
            else
            {
                Console.WriteLine("A keresett névvel nem található diák!");
            }

            StreamWriter osszpontokWriter = new StreamWriter("osszpontok.csv");
            osszpontokWriter.WriteLine($"A fájl {felvetelizoDiakokTombIndex} diák adatait tartalmazza.");
            for (int i = 0; i < felvetelizoDiakokTombIndex; i++)
            {
                osszpontokWriter.WriteLine($"{felvetelizoDiakok[i, 0]};{felvetelizoDiakok[i, 1]};{felvetelizoDiakok[i,2]}");
            }
            osszpontokWriter.Close();


            Console.ReadKey();
        }
    }
}
