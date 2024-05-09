using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepAlkatreszekAbstract
{
    internal class Alaplap : GepAlkatresz
    {
        #region PRIVATE FIELDS
        string chipset;
        MemoriaTipus tamogatottMemoria;
        #endregion

        #region PUBLIC PROPERTIES
        public string Chipset
        {
            get => chipset;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 20) { chipset = value; }
                else { throw new ArgumentException("A chipset erteke nem megfelelo!"); }
            }
        }
        internal MemoriaTipus TamogatottMemoria
        {
            get => tamogatottMemoria;
            set
            {
                if (Enum.IsDefined(typeof(MemoriaTipus), value)) { tamogatottMemoria = value; }
                else { throw new ArgumentException("A memoria tipusa nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Alaplap(string megnevezes, string szeriaSzam, int ar, Meret meret, string chipset, MemoriaTipus tamogatottMemoria) : base(megnevezes, szeriaSzam, ar, meret)
        {
            Chipset = chipset;
            TamogatottMemoria = tamogatottMemoria;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{base.ToString()} - [{chipset} - {tamogatottMemoria}]";
        }

        public override int AlapanyagAr()
        {
            //throw new NotImplementedException();
            // A feltelezes, hogy egy alaplap 10 g/cm2 nemesfem tartalommal rendelkezik, aminek grammjat a feladatban most 500 Ft.-ban hataroztuk meg.
            return Meret.Szelesseg * Meret.Magassag * 10 * 500;
        }
        #endregion
    }
}
