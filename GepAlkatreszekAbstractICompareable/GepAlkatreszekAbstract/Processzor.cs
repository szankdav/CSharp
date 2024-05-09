using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepAlkatreszekAbstract
{
    internal class Processzor : GepAlkatresz
    {
        #region PRIVATE FIELDS
        string tokozas;
        float frekvencia;
        byte kesleltetes;
        #endregion

        #region PUBLIC PROPERTIES
        public float Frekvencia
        {
            get => frekvencia;
            set
            {
                if (value >= 333 && value <= 10000) { frekvencia = value; }
                else { throw new ArgumentException("A frekvencia erteke nem megfelelo!"); }
            }
        }
        public byte Kesleltetes
        {
            get => kesleltetes;
            set
            {
                if (value >= 1 && value <= 25) { kesleltetes = value; }
                else { throw new ArgumentException("A kesleltetes erteke nem megfelelo!"); }
            }
        }
        public string Tokozas
        {
            get => tokozas;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 20) { tokozas = value; }
                else { throw new ArgumentException("A tokozas erteke nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Processzor(string megnevezes, string szeriaSzam, int ar, Meret meret, float frekvencia, byte kesleltetes, string tokozas) : base(megnevezes, szeriaSzam, ar, meret)
        {
            Frekvencia = frekvencia;
            Kesleltetes = kesleltetes;
            Tokozas = tokozas;
        }
        #endregion

        #region METHODS
        public override int AlapanyagAr()
        {
            //throw new NotImplementedException();
            // A feltelezes, hogy egy processzor 20 g/cm2 nemesfem tartalommal rendelkezik, aminek grammjat a feladatban most 1000 Ft.-ban hataroztuk meg.
            return Meret.Szelesseg * Meret.Magassag * 20 * 1000;
        }
        #endregion
    }
}
