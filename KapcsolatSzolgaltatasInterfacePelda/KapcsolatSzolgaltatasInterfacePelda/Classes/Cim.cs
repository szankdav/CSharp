using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    internal class Cim : ICSVMentes
    {
        #region PRIVATE FIELDS
        short iranyitoSzam;
        string helyseg;
        string utca;
        short hazSzam;
        #endregion

        #region PUBLIC PROPERTIES
        public short IranyitoSzam
        {
            get => iranyitoSzam;
            set
            {
                if (value >= 1000 && value <= 9999) { iranyitoSzam = value; }
                else { throw new ArgumentException("Az iranyitoszam nem megfelelo!"); }
            }
        }
        public string Helyseg
        {
            get => helyseg;
            set
            {
                if (value.Trim().Length >= 2 && value.Trim().Length <= 50) { helyseg = value; }
                else { throw new ArgumentException("A helyseg nem megfelelo!"); }
            }
        }
        public string Utca
        {
            get => utca;
            set
            {
                if (value.Trim().Length >= 4 && value.Trim().Length <= 50) { utca = value; }
                else { throw new ArgumentException("Az utca nem megfelelo!"); }
            }
        }
        public short HazSzam
        {
            get => hazSzam;
            set
            {
                if (value >= 1 && value <= 999) { hazSzam = value; }
                else { throw new ArgumentException("A hazsszam nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Cim(short iranyitoSzam, string helyseg, string utca, short hazSzam)
        {
            IranyitoSzam = iranyitoSzam;
            Helyseg = helyseg;
            Utca = utca;
            HazSzam = hazSzam;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"[Iranyitoszam: {IranyitoSzam}. Helyseg: {Helyseg}, Utca es hazszam: {Utca} {HazSzam}]";
        }

        public string CSVFormatum(string szeparator = ";", string sorveg = "\n")
        {
            return $"{IranyitoSzam}{szeparator}{Helyseg}{szeparator}{Utca}{szeparator}{HazSzam}";
        }
        #endregion
    }
}
