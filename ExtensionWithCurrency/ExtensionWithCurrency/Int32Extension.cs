using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionWithCurrency
{
    public enum Currencies
    {
        USD,
        EUR,
        GBP,
        HUF
    }
    public static class Int32Extension
    {
        public static string WithCurrency(this int number, Currencies currency)
        {
            switch (currency)
            {
                case Currencies.USD:
                    return $"{number} €";                    
                case Currencies.EUR:
                    return $"{number} $";
                case Currencies.GBP:
                    return $"{number} £";
                case Currencies.HUF:
                default:
                    return $"{number} Ft.";
            }
        }

        public static double AsDouble(this int number)
        {
            return (double)number;
        }

        public static int Square(this int number)
        {
            return (int)Math.Pow(number, 2);
        }

        public static int Square2(this int number)
        {
            return (int)Math.Pow(number, 2);
        }
    }
}
