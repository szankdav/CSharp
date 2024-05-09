using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalagLibrary
{
    public class RekeszLogic
    {
        readonly public List<Rekesz> rekeszAdatok;

        public RekeszLogic()
        {
            rekeszAdatok = new List<Rekesz>();
        }

        public void Add(Rekesz rekesz)
        {
            rekeszAdatok.Add(rekesz);
        }

        public string HonnanHova(int sorszam)
        {
            return $"Honnan : {rekeszAdatok[sorszam - 1].FelhelyezesHosszusagEgyseg} Hova: {rekeszAdatok[sorszam - 1].LekerulesHosszusagEgyseg}";
        }

        public int LegnagyobbTavolsag()
        {
            return rekeszAdatok.Max(x => x.SzallitasiHossz);
        }

        public IEnumerable<int> LegnagyobbTavolsagSorszamok()
        {
            List<int> indexes = new List<int>();

            foreach (Rekesz rekesz in rekeszAdatok)
            {
                if (rekesz.SzallitasiHossz == rekeszAdatok.Max(x => x.SzallitasiHossz))
                {
                    indexes.Add(rekeszAdatok.IndexOf(rekesz) + 1);
                }
            }

            return indexes;
        }
    }
}
