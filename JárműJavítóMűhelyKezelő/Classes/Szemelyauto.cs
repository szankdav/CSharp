using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal class Szemelyauto : Jarmu
    {
        #region PRIVATE FIELDS
        string kialakitas;
        bool muszakiMiattiJavitas;
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
        public bool MuszakiMiattiJavitas { get => muszakiMiattiJavitas; set => muszakiMiattiJavitas = value; }
        #endregion

        #region CONSTRUCTORS
        public Szemelyauto(string kialakitas, bool muszakiMiattiJavitas, int muhelyId, string azonositoSzam, string rendszam, DateTime gyartasEve, string marka, string szarmazasiOrszag, bool hasznalt, int javitasAra) : base(muhelyId, azonositoSzam, rendszam, gyartasEve, marka, szarmazasiOrszag, hasznalt, javitasAra)
        {
            Kialakitas = kialakitas;
            MuszakiMiattiJavitas = muszakiMiattiJavitas;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"{base.ToString()}, Kialakitas: {Kialakitas}, Muszaki miatti javitas: {(MuszakiMiattiJavitas ? "Igen" : "Nem")}";
        }
        #endregion

    }
}
