using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktarKezelo
{
    internal class Pekaru : AltalanosTermek
    {
        #region PRIVATE FIELDS
        bool teljesKiorlesu;
        #endregion

        #region PUBLIC PROPERTIES
        public bool TeljesKiorlesu { get => teljesKiorlesu; set => teljesKiorlesu = value; }
        #endregion

        #region CONSTRUCTORS
        public Pekaru(string megnevezes, string cikkSzam, int ar, int darabSzam, bool teljesKiorlesu) : base(megnevezes, cikkSzam, ar, darabSzam)
        {
            TeljesKiorlesu = teljesKiorlesu;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //Az ososztaly overridejaval ter vissza, amit itt mi kiegeszitunk
            return $"{base.ToString()}  ==> Pekaru / {(TeljesKiorlesu ? "Teljeskiorlesu" : "Nem teljeskioru")}";
        }
        #endregion
    }
}
