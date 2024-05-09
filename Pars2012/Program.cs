using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Pars2012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            StreamReader versenyzoReader = new StreamReader("Selejtezo2012.txt");
            string elsoSor = versenyzoReader.ReadLine();
            while (!versenyzoReader.EndOfStream)
            {
                string[] adatok = versenyzoReader.ReadLine().Split(";");
                versenyzok.Add(new Versenyzo(adatok[0], char.Parse(adatok[1]), adatok[2], adatok[3] == "X" ? -1.0 : adatok[3] == "-" ? -2.0 : float.Parse(adatok[3]), adatok[4] == "X" ? -1.0 : adatok[4] == "-" ? -2.0 : float.Parse(adatok[4]), adatok[5] == "X" ? -1.0 : adatok[5] == "-" ? -2.0 : float.Parse(adatok[5])));
            }
            versenyzoReader.Close();

            Console.WriteLine("4. feladat: ");
            Console.WriteLine($"Az állomány {versenyzok.Count} versenyző adatait tartalmazza!");
            Console.WriteLine("5. feladat: ");
            Console.WriteLine($"A döntőbe automatikusan továbbjutók száma: {versenyzok.FindAll(x => x.D1 > 78 || x.D2 > 78).Count}");
            Console.WriteLine("6. feladat: ");
            Console.WriteLine("Függvény létrehozva!");
            double Eredmeny(Versenyzo versenyzo)
            {
                double[] versenyoDobasai = { versenyzo.D1, versenyzo.D2, versenyzo.D3 };
                return versenyoDobasai.Max();
            }
            Console.WriteLine("7. feladat: ");
            double atlagPontszam = 0;
            versenyzok.ForEach(x => atlagPontszam += Eredmeny(x));
            Console.WriteLine($"A versenyzők átlagpontszáma: {Math.Round(atlagPontszam / versenyzok.Count, 3)}");
            Console.WriteLine("8. feladat: ");
            Versenyzo maxDobas = versenyzok.MaxBy(x => Eredmeny(x));
            Console.WriteLine($"A legnagyobb dobást elérő atléta adatai: ");
            Console.WriteLine($"\tNév: {maxDobas.Nev}");
            Console.WriteLine($"\tCsoport: {maxDobas.Csoport}");
            Console.WriteLine($"\tNemzet és országkód: {maxDobas.NemzetEsKod}");
            Console.WriteLine($"\tElső dobás: {maxDobas.D1}");
            Console.WriteLine($"\tMásodik dobás: {maxDobas.D2}");
            Console.WriteLine($"\tHarmadik dobás: {maxDobas.D3}");
            Console.WriteLine("9. feladat: ");
            List<string> orszagok = versenyzok.GroupBy(y => y.NemzetEsKod).Select(x => x.Key).ToList();
            Console.WriteLine("A részt vevő országok nevei: ");
            orszagok.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("10. feladat: ");
            StreamWriter dontosWriter = new StreamWriter("Dontos2012.txt");
            dontosWriter.WriteLine(elsoSor);
            for (int i = 0; i < 12; i++)
            {
                Versenyzo legjobbEredmenyuVersenyzo = versenyzok.MaxBy(x => Eredmeny(x));
                dontosWriter.WriteLine($"{legjobbEredmenyuVersenyzo.Nev};{legjobbEredmenyuVersenyzo.Csoport};{legjobbEredmenyuVersenyzo.NemzetEsKod};{legjobbEredmenyuVersenyzo.D1};{legjobbEredmenyuVersenyzo.D2};{legjobbEredmenyuVersenyzo.D3}");
                versenyzok.Remove(legjobbEredmenyuVersenyzo);
            }
            dontosWriter.Close();
            Console.WriteLine("A fájlba írás megtörtént!");
            Console.WriteLine("11. feladat: ");
            var or = versenyzok.GroupBy(x => x.NemzetEsKod).Select(x => x.ToList()).ToList();
            foreach (var item in or)
            {
                foreach (var orItem in item)
                {
                    Console.WriteLine(orItem);
                }
            }
            foreach (Versenyzo versenyzo in versenyzok)
            {
                Console.WriteLine(versenyzo.NemzetEsKod);
                Console.WriteLine(versenyzo.Nev);
                Console.WriteLine(versenyzo.Csoport);
                Console.WriteLine(versenyzo.D1);
                Console.WriteLine(versenyzo.D2);
                Console.WriteLine(versenyzo.D3);
            }

            Console.ReadKey();
        }

        public record Versenyzo 
        (
            string Nev,
            char Csoport,
            string NemzetEsKod,
            double D1,
            double D2,
            double D3
        );
    }
}
