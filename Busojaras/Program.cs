using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busojaras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> jelentkezok = new List<string>();

            StreamReader jelentkezokReader = new StreamReader("jelentkezok.txt");
            while (!jelentkezokReader.EndOfStream)
            {
                jelentkezok.Add(jelentkezokReader.ReadLine());
            }
            jelentkezokReader.Close();

            List<string> elsoNegyvenJelentkezo = jelentkezok.GetRange(0, 40);
            elsoNegyvenJelentkezo.Sort();
            foreach (string nev in elsoNegyvenJelentkezo)
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<string> helyhianyMiattNemJohetnek = jelentkezok.GetRange(40, jelentkezok.Count - 40);
            foreach (string nev in helyhianyMiattNemJohetnek)
            {
                Console.WriteLine(nev);
            }

            List<string> bukottak = new List<string>();
            StreamReader bukottakReader = new StreamReader("bukott.txt");
            while (!bukottakReader.EndOfStream)
            {
                bukottak.Add(bukottakReader.ReadLine());
            }
            bukottakReader.Close();

            int counter = 0;
            List<string> toroltJelentkezok = new List<string>();

            for (int i = 0; i < jelentkezok.Count; i++)
            {
                if (bukottak.Contains(jelentkezok[i]))
                {
                    toroltJelentkezok.Add(jelentkezok[i]);
                    jelentkezok.RemoveAt(i);
                    counter++;
                }
            }

            Console.WriteLine($"{counter} diákot kellett utólag törölni a jelentkezők listájáról!");
            Console.WriteLine();

            StreamWriter toroltekWriter = new StreamWriter("torolt.txt");
            toroltJelentkezok.Sort();
            foreach (string nev in toroltJelentkezok)
            {
                toroltekWriter.WriteLine(nev);
            }
            toroltekWriter.Close();

            List<string> utolagBekerulok = new List<string>();
            Console.WriteLine("Utólag bekerült diákok: ");
            for (int i = 0; i < counter; i++)
            {
                if (!bukottak.Contains(helyhianyMiattNemJohetnek[i]))
                {
                    utolagBekerulok.Add(helyhianyMiattNemJohetnek[i]);
                    helyhianyMiattNemJohetnek.RemoveAt(i);
                    Console.WriteLine(helyhianyMiattNemJohetnek[i]);
                }
            }

            elsoNegyvenJelentkezo.Concat(utolagBekerulok);

            StreamWriter resztvevokWriter = new StreamWriter("resztvevok.txt");
            elsoNegyvenJelentkezo.Sort();
            foreach (string nev in elsoNegyvenJelentkezo)
            {
                resztvevokWriter.WriteLine(nev);
            }
            resztvevokWriter.Close();

            Console.Write("Kérem írja be a keresett diák nevét: ");
            string keresettDiak = Console.ReadLine();

            if (elsoNegyvenJelentkezo.Contains(keresettDiak))
            {
                Console.WriteLine("A keresett diák részt vehet a kiránduláson!");
            }
            else if (helyhianyMiattNemJohetnek.Contains(keresettDiak))
            {
                Console.WriteLine("A keresett diák helyhiány miatt nem vehet részt a kiránduláson!");
            }
            else if (bukottak.Contains(keresettDiak))
            {
                Console.WriteLine("A keresett diák bukás miatt nem vehet részt a kiránduláson!");
            }
            else
            {
                Console.WriteLine("A keresett diák nem jelentkezett a kirándulásra!");
            }

            Console.ReadKey();
        }
    }
}
