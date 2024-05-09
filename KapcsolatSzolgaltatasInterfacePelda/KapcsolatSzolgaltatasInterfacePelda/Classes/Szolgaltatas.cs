using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    internal class Szolgaltatas : ICSVMentes
    {
        #region PRIVATE FIELDS
        string megnevezes;
        int ar;
        #endregion

        #region PUBLIC PROPERTIES
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (value.Trim().Length >= 3 && value.Trim().Length <= 50) { megnevezes = value; }
                else { throw new ArgumentException("A szolgaltatas megnevezes nem megfelelo!"); }
            }
        }
        public int Ar
        {
            get => ar;
            set
            {
                if (value > 0) { ar = value; }
                else { throw new ArgumentException("A szolgaltatas megnevezes nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Szolgaltatas(string megnevezes, int ar)
        {
            Megnevezes = megnevezes;
            Ar = ar;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            //return base.ToString();
            return $"Szolgaltatas megnevezese: {megnevezes} - ara: {ar}";
        }

        public string CSVFormatum(string szeparator = ";", string sorveg = "\n")
        {
            return $"{Megnevezes}{szeparator}{Ar}{sorveg}";
        }
        #endregion
    }
}
