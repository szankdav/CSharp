using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirkaVadasz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palya.JatekInditas(new Size(20, 20), 6);
            do
            {
                PalyaKirajzolas();
                Point loves = LovesAdatokBekerese(new Size(3, 2));
                Palya.Loves(loves);
            } while (Palya.Allapot == JatekAllapot.Játékban);
            PalyaKirajzolas();
            Console.SetCursorPosition(0, Palya.Meret.Height + 4);
            Console.ForegroundColor = (Palya.Allapot == JatekAllapot.Nyert) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine((Palya.Allapot == JatekAllapot.Nyert) ? "Gratulalok, On nyert!":"Sajnos minden birka elszaladt, On vesztett!");
            Console.ReadKey();
        }

        static void BirkakElhelyezese(Size eltolas)
        {
            foreach (Birka item in Palya.Birkak)
            {
                if (item.Elet != BirkaElet.Halott)
                {
                    Console.ForegroundColor = (item.Elet == BirkaElet.Sértetlen) ? ConsoleColor.White : ConsoleColor.Red;
                    Console.SetCursorPosition(item.Pozicio.X + eltolas.Width, item.Pozicio.Y + eltolas.Height);
                    Console.WriteLine("X");
                }
                Console.ResetColor();
            }
        }

        static void PalyaKirajzolas()
        {
            Console.Clear();
            Console.ResetColor();
            // Vizszintes jelolo - oszlop
            Console.Write("   ");
            for (int i = 0; i < Palya.Meret.Width; i++)
            {
                Console.Write(Convert.ToChar(i + 65)); // 65 ASCII kod tablaban az 'A' betu
            }
            // Fuggoleges jelolo - sor
            Console.WriteLine("\n");
            for (int i = 0; i < Palya.Meret.Height; i++)
            {
                Console.WriteLine(i);
            }
            // Mezo keret kirajzolasa
            Console.SetCursorPosition(3, 1); // 2-vel jobbra, 1-el lefele tolom a cursort, az indulasi ertek mindig 0, tehat 3-ik oszlop, 2-ik sor
            for (int i = 0; i < Palya.Meret.Width; i++)
            {
                Console.Write("-");
                Console.CursorTop += Palya.Meret.Height + 1;
                Console.CursorLeft--;
                Console.Write("-");
                Console.CursorTop -= Palya.Meret.Height + 1;
            }
            Console.SetCursorPosition(2, 2);
            for (int i = 1; i <= Palya.Meret.Height; i++)
            {
                Console.Write("|");
                Console.CursorLeft += Palya.Meret.Width;
                Console.Write('|');
                Console.SetCursorPosition(2, 2 + i);
            }
            // Elhagyjuk az elso 3 oszlopot (a sorjelolo es a mezohatar) es elhagyjuk az elso 2 sort (az oszlopjelolo es a mezohatar)
            BirkakElhelyezese(new Size(3, 2));
        }

        static Point LovesAdatokBekerese(Size eltolas)
        {
            Console.SetCursorPosition(0, eltolas.Height + Palya.Meret.Height + 2);
            Console.WriteLine("Kerem, adja meg a loves helyet! [Oszlop;Sor]");
            Point hely = new Point(-1, -1);
            do
            {
                string helySzoveg = Console.ReadLine().Trim();
                string[] helySzovegFelbontva = helySzoveg.Split(';');
                if (helySzovegFelbontva.Length == 2 && helySzovegFelbontva[0] != string.Empty && helySzovegFelbontva[1] != string.Empty)
                {
                    hely = new Point(Convert.ToInt32(helySzovegFelbontva[0][0]) - 65, Convert.ToInt32(helySzovegFelbontva[1].Trim()));
                }

            } while (hely.X < 0 || hely.Y < 0 || hely.X > Palya.Meret.Width || hely.Y > Palya.Meret.Height);

            return hely;
        }
    }
}
