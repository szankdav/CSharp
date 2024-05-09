using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizsgaMgr
{
    internal class Vizsga
    {
        #region PRIVATE FIELDS
        string megnevezes;
        byte osszPontszam;
        List<Feladat> feladatok;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (value.Trim().Length >= 5 && value.Trim().Length <= 20) { megnevezes = value; }
                else { throw new ArgumentException("A vizsga megnevezése nem megfelelő!"); }
            }
        }
        public byte OsszPontszam
        {
            get => osszPontszam;
            set
            {
                if (value >= 50 && value <= 100) { osszPontszam = value; }
                else { throw new ArgumentException("A vizsga összpontszáma nem megfelelő!"); }
            }
        }
        internal List<Feladat> Feladatok
        {
            get
            {
                List<Feladat> feladatokMasolat = new List<Feladat>();
                foreach (Feladat item in feladatok) { feladatokMasolat.Add(item); }
                return feladatokMasolat;
            }
            //set => feladatok = value;
        }

        public byte FeladatokOsszpontszama
        {
            get
            {
                byte osszPont = 0;
                foreach (Feladat item in feladatok)
                {
                    // TODO: Ezt még nem tudjuk megírni, csak a Feladat osztály létrehozása után
                    osszPont += item.PontSzam;
                }
                return osszPont;
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Vizsga(string megnevezes, byte osszPontszam)
        {
            Megnevezes = megnevezes;
            OsszPontszam = osszPontszam;
            feladatok = new List<Feladat>();
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"Vizsga megnevezése: {megnevezes} [Összpontszám: {osszPontszam}]";
        }

        public void UjFeladat(Feladat uj)
        {
            if (OsszPontszam >= FeladatokOsszpontszama + uj.PontSzam)
            {
                feladatok.Add(uj);
            }
            else
            {
                throw new ArgumentException("Feladat létrehozása nem lehetséges!");
            }
        }

        public void FeladatTorlese(int index)
        {
            feladatok.RemoveAt(index);
        }

        public void FeladatTorlese(Feladat item)
        {
            feladatok.Remove(item);
        }

        public static int OsszesVizsgaOsszesPontszama(List<Vizsga> vizsgak)
        {
            int osszesVizsgaOsszesPontszama = 0;
            foreach (Vizsga item in vizsgak)
            {
                osszesVizsgaOsszesPontszama += item.OsszPontszam;
            }
            return osszesVizsgaOsszesPontszama;
        }
        #endregion
    }
}
