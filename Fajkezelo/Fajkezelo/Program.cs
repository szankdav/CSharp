using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajkezelo
{
    //Készítsünk programot, mely a következő opciókat
    //szolgáltatja a felhasználónak:
    //„C” billentyűre bekér 2 elérést egyszerre, és átmásolja az
    //egyiket a másik helyre
    //„O” billentyűre bekér 1 fájlnevet és megadja a tartalmát.
    //„S” billentyűre bekér egy szöveget, majd egy fájlnevet, és
    //lementi a szöveget az adott helyre.
    //„E” billentyűre kilép.
    internal class Program
    {
        static void Main(string[] args)
        {
            char muvelet;
            do
            {
                KezdoKepernyo();
                muvelet = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (muvelet.ToString().ToLower())
                {
                    // Masolas
                    case "c":
                        string forras;
                        string cel;
                        // Forras
                        do
                        {
                            Console.WriteLine("Kerem, adja meg a forrast!");
                            forras = Console.ReadLine().Trim();
                        } while (!File.Exists(forras));
                        // Cel
                        do
                        {
                            Console.WriteLine("Kerem, adja meg a celt!");
                            cel = Console.ReadLine().Trim();
                        } while (!Directory.Exists(cel));
                        // forras = C:\Teszt\Proba.txt
                        // cel = C:\Teszt2\
                        int index = forras.LastIndexOf('\\');
                        cel = $"{cel}{forras.Substring(index)}";
                        File.Copy(forras, cel, true);
                        Console.WriteLine("Fajl masolasa megtortent!");
                        Console.ReadKey();
                        break;
                    // Tartalom
                    case "o":
                        string felolvasandoFile;
                        do
                        {
                            Console.WriteLine("Kerem, adja meg a felolvasando fajlt!");
                            felolvasandoFile = Console.ReadLine().Trim();
                        } while (!File.Exists(felolvasandoFile));
                        Console.WriteLine(File.ReadAllText(felolvasandoFile));
                        Console.ReadKey();
                        break;
                    // Mentes
                    case "s":
                        string cel2;
                        string utvonal;
                        do
                        {
                            Console.WriteLine("Kerem, adja meg a celt!");
                            cel2 = Console.ReadLine().Trim();
                            int index2 = cel2.LastIndexOf("\\");
                            utvonal = cel2.Substring(0, index2);
                        } while (!Directory.Exists(utvonal));
                        Console.WriteLine("Kerem, adja meg a szoveget!");
                        File.WriteAllText(cel2, Console.ReadLine());
                        Console.WriteLine("Fajl mentese megtortent!");
                        Console.ReadKey();
                        break;
                    // Kilepes
                    case "e":
                        Console.WriteLine("Viszont latasra!");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Kerem, helyes erteket adjon meg!");
                        Console.ReadKey();
                        break;
                }

            } while (muvelet.ToString().ToLower() != "e");
        }

        static void KezdoKepernyo()
        {
            Console.Clear();
            Console.WriteLine("Kerem, adja meg, hogy milyen muveletet szeretne vegrahajtani!");
            Console.WriteLine("C billentyűre bekér 2 elérést egyszerre, és átmásolja az egyiket a másik helyre");
            Console.WriteLine("O billentyűre bekér 1 fájlnevet és megadja a tartalmát");
            Console.WriteLine("S billentyűre bekér egy szöveget, majd egy fájlnevet, és lementi a szöveget az adott helyre");
            Console.WriteLine("E billentyűre kilép");
        }
    }
}
