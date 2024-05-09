using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmuvek
{
    public enum MotorTipus
    {
        Otto,
        Diesel
    }
    public class Auto : Gepjarmu
    {
        #region PRIVATE FIELDS
        MotorTipus motorTipus;
        #endregion

        #region PUBLIC PROPERTIES
        public MotorTipus MotorTipus
        {
            get => motorTipus;
            set
            {
                if (Enum.IsDefined(typeof(MotorTipus), value)) { motorTipus = value; }
                else { throw new ArgumentException("A motortipus nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Auto(string rendszam, uint futottKM, bool kolcsonzesiAllapot, MotorTipus motorTipus) : base(rendszam, futottKM, kolcsonzesiAllapot)
        {
            MotorTipus = motorTipus;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{base.ToString()} - Motor típusa: {motorTipus}";
        }

        public string AutoCSVMentes()
        {
            return $"{GepjarmuCSVMentes()};{(int)motorTipus};A";
        }
        #endregion

    }
}
