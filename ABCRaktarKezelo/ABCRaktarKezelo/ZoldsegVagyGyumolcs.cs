using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktarKezelo
{
    enum ZoldsegGyumolcs
    {
        Zoldseg,
        Gyumolcs
    }
    internal class ZoldsegVagyGyumolcs : AltalanosTermek
    {
        #region PRIVATE FIELDS
        ZoldsegGyumolcs tipus;
        #endregion

        #region PUBLIC PROPERTIES
        internal ZoldsegGyumolcs Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(ZoldsegGyumolcs), value)) { tipus = value; }
                else { throw new ArgumentException("A zoldseg vagy gyumolcs tipusa nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public ZoldsegVagyGyumolcs(string megnevezes, string cikkSzam, int ar, int darabSzam, ZoldsegGyumolcs tipus) : base(megnevezes, cikkSzam, ar, darabSzam)
        {
            Tipus = tipus;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //Az ososztaly overridejaval ter vissza, amit itt mi kiegeszitunk
            return $"{base.ToString()}  ==> Zoldseg vagy Gyumolcs / {(Tipus == 0 ? "Zoldseg" : "Gyumolcs")}";
        }
        #endregion
    }
}
