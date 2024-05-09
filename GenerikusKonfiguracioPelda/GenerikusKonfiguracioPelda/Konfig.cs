using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerikusKonfiguracioPelda
{
    static class Konfig
    {
        static Dictionary<string, string> konfigok;

        static Konfig()
        {
            konfigok = new Dictionary<string, string>();
        }

        public static void KonfigBetoltes(string fajlnev)
        {
            StreamReader reader = new StreamReader(fajlnev);
            while (!reader.EndOfStream) 
            {
                string[] adatok = reader.ReadLine().Split(';');
                konfigok.Add(adatok[0], adatok[1]);
            }
            reader.Close();
        }

        public static T KonfigLekeres<T>(string kulcs)
        {
            return (T)Convert.ChangeType(konfigok[kulcs], typeof(T));
        }
    }
}
