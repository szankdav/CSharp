using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalagLibrary
{
    public class Rekesz
    {
        int felhelyezesIdoEgyseg;
        int felhelyezesHosszusagEgyseg;
        int lekerulesHosszusagEgyseg;
        int tomeg;

        public int FelhelyezesIdoEgyseg { get => felhelyezesIdoEgyseg; set => felhelyezesIdoEgyseg = value; }
        public int FelhelyezesHosszusagEgyseg { get => felhelyezesHosszusagEgyseg; set => felhelyezesHosszusagEgyseg = value; }
        public int LekerulesHosszusagEgyseg { get => lekerulesHosszusagEgyseg; set => lekerulesHosszusagEgyseg = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }

        public int SzallitasiHossz
        {
            get
            {
                if (FelhelyezesHosszusagEgyseg > LekerulesHosszusagEgyseg)
                {
                    return (200 - FelhelyezesHosszusagEgyseg) + LekerulesHosszusagEgyseg;
                }
                else
                {
                    return LekerulesHosszusagEgyseg - FelhelyezesHosszusagEgyseg;
                }
            }
        }

        public Rekesz(int felhelyezesIdoEgyseg, int felhelyezesHosszusagEgyseg, int lekerulesHosszusagEgyseg, int tomeg)
        {
            FelhelyezesIdoEgyseg = felhelyezesIdoEgyseg;
            FelhelyezesHosszusagEgyseg = felhelyezesHosszusagEgyseg;
            LekerulesHosszusagEgyseg = lekerulesHosszusagEgyseg;
            Tomeg = tomeg;
        }
    }
}
