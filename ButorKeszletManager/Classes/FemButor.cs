using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    abstract class FemButor : Butor
    {
        #region PRIVATE FIELDS
        int felhasznaltAnyagVastagsaga;
        bool hegesztett;
        bool csavarozott;
        #endregion

        #region PUBLIC PROPERTIES
        public int FelhasznaltAnyagVastagsaga
        {
            get => felhasznaltAnyagVastagsaga;
            set
            {
                if (felhasznaltAnyagVastagsaga >= 100)
                {
                    felhasznaltAnyagVastagsaga = value;
                }
                else
                {
                    throw new ArgumentException("A felhasznalt anyag vastagsaga minimum 100 mm!");
                }
            }
        }
        public bool Hegesztett { get => hegesztett; set => hegesztett = value; }
        public bool Csavarozott { get => csavarozott; set => csavarozott = value; }
        #endregion

        #region CONSTRUCTORS
        protected FemButor(string gyartoNeve, string azonosito, int magassag, int hosszusag, int szelesseg, int felhasznaltAnyagVastagsaga, bool hegesztett, bool csavarozott) : base(gyartoNeve, azonosito, magassag, hosszusag, szelesseg)
        {
            FelhasznaltAnyagVastagsaga = felhasznaltAnyagVastagsaga;
            Hegesztett = hegesztett;
            Csavarozott = csavarozott;
        }
        #endregion

        #region METHODS
        public override int Kalkulator()
        {
            return FelhasznaltAnyagVastagsaga * 1 / Magassag;
        }
        #endregion
    }
}
