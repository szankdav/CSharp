using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearisKeresesDelegateGenerikus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Kivalasztas*********");
            int[] szamok = { 10, 4, 5, 2, 100, 7, 9 };
            List<string> szovegek = new List<string>() { "asd", "QWERTY", "d sa", "Valami mas", " abc " };
            HashSet<DateTime> datumok = new HashSet<DateTime>();
            datumok.Add(DateTime.Now);
            datumok.Add(DateTime.Parse("1997.05.01"));
            datumok.Add(DateTime.Parse("1900.01.01"));

            Console.Write("Az elso olyan szam, ami nagyobb mint 10 es paros: ");
            Console.WriteLine(ProgTetelGenerikus.Kivalasztas(szamok, x => x > 10 && x % 2 == 0)); //LINQ beepitett metodus
            Console.Write("Az elso olyan szoveg, ami csupa nagy betu: ");
            Console.WriteLine(ProgTetelGenerikus.Kivalasztas(szovegek, x => x.ToUpper() == x));
            Console.Write("Az elso olyan datum, ami nem a mai napra esik: ");
            Console.WriteLine(ProgTetelGenerikus.Kivalasztas(datumok, x => x.Date != DateTime.Now.Date));

            Console.WriteLine("******Kivalogatas*********");

            Console.WriteLine("Az osszes olyan szam, ami nagyobb mint 9: ");
            var szamokEredmeny = ProgTetelGenerikus.Kivalogatas(szamok, x => x > 9); //LINQ beepitett metodus
            foreach (var item in szamokEredmeny)
            {
                Console.WriteLine($"\t- {item}");
            }

            Console.WriteLine("Az osszes olyan szo, ami pontosan harom karakter: ");
            var szovegekEredmeny = ProgTetelGenerikus.Kivalogatas(szovegek, x => x.Trim().Length == 3);
            foreach (var item in szovegekEredmeny)
            {
                Console.WriteLine($"\t- {item.Trim()}");
            }

            Console.WriteLine("Az osszes olyan datum, ami nem egyenlo a mai datummal: ");
            var datumokEredmeny = ProgTetelGenerikus.Kivalogatas(datumok, x => x.Date != DateTime.Now.Date);
            foreach (var item in datumokEredmeny)
            {
                Console.WriteLine($"\t- {item.ToShortDateString()}");
                Console.WriteLine($"\t- {item.Date}"); // ---> Lenullazza az orat
            }

            Console.WriteLine("******Egyszeru cseres rendezes*********");
            ProgTetelGenerikus.EgyszeruCseresRendezes(szamok);
            ProgTetelGenerikus.EgyszeruCseresRendezes(szovegek);
            //ProgTetelGenerikus.EgyszeruCseresRendezes(datumok); Nem tudjuk kezelni, mert IList-be kenyszeritettuk az alprogram parametert, ezert a HashSet nem feldolgozhato
            Console.WriteLine();
            Console.WriteLine("A szamok a rendezes utan: ");
            foreach (var item in szamok)
            {
                Console.WriteLine($"\t- {item}");
            }

            Console.WriteLine();
            Console.WriteLine("A szovegek a rendezes utan: ");
            foreach (var item in szovegek)
            {
                Console.WriteLine($"\t- {item.Trim()}");
            }

            Console.ReadKey();
        }
    }
}
