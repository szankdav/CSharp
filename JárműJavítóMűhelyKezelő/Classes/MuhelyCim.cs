using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal class MuhelyCim
    {
        #region PRIVATE FIELDS
        string iranyitoSzam;
        string helyseg;
        string utcaNev;
        int hazSzam;
        #endregion

        #region PUBLIC PROPERTIES
        public string IranyitoSzam
        {
            get => iranyitoSzam;
            set
            {
                if (value.Trim().Length == 4 && int.TryParse(value, out int szam)) { iranyitoSzam = value; }
                else { throw new ArgumentException("Hibas iranyitoszam! Az iranyitoszamnak 4 db szambol kell allnia!"); }
            }
        }
        public string Helyseg
        {
            get => Helyseg;
            set
            {
                if (!string.IsNullOrEmpty(value)) { Helyseg = value; }
                else { throw new ArgumentException("A helysegnev nem lehet ures!"); }
            }
        }
        public string UtcaNev
        {
            get => utcaNev;
            set
            {
                if (!string.IsNullOrEmpty(value)) { utcaNev = value; }
                else { throw new ArgumentException("Az utcanev nem lehet ures!"); }
            }
        }
        public int HazSzam
        {
            get => hazSzam;
            set
            {
                if (value > 0) { hazSzam = value; }
                else { throw new ArgumentException("A hazszam nem lehet ures!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public MuhelyCim(string iranyitoSzam, string helyseg, string utcaNev, int hazSzam)
        {
            IranyitoSzam = iranyitoSzam;
            Helyseg = helyseg;
            UtcaNev = utcaNev;
            HazSzam = hazSzam;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"IRSZ: {IranyitoSzam}, Helyseg: {Helyseg}, Utcanev: {UtcaNev}, Hazszam: {HazSzam}";
        }
        #endregion

    }
}
