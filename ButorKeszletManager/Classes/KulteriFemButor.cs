using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    enum ButorAnyag
    {
        Aluminium,
        Acel,
        Egyeb
    }
    internal class KulteriFemButor : FemButor
    {
        #region PRIVATE FIELDS
        ButorAnyag butorAnyaga;
        bool karfas;
        bool nemKarfas;
        #endregion

        #region PUBLIC PROPERTIES
        public bool Karfas
        {
            get => karfas;
            set => karfas = value;
        }
        public bool NemKarfas
        {
            get => nemKarfas;
            set => nemKarfas = value;
        }
        internal ButorAnyag ButorAnyaga
        {
            get => butorAnyaga;
            set
            {
                if (Enum.IsDefined(typeof(ButorAnyag), value))
                {
                    butorAnyaga = value;
                }
                else
                {
                    throw new ArgumentException("A butor anyaga nem megfelelo!");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public KulteriFemButor(string gyartoNeve, string azonosito, int magassag, int hosszusag, int szelesseg, int felhasznaltAnyagVastagsaga, bool hegesztett, bool csavarozott, ButorAnyag butorAnyaga, bool karfas, bool nemKarfas) : base(gyartoNeve, azonosito, magassag, hosszusag, szelesseg, felhasznaltAnyagVastagsaga, hegesztett, csavarozott)
        {
            ButorAnyaga = butorAnyaga;
            Karfas = karfas;
            NemKarfas = nemKarfas;
        }
        #endregion

        #region METHODS
        #endregion
    }
}
