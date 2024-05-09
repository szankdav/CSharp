using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglecastDelegatePelda
{
    delegate double MatekFunkcio(int szam1, int szam2);

    enum AlapMuveletek
    {
        Osszeadas,
        Kivonas,
        Szorzas,
        Osztas
    }
    static class Matek
    {
        public static double Osszeadas(int a, int b)
        {
            return a + b;
        }
        public static double Kivonas(int a, int b)
        {
            return a - b;
        }
        public static double Szorzas(int a, int b)
        {
            return a * b;
        }
        public static double Osztas(int a, int b)
        {
            return a * 1.0 / b;
        }
    }
}
