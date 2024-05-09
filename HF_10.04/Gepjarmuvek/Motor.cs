using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmuvek
{
    public class Motor : Gepjarmu
    {
        #region PRIVATE FIELDS
        ushort motorTerfogat;
        #endregion

        #region PUBLIC PROPERTIES
        public ushort MotorTerfogat
        {
            get => motorTerfogat;
            set
            {
                if (value >= 50 && value < ushort.MaxValue) { motorTerfogat = value; }
                else { throw new ArgumentException("A motorterfogat nem lehet kisebb, mint 50!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Motor(string rendszam, uint futottKM, bool kolcsonzesiAllapot, ushort motorTerfogat) : base(rendszam, futottKM, kolcsonzesiAllapot)
        {
            MotorTerfogat = motorTerfogat;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{base.ToString()} - Motortérfogat: [{motorTerfogat} cm3]";
        }

        public string MotorCSVMentes()
        {
            return $"{GepjarmuCSVMentes()};{motorTerfogat};M";
        }
        #endregion

    }
}
