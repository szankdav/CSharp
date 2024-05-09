using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal class Teherauto : Jarmu
    {
        #region PRIVATE FIELDS
        string kialakitas;
        bool utanfutos;
        #endregion

        #region PUBLIC PROPERTIES
        public string Kialakitas
        {
            get => kialakitas;
            set
            {
                if (!string.IsNullOrEmpty(value)) { kialakitas = value; }
                else { throw new ArgumentException("A kialakitas nem lehet ures!"); }
            }
        }
        public bool Utanfutos { get => utanfutos; set => utanfutos = value; }
        #endregion

        #region CONSTRUCTORS
        public Teherauto(string kialakitas, bool utanfutos, int muhelyId, string azonositoSzam, string rendszam, DateTime gyartasEve, string marka, string szarmazasiOrszag, bool hasznalt, int javitasAra) : base(muhelyId, azonositoSzam, rendszam, gyartasEve, marka, szarmazasiOrszag, hasznalt, javitasAra)
        {
            Kialakitas = kialakitas;
            Utanfutos = utanfutos;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{base.ToString()}, Kialakitas: {Kialakitas}, Utanfutos: {(Utanfutos ? "Igen" : "Nem")}";
        }
        #endregion

    }
}
