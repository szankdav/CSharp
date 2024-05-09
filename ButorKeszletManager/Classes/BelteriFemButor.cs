using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    enum FelhasznalasiHely
    {
        Eloszoba,
        Nappali,
        Haloszoba,
        Vengedszoba,
        Konyha,
        Egyeb
    }
    internal class BelteriFemButor : FemButor
    {
        #region PRIVATE FIELDS
        FelhasznalasiHely felhasznalasiHely;
        bool karpitozott;
        bool nemKarpitozott;
        #endregion

        #region PUBLIC PROPERTIES
        public bool Karpitozott { get => karpitozott; set => karpitozott = value; }
        public bool NemKarpitozott { get => nemKarpitozott; set => nemKarpitozott = value; }
        internal FelhasznalasiHely FelhasznalasiHely
        {
            get => felhasznalasiHely;
            set
            {
                if (Enum.IsDefined(typeof(FelhasznalasiHely), value))
                {
                    felhasznalasiHely = value;
                }
                else
                {
                    throw new ArgumentException("A felhasznalasi hely nem megfelelo!");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public BelteriFemButor(string gyartoNeve, string azonosito, int magassag, int hosszusag, int szelesseg, int felhasznaltAnyagVastagsaga, bool hegesztett, bool csavarozott, FelhasznalasiHely felhasznalasiHely, bool karpitozott, bool nemKarpitozott) : base(gyartoNeve, azonosito, magassag, hosszusag, szelesseg, felhasznaltAnyagVastagsaga, hegesztett, csavarozott)
        {
            FelhasznalasiHely = felhasznalasiHely;
            Karpitozott = karpitozott;
            NemKarpitozott = nemKarpitozott;
        }
        #endregion

        #region METHODS
        #endregion
    }
}
