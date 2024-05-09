using System.Collections.Immutable;
using System.Threading.Channels;

namespace snooker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();

            StreamReader versenyzokReader = new StreamReader("snooker.txt");
            string[] fejlecNevek = versenyzokReader.ReadLine().Split(';');
            while (!versenyzokReader.EndOfStream)
            {
                string[] versenyzoAdatok = versenyzokReader.ReadLine().Split(';');
                versenyzok.Add(new Versenyzo(int.Parse(versenyzoAdatok[0]), versenyzoAdatok[1], versenyzoAdatok[2], int.Parse(versenyzoAdatok[3])));
            }

            Console.WriteLine($"2. feladat: A világranglistán {versenyzok.Count} versenyző szerepel.");
            Console.WriteLine($" 3.feladat: Az első helyen áll:");
            Versenyzo elsoVersenyo = versenyzok.Find(x => x.Helyezes == 1);
            Console.WriteLine($"\tNév: {elsoVersenyo.Nev}");
            Console.WriteLine($"\tOrszág: {elsoVersenyo.Orszag}");
            Console.WriteLine($"\tNyeremény: {elsoVersenyo.Nyeremeny} font");
            Console.WriteLine($"4. feladat: A versenyzők átlagosan {versenyzok.Average(x => x.Nyeremeny).ToString("0.00")} fontot kerestek");
            Console.WriteLine($"5. feladat: {versenyzok.FindAll(x => x.Orszag != "Anglia").Count} versenyző nem Anglia színeiben indul.");
            Console.WriteLine($" 6.feladat: A legjobban kereső kínai versenyző:");
            Versenyzo legjobbanKeresoKinaiJatekos = versenyzok.FindAll(x => x.Orszag == "Kína").MaxBy(y => y.Nyeremeny);
            Console.WriteLine($"\tHelyezés: {legjobbanKeresoKinaiJatekos.Helyezes}");
            Console.WriteLine($"\tNév: {legjobbanKeresoKinaiJatekos.Nev}");
            Console.WriteLine($"\tNyeremény összege: {legjobbanKeresoKinaiJatekos.Nyeremeny * 380} Ft");
            Console.Write($"7. feladat: A versenyző országa: ");
            string keresettOrszag = Console.ReadLine();
            Console.WriteLine($"\t{(versenyzok.Find(x => x.Orszag == keresettOrszag) != null ? $"Van {keresettOrszag} színeiben induló versenyző." : $"Nincs {keresettOrszag} színeiben induló versenyző!")}");
            Console.WriteLine("8. feladat: A 3 legelőkelőbb helyen álló angol versenyző:");
            List<Versenyzo> legjobbHaromAngliaiVersenyzo = versenyzok.FindAll(x => x.Orszag == "Anglia").OrderBy(y => y.Helyezes).Take(3).ToList();
            Console.WriteLine($"\t{legjobbHaromAngliaiVersenyzo[0].Helyezes}. {legjobbHaromAngliaiVersenyzo[0].Nev}");
            Console.WriteLine($"\t{legjobbHaromAngliaiVersenyzo[1].Helyezes}. {legjobbHaromAngliaiVersenyzo[1].Nev}");
            Console.WriteLine($"\t{legjobbHaromAngliaiVersenyzo[2].Helyezes}. {legjobbHaromAngliaiVersenyzo[2].Nev}");
            List<string> orszagok = versenyzok.GroupBy(x => x.Orszag).Select(y => y.Key).ToList();
            orszagok.Sort();
            Console.Write($"9. feladat: Az országok nevei: ");
            for (int i = 0; i < orszagok.Count; i++)
            {
                if (i < orszagok.Count - 1)
                {
                    Console.Write($"{orszagok[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{orszagok[i]}");
                }
            }
            List<string> skociaiVersenyzok = versenyzok.FindAll(x => x.Orszag == "Skócia").Select(y => y.Nev).ToList();
            Console.Write($"10.feladat: Skócia színeiben induló versenyzők: ");
            for (int i = 0; i < skociaiVersenyzok.Count; i++)
            {
                if (i < skociaiVersenyzok.Count - 1)
                {
                    Console.Write($"{skociaiVersenyzok[i]}, ");
                }
                else
                {
                    Console.Write($"{skociaiVersenyzok[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}
