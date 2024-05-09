using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktarKezelo
{
    enum TermekTipus
    {
        Altalanos_termek,
        Tejtermek,
        Pekaru,
        Zoldseg_Vagy_Gyumolcs
    }
    internal class AltalanosTermek
    {
        #region PRIVATE FIELDS
        string megnevezes;
        string cikkSzam;
        int ar;
        int darabSzam;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) { megnevezes = value; }
                else { throw new ArgumentException("A megnevezes nem megfelelo!"); }
            }
        }
        public string CikkSzam
        {
            get => cikkSzam;
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) { cikkSzam = value; }
                else { throw new ArgumentException("A cikkszam nem megfelelo!"); }
            }
        }
        public int Ar
        {
            get => ar;
            set
            {
                if (value > 0) { ar = value; }
                else { throw new ArgumentException("Az ar nem lehet nulla!"); }
            }
        }
        public int DarabSzam
        {
            get => darabSzam;
            set
            {
                if (value > 0) { darabSzam = value; }
                else { throw new ArgumentException("A darabszam nem lehet nulla!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public AltalanosTermek(string megnevezes, string cikkSzam, int ar, int darabSzam)
        {
            Megnevezes = megnevezes;
            CikkSzam = cikkSzam;
            Ar = ar;
            DarabSzam = darabSzam;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"{megnevezes} - {cikkSzam} [{ar} - {darabSzam}]";
        }
        #endregion
    }
}
