using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adjon meg egy számot:");

            string valtozo = Console.ReadLine();
            // A futás idejű hiba lekezeléséről külön kell gondoskodni!
            int szam = Convert.ToInt32(valtozo);

            //int negyzet = szam * szam;

            double negyzet = Math.Pow(szam, 2);
            
            Console.WriteLine(negyzet);

            Console.ReadKey();
        }
    }
}
