using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusKonfiguracioPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Konfig.KonfigBetoltes("konfig.csv");
            int a = Konfig.KonfigLekeres<int>("szam");
            double b = Konfig.KonfigLekeres<double>("tort");
            DateTime datum = Konfig.KonfigLekeres<DateTime>("datum");
            string szoveg = Konfig.KonfigLekeres<string>("szoveg");
            NemStatikusOsztaly nemStatik = new NemStatikusOsztaly();
            nemStatik.ExtensionMethod();
            Console.ReadKey();
        }
    }
}
