using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvNyilvantarto
{
    enum Kategoriak
    {
        [Description("Válasszon")]
        Válasszon,
        [Description("Fantasy")]
        Fantasy,
        [Description("Sci-Fi")]
        SciFi,
        [Description("Szakácskönyv")]
        Szakácskönyv,
        [Description("Ifjúsági Regény")]
        IfjúságiRegény,
    }
    internal class Konyv
    {
        #region PRIVATE FIELDS
        int sorszam;
        string cim;
        string szerzo;
        Kategoriak mufaj;
        #endregion

        #region PUBLIC PROPERTIES

        public int Sorszam
        {
            get => sorszam;
            set
            {
                if (value == -1)
                {
                    sorszam = value;
                }
                else
                {
                    throw new ArgumentException("A sorszám módosítása nem lehetséges, mert már van értéke!");
                }
            }
        }
        public string Cim
        {
            get => cim;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Trim().Length <= 200) { cim = value; }
                else { throw new ArgumentException("A cím mező nem lehet üres!"); }
            }
        }
        public string Szerzo
        {
            get => szerzo;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Trim().Length <= 150) { szerzo = value; }
                else { throw new ArgumentException("A szerző mező nem lehet üres!"); }
            }
        }
        public Kategoriak Mufaj
        {
            get => mufaj;
            set
            {
                if (Enum.IsDefined(typeof(Kategoriak), value) && value != Kategoriak.Válasszon) { mufaj = value; }
                else { throw new ArgumentException("A műfaj nem megfelelő!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Konyv(string cim, string szerzo, Kategoriak mufaj, int sorszamID = -1)
        {
            if (sorszamID != -1)
            {
                sorszam = sorszamID;
            }
            Cim = cim;
            Szerzo = szerzo;
            Mufaj = mufaj;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Cím: {Cim}, Szerző: {Szerzo}, Műfaj: {Mufaj}";
        }
        #endregion

    }
}
