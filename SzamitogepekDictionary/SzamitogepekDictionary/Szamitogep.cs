using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamitogepekDictionary
{
    internal class Szamitogep
    {
        #region PRIVATE FIELDS
        string os, tulaj;
        #endregion
        #region PUBLIC PROPERTIES
        public string Os { get => os; set => os = value; }
        public string Tulaj { get => tulaj; set => tulaj = value; }
        #endregion
        #region CONSTRUCTORS
        public Szamitogep(string os, string tulaj)
        {
            Os = os;
            Tulaj = tulaj;
        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"Operacios rendszer: {os} - Tulajdonos: {tulaj}";
        }
        #endregion
    }
}
