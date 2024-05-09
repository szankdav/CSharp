using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gepjarmuvek
{
    public abstract class Gepjarmu
    {
        #region PRIVATE FIELDS
        string rendszam;
        uint futottKM;
        bool kolcsonzesiAllapot;
        Felhasznalo kolcsonzoFelhasznalo;
        DateTime kolcsonzesIdeje;
        #endregion

        #region PUBLIC PROPERTIES
        public string Rendszam
        {
            get => rendszam;
            set
            {
                if (value.Trim().Length == 6 || value.Trim().Length == 7) { rendszam = value; }
                else { throw new ArgumentException("A rendszámnak 6 vagy 7 karakterből kell állnia!"); }
            }
        }
        public uint FutottKM
        {
            get => futottKM;
            set
            {
                if (value >= 0 && value < uint.MaxValue) { futottKM = value; }
                else { throw new ArgumentException($"A futott kilométer nem lehet kisebb, mint 0 és nem lehet nagyobb, mint {uint.MaxValue}"); }
            }
        }
        public bool KolcsonzesiAllapot
        {
            get => kolcsonzesiAllapot;
            set => kolcsonzesiAllapot = value;
        }
        public Felhasznalo KolcsonzoFelhasznalo { get => kolcsonzoFelhasznalo; set => kolcsonzoFelhasznalo = value; }
        public DateTime KolcsonzesIdeje { get => kolcsonzesIdeje; set => kolcsonzesIdeje = value; }
        #endregion

        #region CONSTRUCTORS
        protected Gepjarmu(string rendszam, uint futottKM, bool kolcsonzesiAllapot)
        {
            Rendszam = rendszam;
            FutottKM = futottKM;
            KolcsonzesiAllapot = kolcsonzesiAllapot;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Rendszám: {rendszam} - Futott KM: [{futottKM}] - Kölcsönzési állapot: {(kolcsonzesiAllapot ? "Kikölcsönözve" : "Elérhető")}";
        }

        public string GepjarmuCSVMentes()
        {
            return $"{rendszam};{futottKM};{(kolcsonzesiAllapot ? "1" : "0")}";
        }

        public static Gepjarmu GepjarmuCSVBetoltes(string CSVSor)
        {
            Gepjarmu beolvasottJarmu;
            string[] sorAdatai = CSVSor.Split(';');
            if (sorAdatai.Length == 5)
            {
                try
                {
                    if (sorAdatai[4] == "A")
                    {
                        beolvasottJarmu = new Auto(sorAdatai[0], uint.Parse(sorAdatai[1]), (sorAdatai[2] == "0" ? false : true), (MotorTipus)int.Parse(sorAdatai[3].Trim()));
                    }
                    else if (sorAdatai[4] == "M")
                    {
                        beolvasottJarmu = new Motor(sorAdatai[0], uint.Parse(sorAdatai[1]), (sorAdatai[2] == "0" ? false : true), ushort.Parse(sorAdatai[3]));
                    }
                    else
                    {
                        throw new ArgumentException($"A jármű fajtája nem megfelelő!");
                    }
                }
                catch (Exception ex)
                {
                    throw new ArgumentException($"A fájl felépítése nem megfelelő! - {ex.Message}");
                }
            }
            else
            {
                throw new Exception("A fájl tartalma nem megfelelő!");
            }
            return beolvasottJarmu;
        }
        #endregion

    }
}
