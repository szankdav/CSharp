using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokFajlbolOOP
{
    internal class TanuloCls
    {
        #region PRIVATE FIELDS
        string nevField;
        double atlagField;
        long adoAzonositoJelField;
        #endregion

        #region PUBLIC PROPERTIES
        public string NevProperty
        {
            get => nevField;
            set
            {
                if (value.Trim().Length >= 4) { nevField = value; }
                else { throw new Exception("A NEV erteke nem megfelelo, mert minimum 4 karakter kell, hogy legyen!"); }
            }
        }
        public double AtlagProperty
        {
            get => atlagField;
            set
            {
                if (value >= 1 && value <= 5) { atlagField = value; }
                else { throw new ArgumentException("Az atlag erteke nem megfelelo, mert az ertek 1 es 5 kozott kell, hogy legyen!"); }
            }
        }
        public long AdoAzonositoJelProperty
        {
            get => adoAzonositoJelField;
            set
            {
                if (AdoAzonositoEllenorzo(value)) { adoAzonositoJelField = value; }
                else { throw new ArgumentException("A szemelyazonosito szam erteke nem megfelelo, mert 8-assal kell kezdodnie, csak szamokbol allhat, es pontosan 10 karakter kell, hogy legyen!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public TanuloCls(string nevBejovo, double atlagBejovo, long adoAzonositoJelBejovo)
        {
            NevProperty = nevBejovo;
            AtlagProperty = atlagBejovo;
            AdoAzonositoJelProperty = adoAzonositoJelBejovo;
        }

        public TanuloCls(string textSor)
        {
            string[] adatok = textSor.Split(';');
            NevProperty = adatok[0];

            if (double.TryParse(adatok[1], out double bejovoAtlag))
            {
                AtlagProperty = double.Parse(adatok[1]);
            }
            else
            {

            }
            if (long.TryParse(adatok[1], out long bejovoAdoAzonositoJel))
            {
                AdoAzonositoJelProperty = long.Parse(adatok[2]);
            }
            else
            {

            }
        }
        #endregion

        #region METHODS
        public double EvVegiKerekito()
        {
            return Math.Round(this.AtlagProperty);
        }

        private bool AdoAzonositoEllenorzo(long check)
        {
            if (check.ToString().Trim().StartsWith("8") && check.ToString().Trim().Length == 10)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public static double Atlagszamitas(TanuloCls[] adatok)
        {
            double atlag = 0;
            foreach (TanuloCls item in adatok)
            {
                atlag += item.AtlagProperty;
            }
            atlag /= adatok.Length;
            return atlag;
        }

        #endregion
    }
}
