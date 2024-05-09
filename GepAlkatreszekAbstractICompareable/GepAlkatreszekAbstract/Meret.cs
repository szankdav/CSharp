using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepAlkatreszekAbstract
{
    internal class Meret
    {
        #region PRIVATE FIELDS
        int szelesseg;
        int magassag;
        #endregion

        #region PUBLIC PROPERTIES
        public int Szelesseg
        {
            get => szelesseg;
            set
            {
                if (value >= 1 && value <= 100) { szelesseg = value; }
                else { throw new ArgumentException("Hiba! A szelesseg nem megfelelo!"); }
            }
        }
        public int Magassag
        {
            get => magassag;
            set
            {
                if (value >= 1 && value <= 100) { magassag = value; }
                else { throw new ArgumentException("Hiba! A magassag nem megfelelo!"); }
            }
        }
        #endregion
        #region CONSTRUCTORS
        public Meret(int szelesseg, int magassag)
        {
            Szelesseg = szelesseg;
            Magassag = magassag;
        }
        #endregion
    }
}
