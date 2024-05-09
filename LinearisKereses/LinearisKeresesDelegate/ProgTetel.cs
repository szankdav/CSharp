using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearisKeresesDelegate
{
    delegate bool TetszolegesFeltetelFunkcio(int elem);
    static class ProgTetel
    {
        public static bool Eldontes(int[] adatok, TetszolegesFeltetelFunkcio funkcio)
        {
            int i = 0;
            while (i < adatok.Length && !funkcio(adatok[i]))
            {
                i++;
            }
            return i < adatok.Length;
        }
    }
}
