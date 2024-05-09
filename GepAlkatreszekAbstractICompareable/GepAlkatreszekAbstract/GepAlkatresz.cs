using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepAlkatreszekAbstract
{
    enum MemoriaTipus
    {
        SDRAM,
        DDR1,
        DDR2,
        DDR3,
        DDR4,
        DDR5,
    }
    abstract class GepAlkatresz : IComparable
    {
        #region PRIVATE FIELDS
        string megnevezes;
        string szeriaSzam;
        int ar;
        Meret meret;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 30) { megnevezes = value; }
                else { throw new ArgumentException("A megnevezes nem megfelelo!"); }
            }
        }
        public string SzeriaSzam
        {
            get => szeriaSzam;
            private set
            {
                if (value.Trim().Length == 10) { szeriaSzam = value; }
                else { throw new ArgumentException("A szeriaszam nem megfelelo!"); }
            }
        }
        public int Ar
        {
            get => ar;
            set
            {
                if (value >= 1) { ar = value; }
                else { throw new ArgumentException("Az ar nem megfelelo!"); }
            }
        }
        internal Meret Meret { get => meret; set => meret = value; }
        #endregion

        #region CONSTRUCTORS
        protected GepAlkatresz(string megnevezes, string szeriaSzam, int ar, Meret meret)
        {
            Megnevezes = megnevezes;
            SzeriaSzam = szeriaSzam;
            Ar = ar;
            Meret = meret;
        }
        #endregion

        #region METHODS 
        public override string ToString()
        {
            //return base.ToString();
            return $"{megnevezes} - {szeriaSzam} - {ar} - {meret.Szelesseg}, {meret.Magassag}";
        }

        public abstract int AlapanyagAr();

        public int CompareTo(object obj)
        {
            if (obj is GepAlkatresz ujAlkatresz)
            {
                return this.megnevezes.CompareTo(ujAlkatresz.megnevezes);
            }
            else
            {
                throw new ArgumentException("Hiba! A bejovo obj nem GepAlkatresz tipusu!");
            }
        }
        #endregion
    }
}
