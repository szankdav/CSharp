using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButorKeszletManager
{
    enum FelhasznaltFaTipusa
    {
        Gesztenye,
        Mamutfenyo,
        Papireperfa,
        Tulipanfa,
        Fikusz,
        Tolgy,
        Berkenye,
        Koris,
        Korte,
        Egyeb
    }
    internal class FaButor : Butor
    {
        #region PRIVATE FIELDS
        FelhasznaltFaTipusa felhasznaltFaTipusa;
        bool kezelt;
        bool kezeletlen;
        int suly;
        #endregion

        #region PUBLIC PROPERTIES
        public bool Kezelt { get => kezelt; set => kezelt = value; }
        public bool Kezeletlen { get => kezeletlen; set => kezeletlen = value; }
        public int Suly
        {
            get => suly;
            set
            {
                if (value >= 1)
                {
                    suly = value;
                }
                else
                {
                    throw new ArgumentException("A sulynak minimum 1 kg-nak kell lennie!");
                }
            }
        }
        internal FelhasznaltFaTipusa FelhasznaltFaTipusa
        {
            get => felhasznaltFaTipusa;
            set
            {
                if (Enum.IsDefined(typeof(FelhasznaltFaTipusa), value))
                {
                    felhasznaltFaTipusa = value;
                }
                else
                {
                    throw new ArgumentException("A felhasznalt fa tipusa nem megfelelo!");
                }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public FaButor(string gyartoNeve, string azonosito, int magassag, int hosszusag, int szelesseg) : base(gyartoNeve, azonosito, magassag, hosszusag, szelesseg)
        {
        }
        #endregion

        #region METHODS
        #endregion
        public override int Kalkulator()
        {
            return (1 / Magassag) * (Szelesseg + Hosszusag);
        }
    }
}
