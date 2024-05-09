using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static ViragRendelesek.Rendeles;

namespace ViragRendelesek
{
    enum ViragTipus
    {
        Egynyari,
        Tobbnyari
    }
    internal class Virag
    {
        #region PRIVATE FIELDS
        string nev;
        uint ar;
        byte darabSzam;
        ViragTipus tipus;
        #endregion

        #region PUBLIC PROPERTIES
        public string Nev
        {
            get => nev;
            set
            {
                if (value.Trim().Length >= 5 && value.Trim().Length <= 30)
                {
                    nev = value;
                }
                else
                {
                    throw new ArgumentException("A nev erteke nem megfelelo!");
                }
            }
        }
        public uint Ar
        {
            get => ar;
            set
            {
                if (value >= 1 && value <= 100000)
                {
                    ar = value;
                }
                else
                {
                    throw new ArgumentException("Az ar erteke nem megfelelo");
                }
            }
        }
        public byte DarabSzam
        {
            get => darabSzam;
            set
            {
                if (value >= 1 && value <= 100)
                {
                    darabSzam = value;
                }
                else
                {
                    throw new ArgumentException("A darabszam erteke nem megfelelo");
                }
            }
        }
        internal ViragTipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(ViragTipus), value))
                {
                    tipus = value;
                }
                else
                {
                    throw new ArgumentException("A virag tipusa nem megfelelo");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Virag(string nev, uint ar, byte darabSzam, ViragTipus tipus)
        {
            Nev = nev;
            Ar = ar;
            DarabSzam = darabSzam;
            Tipus = tipus;
        }
        #endregion

        #region METHODS
        public uint ViragokAra()
        {
            uint sum = 0;
            sum = ar * darabSzam;
            return sum;
        }
        public override string ToString()
        {
            //return base.ToString();
            return $"Nev: {Nev} - Ar: {Ar} - Darabszam: {DarabSzam} - Tipus: {Tipus}";
        }
        #endregion
    }
}
