using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladatX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adja meg, hány nevet szeretne rögzíteni!");
            //int darabSzam = Convert.ToInt32(Console.ReadLine());
            int darabSzam = 0;
            while (int.TryParse(Console.ReadLine(), out darabSzam) == false || darabSzam <= 0)
            {
                Console.WriteLine("Nem megfelelő érték! Kérem, adjon meg másikat!");
            }
            string[] nevek = new string[darabSzam];

            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine($"Kérem, adja meg a(z) {i + 1}. nevet!");
                nevek[i] = Console.ReadLine().Trim();
            }

            int hanyMBetus = 0;
            for (int i = 0; i < nevek.Length; i++)
            {
                //nevek[i].Substring(0, 1)
                //nevek[i].ToUpper().StartsWith("M");
                //nevek[i][0].ToString().ToUpper() == "M";
                if (nevek[i][0].ToString().ToUpper() == "M")
                {
                    hanyMBetus++;
                }
            }
            int j = 0;
            while (j < nevek.Length && nevek[j].ToUpper().Trim() != "JAKAB")
            {
                j++;
            }
            bool vanJakab = j < nevek.Length;
            //if (j < nevek.length;)
            //{
            //    vanjakab = true;
            //}
            //else
            //{
            //    vanjakab = false;
            //}
            int a = 0;
            int b = 0;
            string[] hElott = new string[nevek.Length];
            string[] hEsUtan = new string[nevek.Length];
            bool hVolt = false;

            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek[i][0].ToString().ToUpper() == "H")
                {
                    hVolt = true;
                }
                if (!hVolt)
                {
                    hElott[a] = nevek[i];
                    a++;
                }
                else
                {
                    hEsUtan[b] = nevek[i];
                    b++;
                }
            }

            int c = 0;
            int d = 0;
            string[] hEsElottiek = new string[nevek.Length];
            string[] hUtaniak = new string[nevek.Length];
            bool hElottiek = true;

            for (int i = 0; i < nevek.Length; i++)
            {
                if (hElottiek)
                {
                    hEsElottiek[c] = nevek[i];
                    c++;
                }
                if (nevek[i][0].ToString().ToUpper() == "H")
                {
                    hElottiek = false;
                    continue;
                }
                if (!hElottiek)
                {
                    hUtaniak[d] = nevek[i];
                    d++;
                }
            }

            Console.WriteLine($"H és előttiek: ");

            if (c > 0)
            {
                for (int i = 0; i < hEsElottiek.Length; i++)
                {
                    Console.WriteLine("\t-" + hEsElottiek[i]);
                }
            }

            Console.WriteLine($"H utániak: ");

            if (d > 0)
            {
                for (int i = 0; i < hUtaniak.Length; i++)
                {
                    Console.WriteLine("\t-" + hUtaniak[i]);
                }
            }

            Console.WriteLine($"Összesen {hanyMBetus} db 'M' betűvel kezdődő nevet találtam.");
            Console.WriteLine((vanJakab ? "Van" : "Nincs") + "Jakab a nevek között.");
            Console.WriteLine("Az első 'H' betűvel kezdődő név előtti nevek:");
            if (a > 0)
            {
                for (int i = 0; i < hElott.Length; i++)
                {
                    Console.WriteLine("\t-" + hElott[i]);
                }
            }
            else
            {
                Console.WriteLine("Az első találat 'H' betűvel kezdődő név volt.");
            }
            Console.WriteLine("Az első 'H' betűvel kezdődő név és utáni nevek:");
            if (b > 0)
            {
                for (int i = 0; i < hEsUtan.Length; i++)
                {
                    Console.WriteLine("\t-" + hEsUtan[i]);
                }
            }
            else
            {
                Console.WriteLine("Nem volt 'H' betűvel kezdődő név.");
            }
            Console.ReadKey();
        }
    }
}
