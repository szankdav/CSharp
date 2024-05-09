using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBoltSajatEsemenyPelda
{
    enum KonyvTipus
    {
        Krimi,
        Tudomanyos,
        Drama,
        SciFi,
        Fantasy
    }
    internal class Konyv
    {
        #region PRIVATE FIELDS
        string iro;
        string cim;
        KonyvTipus tipus;
        int ar;
        int darab;
        #endregion

        #region PUBLIC PROPERTIES
        public string Iro { get => iro; private set => iro = value; }
        public string Cim { get => cim; private set => cim = value; }
        internal KonyvTipus Tipus { get => tipus; private set => tipus = value; }
        public int Ar { get => ar; private set => ar = value; }
        public int Darab { get => darab; set => darab = value; }
        #endregion

        #region CONSTRUCTORS
        public Konyv(string iro, string cim, KonyvTipus tipus, int ar, int darab)
        {
            Iro = iro;
            Cim = cim;
            Tipus = tipus;
            Ar = ar;
            Darab = darab;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{iro} - {cim} | Darab: {darab} | Ar: {ar}";
        }
        #endregion
    }
}
