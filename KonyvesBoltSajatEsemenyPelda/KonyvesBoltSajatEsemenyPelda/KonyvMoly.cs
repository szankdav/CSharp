using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvesBoltSajatEsemenyPelda
{
    delegate void KonyvVasarlasEredmenyEsemenyKezelo(KonyvMoly moly, Konyv konyv, string uzenet);
    internal class KonyvMoly
    {
        public event KonyvVasarlasEredmenyEsemenyKezelo KonyvVasarlasEredmenyEsemeny;

        #region PRIVATE FIELDS
        string nev;
        int vagyon;
        KonyvTipus kedvenc;
        List<Konyv> sajatKonyvek;
        #endregion

        #region PUBLIC PROPERTIES
        public string Nev
        {
            get => nev;
            private set
            {
                if (value.Trim().Length >= 3) { nev = value; }
                else { throw new ArgumentException("A nev nem megfelelo!"); }
            }
        }
        public int Vagyon
        {
            get => vagyon;
            private set
            {
                if (value >= 5000 && value <= int.MaxValue) { vagyon = value; }
                else { throw new ArgumentException("Az vagyon nem megfelelo!"); }
            }
        }
        internal KonyvTipus Kedvenc
        {
            get => kedvenc;
            private set
            {
                if (Enum.IsDefined(typeof(KonyvTipus), value)) { kedvenc = value; }
                else { throw new ArgumentException("A kedvenc tipus nem megfelelo!"); }
            }
        }
        internal List<Konyv> SajatKonyvek
        {
            get { List<Konyv> sajatKonyvekMasolat = new List<Konyv>(); foreach (Konyv item in sajatKonyvek) { sajatKonyvekMasolat.Add(item); } return sajatKonyvekMasolat; }
            private set => sajatKonyvek = value;
        }
        #endregion

        #region CONSTRUCTORS
        public KonyvMoly(string nev, int vagyon, KonyvTipus kedvenc)
        {
            Nev = nev;
            Vagyon = vagyon;
            Kedvenc = kedvenc;
            sajatKonyvek = new List<Konyv>();
        }
        #endregion

        #region METHODS
        public void UjKonyvErkezettABoltba(Konyv uj)
        {
            if (uj.Darab > 0 && uj.Ar <= this.vagyon && uj.Tipus == this.kedvenc)
            {
                sajatKonyvek.Add(uj);
                KonyvVasarlasEredmenyEsemeny?.Invoke(this, uj, "A konyvet megvettem.");
                uj.Darab--;
                this.vagyon -= uj.Ar;
            }
            else if (uj.Darab == 0 && uj.Ar <= this.vagyon && uj.Tipus == this.kedvenc)
            {
                KonyvVasarlasEredmenyEsemeny?.Invoke(this, uj, "A konyv elfogyott.");
            }
            else if (uj.Darab > 0 && uj.Ar > this.vagyon && uj.Tipus == this.kedvenc)
            {
                KonyvVasarlasEredmenyEsemeny?.Invoke(this, uj, "A konyvre nem volt penzem.");
            }
            else if (uj.Darab > 0 && uj.Ar <= this.vagyon && uj.Tipus != this.kedvenc)
            {
                KonyvVasarlasEredmenyEsemeny?.Invoke(this, uj, "A konyv nem a kedvenc tipusomba tartozik.");
            }
        }
        public override string ToString()
        {
            return $"{nev}";
        }
        #endregion
    }
}
