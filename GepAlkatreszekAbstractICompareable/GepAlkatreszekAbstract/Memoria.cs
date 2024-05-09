using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace GepAlkatreszekAbstract
{
    internal class Memoria : GepAlkatresz
    {
        #region PRIVATE FIELDS
        string architektura;
        float frekvencia;
        MemoriaTipus tipus;
        #endregion

        #region PUBLIC PROPERTIES
        public string Architektura
        {
            get => architektura;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 20) { architektura = value; }
                else { throw new ArgumentException("Az architektura erteke nem megfelelo!"); }
            }
        }
        public float Frekvencia
        {
            get => frekvencia;
            set
            {
                if (value >= 100 && value <= 10000) { frekvencia = value; }
                else { throw new ArgumentException("A frekvencia erteke nem megfelelo!"); }
            }
        }
        internal MemoriaTipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(MemoriaTipus), value)) { tipus = value; }
                else { throw new ArgumentException("A tipus erteke nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Memoria(string megnevezes, string szeriaSzam, int ar, Meret meret, MemoriaTipus tipus, string architektura, float frekvencia) : base(megnevezes, szeriaSzam, ar, meret)
        {
            Tipus = tipus;
            Architektura = architektura;
            Frekvencia = frekvencia;
        }
        #endregion

        #region METHODS
        public override int AlapanyagAr()
        {
            //throw new NotImplementedException();
            // A feltelezes, hogy egy memoria 15 g/cm2 nemesfem tartalommal rendelkezik, aminek grammjat a feladatban most 600 Ft.-ban hataroztuk meg.
            return Meret.Szelesseg * Meret.Magassag * 15 * 600;
        }
        #endregion
    }
}
