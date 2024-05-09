using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinearisKeresesDelegateGenerikus
{
    delegate bool KeresesFeltetel<T>(T elem);
    static class ProgTetelGenerikus
    {
        public static T Kivalasztas<T>(IEnumerable<T> elemek, KeresesFeltetel<T> feltetel)
        {
            foreach (T elem in elemek)
            {
                if (feltetel(elem))
                {
                    return elem;
                }
            }
            return default(T);
        }

        public static IEnumerable<T> Kivalogatas<T>(IEnumerable<T> elemek, KeresesFeltetel<T> feltetel)
        {
            List<T> kivalogatott = new List<T>();
            foreach (T elem in elemek)
            {
                if (feltetel(elem))
                {
                    kivalogatott.Add(elem);
                }
            }
            return kivalogatott;
        }

        public static void EgyszeruCseresRendezes<T>(IList<T> elemek) where T:IComparable
        {
            for (int i = 0; i < elemek.Count - 1; i++)
            {
                for (int j = i + 1; j < elemek.Count; j++)
                {
                    if (elemek[j].CompareTo(elemek[i]) < 0)
                    {
                        T csere = elemek[i];
                        elemek[i] = elemek[j];
                        elemek[j] = csere;
                    }
                }
            }
        } 
    }
}
