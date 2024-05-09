using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03058_HF_Oszthatosag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írjon programot, melynek meg lehet adni egy számot, majd eldönti, hogy 2 - vel, 5 - el vagy 10 - el osztható - e.Ezt úgy döntse el, hogy a számot magát nem konvertálhatja át számmá.

            Console.WriteLine("Kerem adjon meg egy szamot:");

            string szam = Console.ReadLine();
            OszthatosagEllenorzes(szam);
            Console.ReadKey();
        }

        static void OszthatosagEllenorzes(string szam)
        {
            if (szam.EndsWith("2") || szam.EndsWith("4") || szam.EndsWith("6") || szam.EndsWith("8"))
            {
                Console.WriteLine("A beirt szam oszthato 2-vel!");
            }
            else if (szam.EndsWith("5"))
            {
                Console.WriteLine("A beirt szam oszthato 5-el!");
            }
            else if (szam.EndsWith("0") && szam.Length > 1)
            {
                Console.WriteLine("A beirt szam 2-vel, 5-el es 10-el is oszthato!");
            }
            else
            {
                Console.WriteLine("A beirt szam nem oszthato sem 2-vel, sem 5-el, sem 10-el!");
            }
        }
    }
}
