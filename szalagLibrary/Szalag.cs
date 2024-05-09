using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalagLibrary
{
    public class Szalag
    {
        int szalagHoszz;
        int egysegnyiTavolsagIdo;

        public int SzalagHoszz { get => szalagHoszz; set => szalagHoszz = value; }
        public int EgysegnyiTavolsagIdo { get => egysegnyiTavolsagIdo; set => egysegnyiTavolsagIdo = value; }

        public Szalag(int szalagHoszz, int egysegnyiTavolsagIdo)
        {
            SzalagHoszz = szalagHoszz;
            EgysegnyiTavolsagIdo = egysegnyiTavolsagIdo;
        }
    }
}
