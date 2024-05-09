using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JegyOsztasQueue
{
    internal class Feladat
    {
        #region PRIVATE FIELDS
        string cim;
        string leiras;
        DateTime hatarido;
        #endregion

        #region PUBLIC PROPERTIES
        public string Cim
        {
            get => cim;
            set
            {
                if (value.Trim().Length >= 5 && value.Trim().Length <= 30) { cim = value; }
                else { throw new ArgumentException("A cim erteke nem megfelelo!"); }
            }
        }
        public string Leiras
        {
            get => leiras;
            set
            {
                if (value.Trim().Length >= 5 && value.Trim().Length <= 200) { leiras = value; }
                else { throw new ArgumentException("A leiras erteke nem megfelelo!"); }
            }
        }
        public DateTime Hatarido { get => hatarido; set => hatarido = value; }
        #endregion

        #region CONSTRUCTORS
        public Feladat(string cim, string leiras, DateTime hatarido)
        {
            Cim = cim;
            Leiras = leiras;
            Hatarido = hatarido;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"Cim: {cim} - Hatarido: {hatarido} [Leiras: {leiras.Substring(0, 5)}...]";
        }
        #endregion
    }
}
