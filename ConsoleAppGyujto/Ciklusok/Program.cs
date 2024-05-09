using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int osszeg = 0;
            int szorzat = 1;

            for (int i = 1; i <= 5; i++)
            {
                /*string szoveg = "Kerem adja meg a(z)" + i + ". szamot:";
                string szoveg2 = String.Format("Kerem adja meg a(z) {0}. szamot:", i);
                string szoveg3 = $"Kerem adja meg a(z) {i}. szamot:";*/

                Console.WriteLine($"Kerem adja meg a(z) {i}. szamot:");
                int tmp = Convert.ToInt32(Console.ReadLine());
                /*osszeg = osszeg + tmp;
                szorzat = szorzat * tmp;*/
                osszeg += tmp;
                szorzat *= tmp;
            }

            Console.WriteLine($"Az osszeadas eredmenye: {osszeg}");
            Console.WriteLine($"A szorzas eredmenye: {szorzat}");

            Console.ReadKey();
        }
    }
}
