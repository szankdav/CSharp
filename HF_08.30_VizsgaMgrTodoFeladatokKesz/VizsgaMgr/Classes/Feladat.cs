using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaMgr
{
    internal class Feladat
    {
        #region PRIVATE FIELDS
        string leiras;
        byte pontSzam;
        #endregion

        #region PUBLIC PROPERTIES
        public string Leiras
        {
            get => leiras;
            set
            {
                if (value.Trim().Length >= 5 && value.Trim().Length <= 200) { leiras = value; }
                else { throw new ArgumentException("A feladat leírása nem megfelelő!"); }
            }
        }
        public byte PontSzam
        {
            get => pontSzam;
            set
            {
                if (value >= 1 && value <= 100) { pontSzam = value; }
                else { throw new ArgumentException("A feladat pontszáma nem megfelelő!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Feladat(string leiras, byte pontSzam)
        {
            Leiras = leiras;
            PontSzam = pontSzam;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            string szoveg = String.Empty;
            //if (leiras.Trim().Length >30)
            //{
            //    szoveg = $"{leiras.Trim().Substring(0, 27)}...";
            //}
            //else
            //{
            //    szoveg = leiras.Trim();
            //}
            return ((leiras.Trim().Length > 30) ? $"{leiras.Trim().Substring(0, 27)}..." : leiras.Trim()) + $" [{pontSzam} pontszám]";
        }

        public static int OsszesFeladatOsszesPontSzama(Vizsga vizsga)
        {
            int osszesFeladatOsszesPontszama = 0;
            foreach (Feladat feladat in vizsga.Feladatok)
            {
                osszesFeladatOsszesPontszama += feladat.PontSzam;
            }
            return osszesFeladatOsszesPontszama;
        }
        #endregion
    }
}
