using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionWithCurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            Console.WriteLine(a);
            Console.WriteLine(a.WithCurrency(Currencies.USD));
            Console.WriteLine(a.Square().WithCurrency(Currencies.GBP));
            Console.WriteLine(a.Square().Square2().WithCurrency(Currencies.HUF));
            Console.ReadKey();
        }
    }
}
