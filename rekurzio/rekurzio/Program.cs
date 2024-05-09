using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekurzio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hanyadik faktorialisat keressuk?");
            int hanyadik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FaktorialSzamitas(hanyadik));
            Console.ReadKey();
        }

        //Rekurzio, mert a funckionk magat hivja vissza
        static int FaktorialSzamitas(int szam)
        {
            if (szam == 1)
            {
                return 1;
            }
            else 
            {
                return szam * FaktorialSzamitas(szam - 1);
            }
        }
    }
}
