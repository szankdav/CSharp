using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCRaktarKezelo
{
    enum TejtermekTipus
    {
        Tej,
        Sajt,
        Vaj,
        Egyeb
    }
    internal class Tejtermek : AltalanosTermek
    {
        #region PRIVATE FIELDS
        float zsirtartalom;
        TejtermekTipus tipus;
        #endregion

        #region PUBLIC PROPERTIES
        public float Zsirtartalom
        {
            get => zsirtartalom;
            set
            {
                if (value >= 0 && value <= 100) { zsirtartalom = value; }
                else { throw new ArgumentException("A zsirtartalom nem megfelelo!"); }
            }
        }
        internal TejtermekTipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(TejtermekTipus), value)) { tipus = value; }
                else { throw new ArgumentException("A tejtermek tipus nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Tejtermek(string megnevezes, string cikkSzam, int ar, int darabSzam, float zsirtartalom, TejtermekTipus tipus) : base(megnevezes, cikkSzam, ar, darabSzam)
        {
            Zsirtartalom = zsirtartalom;
            Tipus = tipus;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //Az ososztaly overridejaval ter vissza, amit itt mi kiegeszitunk
            return $"{base.ToString()}  ==> Tejtermek / {Zsirtartalom}, {Tipus}";
        }
        #endregion
    }
}
