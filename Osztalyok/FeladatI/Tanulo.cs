using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatI
{
    internal class Tanulo
    {
        #region PRIVATE FIELDS
        string nevField;
        double atlagField;
        long szemelyiSzamField;
        #endregion

        #region PUBLIC PROPERTIES
        public string NevProperty
        {
            get => nevField;
            set
            {
                if (value.Trim().Length >= 5)
                {
                    nevField = value;
                }
                else
                {
                    throw new Exception("A NEV mezo erteke nem megfelelo!");
                    //Hibat dobok
                }
            }
        }
        public double AtlagProperty { get => atlagField; set => atlagField = value; }
        public long SzemelyiSzamProperty { get => szemelyiSzamField; set => szemelyiSzamField = value; }
        #endregion

        #region CONSTRUCTORS
        public Tanulo(string nevBejovo, double atlagBejovo, long szemelyiSzamBejovo)
        {
            NevProperty = nevBejovo;
            AtlagProperty = atlagBejovo;
            SzemelyiSzamProperty = szemelyiSzamBejovo;
        }
        #endregion

        #region METHODS

        #endregion
    }
}
