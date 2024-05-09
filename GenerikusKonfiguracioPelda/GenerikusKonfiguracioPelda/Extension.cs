using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusKonfiguracioPelda
{
    public static class Extension
    {
        internal static void ExtensionMethod(this NemStatikusOsztaly nemStatikus)
        {
            Console.WriteLine("Valami");
        }
    }
}
