using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04037_OF_Emberek
{
    internal class Program
    {

        struct nev
        {
            public string vezetekNev;
            public string keresztNev;
        }

        struct szuletesiDatum
        {
            public string ev;
            public string honap;
            public string nap;
        }
        static void Main(string[] args)
        {
            //A következő feladat, az eddigiekben megtanultak alapján elkészíthető.
            //Készítsen programot, mely induláskor neveket, születési dátumokat és születési helyeket kér be.
            //A program ezután hozzon létre egy CSV dokumentumot a program mellett, melyben a következő oszlopok vannak:
            //Vezeték név, Kereszt név, Születési év, Hónap, Nap, Születési hely
            //A program erre egy bool visszatérésű funkciót használjon, mely 3 tömböt vár(vagy egy struktúra típusú tömböt) a bemenetén és a többit elvégzi maga."

            Console.WriteLine("Kerem, adja meg hany sort szeretne felvinni, majd irja be az adatokat!");
            int adatokSzama;
            while (int.TryParse(Console.ReadLine(), out adatokSzama) == false && adatokSzama < 1)
            {
                Console.WriteLine("Kerem, helyes adatot adjon meg!");
            }

            nev[] nevek = new nev[adatokSzama];
            szuletesiDatum[] szulDatumok = new szuletesiDatum[adatokSzama];
            string[] szuletesiHelyek = new string[adatokSzama];
            int j = 0;
            do
            {
                string aktualisNev;
                do
                {
                    Console.WriteLine($"Kerem, adja meg a(z) {j + 1}. nevet:");
                    aktualisNev = Console.ReadLine().Trim();
                    string[] aktualisVezetekKeresztNev = aktualisNev.Trim().Split(' ');
                    if (aktualisNev.Length >= 2)
                    {
                        nevek[j].vezetekNev = aktualisVezetekKeresztNev[0];
                        nevek[j].keresztNev = aktualisVezetekKeresztNev[1];
                    }
                } while (aktualisNev.Split(' ').Length < 2);

                string aktualisSzulDatum;
                do
                {
                    Console.WriteLine($"Kerem, adja meg a(z) {j + 1}. szuletesi datumot! Kerem, YYYY.MM.DD formatumot hasznaljon!");
                    aktualisSzulDatum = Console.ReadLine().Trim();
                    string[] aktualisSzulEvHonapNap = aktualisSzulDatum.Trim().Split('.');
                    if (aktualisSzulEvHonapNap.Length == 3)
                    {
                        szulDatumok[j].ev = aktualisSzulEvHonapNap[0];
                        szulDatumok[j].honap = aktualisSzulEvHonapNap[1];
                        szulDatumok[j].nap = aktualisSzulEvHonapNap[2];
                    }
                } while (aktualisSzulDatum.Trim().Split('.').Length != 3);

                string aktualisSzulHely;
                do
                {
                    Console.WriteLine($"Kerem, adja meg a(z) {j + 1}. szuletesi helyet!");
                    aktualisSzulHely = Console.ReadLine().Trim();
                    if (aktualisSzulHely != "")
                    {
                        szuletesiHelyek[j] = aktualisSzulHely;
                    }
                } while (aktualisSzulHely == "");

                j++;
            } while (j <= adatokSzama - 1);

            if (DokumentumKeszito(nevek, szulDatumok, szuletesiHelyek))
            {
                Console.WriteLine("A fajl letrehozasa sikeres!");
            }
            else
            {
                Console.WriteLine("A file letrehozasa nem sikerult!");
            }

            Console.ReadKey();
        }

        static bool DokumentumKeszito(nev[] nevek, szuletesiDatum[] szulDatumok, string[] szuletesiHelyek)
        {
            StreamWriter file = new StreamWriter("adatok.csv", false, Encoding.UTF8);
            file.WriteLine("Vezeték név;Kereszt név;Születési év;Születési hónap;Születési nap;Születési hely");
            for (int i = 0; i < nevek.Length; i++)
            {
                file.WriteLine($"{nevek[i].vezetekNev};{nevek[i].keresztNev};{szulDatumok[i].ev};{szulDatumok[i].honap};{szulDatumok[i].nap};{szuletesiHelyek[i]}");
                file.Flush();
            }
            file.Close();

            bool success = false;

            if (File.Exists("adatok.csv"))
            {
                success = true;
            }

            return success;
        }
    }
}
