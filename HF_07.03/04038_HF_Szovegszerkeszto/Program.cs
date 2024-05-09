using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04038_HF_Szovegszerkeszto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Készítsünk programot, mely egy alapszintű szövegszerkesztőt takar
            //A program indításkor kérjen be egy fájlnevet, ami ha létezik, nyissa meg, ha nem, hozza létre.
            //A felhasználó innentől kezdve tud gépelni, akár több sort is.
            //Amint a sor értéke pontosan az, hogy „vége”, lezárja a fájlt, és megkérdezi a felhasználót, hogy szeretne - e másik fájlt szerkeszteni(i / n), amennyiben a válasz „i” akkor előröl kezdi a működését, különben kilép."

            string fajl;
            char valasz = 'I';

            do
            {
                Console.WriteLine("Kerem, adja meg a szerkesztendo fajl nevet!");

                fajl = Console.ReadLine().Trim();

                if (File.Exists(fajl))
                {
                    StreamWriter letezoFajl = new StreamWriter(fajl, true, Encoding.UTF8);
                    string menteniKivantSor = string.Empty;
                    Console.WriteLine("Kerem, irja be a menteni kivant szoveget! A fajlt a 'vege' szoval tudja lezarni!");
                    do
                    {
                        menteniKivantSor = Console.ReadLine().Trim();
                        if (menteniKivantSor != "vege")
                        {
                            letezoFajl.WriteLine(menteniKivantSor);
                            letezoFajl.Flush();
                        }
                    } while (menteniKivantSor != "vege");
                    letezoFajl.Close();
                    valasz = TovabbiFajlSzerkesztes();
                }
                else if (!File.Exists(fajl))
                {
                    StreamWriter nemLetezoFajl = new StreamWriter(fajl, true, Encoding.UTF8);
                    Console.WriteLine("Kerem, irja be a menteni kivant szoveget! A fajlt a 'vege' szoval tudja lezarni!");
                    string menteniKivantSor = string.Empty;
                    do
                    {
                        menteniKivantSor = Console.ReadLine().Trim();
                        if (menteniKivantSor != "vege")
                        {
                            nemLetezoFajl.WriteLine(menteniKivantSor);
                            nemLetezoFajl.Flush();
                        }
                    } while (menteniKivantSor != "vege");
                    nemLetezoFajl.Close();
                    valasz = TovabbiFajlSzerkesztes();
                }
            } while (valasz.ToString().Trim().ToUpper() == "I" && valasz.ToString().Trim().ToUpper() != "N");

            Console.WriteLine("A program kilep! Viszont latasra!");

            Console.ReadKey();

        }

        static char TovabbiFajlSzerkesztes()
        {
            char valaszEllenorzes = '\0';
            do
            {
                Console.WriteLine("Szeretne masik fajlt szerkeszteni? I/N");
                valaszEllenorzes = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (valaszEllenorzes.ToString().Trim() == "" || (valaszEllenorzes.ToString().ToUpper() != "I" && valaszEllenorzes.ToString().ToUpper() != "N"))
                {
                    Console.WriteLine("Kerem, I vagy N valaszt adjon!");
                }
            } while (valaszEllenorzes.ToString().Trim() == "" || (valaszEllenorzes.ToString().ToUpper() != "I" && valaszEllenorzes.ToString().ToUpper() != "N"));

            return valaszEllenorzes;
        }
    }
}
