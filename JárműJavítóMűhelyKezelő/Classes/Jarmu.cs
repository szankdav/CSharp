using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal abstract class Jarmu
    {
        #region PRIVATE FIELDS
        int muhelyId;
        string azonositoSzam;
        string rendszam;
        DateTime gyartasEve;
        string marka;
        string szarmazasiOrszag;
        bool hasznalt;
        int javitasAra;
        #endregion

        #region PUBLIC PROPERTIES
        public int MuhelyId
        {
            get => muhelyId; 
            protected set => muhelyId = value; 
        }
        public string AzonositoSzam
        {
            get => azonositoSzam;
            set
            {
                if (!string.IsNullOrEmpty(value) && ((value.Substring(0,3) == "SZE" || value.Substring(0, 3) == "TEH") && int.TryParse(value.Substring(3), out int szam))) { azonositoSzam = value; }
                else { throw new ArgumentException("Az azonosito nem lehet ures, es megfelelo felepitesunek kell lennie! (XXX12345)"); }
            }
        }
        public string Rendszam
        {
            get => rendszam;
            set
            {
                if (!string.IsNullOrEmpty(value)) { rendszam = value; }
                else { throw new ArgumentException("A rendszam nem lehet ures!"); }
            }
        }
        public DateTime GyartasEve
        {
            get => gyartasEve;
            set
            {
                if (value.CompareTo(DateTime.Today.Year) < 1) { gyartasEve = value; }
                else { throw new ArgumentException("A gyartasi ev nem lehet a jelenlegi evszamnal magasabb, es nem lehet ures!"); }
            }
        }
        public string Marka
        {
            get => marka;
            set
            {
                if (!string.IsNullOrEmpty(value)) { marka = value; }
                else { throw new ArgumentException("A marka nem lehet ures!"); }
            }
        }
        public string SzarmazasiOrszag
        {
            get => szarmazasiOrszag;
            set
            {
                if (!string.IsNullOrEmpty(value)) { szarmazasiOrszag = value; }
                else { throw new ArgumentException("A szarmazasi orszag nem lehet ures!"); }
            }
        }
        public bool Hasznalt
        {
            get => hasznalt;
            set => hasznalt = value;
        }
        public int JavitasAra
        {
            get => javitasAra;
            set
            {
                if (value > 0) { javitasAra = value; }
                else { throw new ArgumentException("A javitas ara nem lehet 0 vagy alacsonyabb!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        protected Jarmu(int muhelyId, string azonositoSzam, string rendszam, DateTime gyartasEve, string marka, string szarmazasiOrszag, bool hasznalt, int javitasAra)
        {
            MuhelyId = muhelyId;
            AzonositoSzam = azonositoSzam;
            Rendszam = rendszam;
            GyartasEve = gyartasEve;
            Marka = marka;
            SzarmazasiOrszag = szarmazasiOrszag;
            Hasznalt = hasznalt;
            JavitasAra = javitasAra;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Muhely ID: {MuhelyId}, Azonositoszam: {AzonositoSzam}, Rendszam: {Rendszam}, Gyartas eve: {GyartasEve}, Marka: {Marka}, Szarmazasi orszag: {SzarmazasiOrszag}, Hasznalt: {(Hasznalt ? "Igen" : "Nem")}, Javitas ara: {JavitasAra}";
        }
        #endregion

    }
}
