using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gepjarmuvek
{
    //public delegate void GepjarmuKolcsonzesEredmenyEsemenyKezelo(Felhasznalo felhasznalo, Gepjarmu jarmu, DateTime kolcsonzesIdeje);
    public class Felhasznalo
    {
        //public event GepjarmuKolcsonzesEredmenyEsemenyKezelo GepjarmuKolcsonzesEredmenyEsemeny;

        #region PRIVATE FIELDS
        string nev;
        string felhasznaloJelszo;
        //List<Gepjarmu> kikolcsonzottJarmuvek;
        #endregion

        #region PUBLIC PROPERTIES
        public string Nev
        {
            get => nev;
            set
            {
                if (value.Trim().Length > 0) { nev = value; }
                else { throw new ArgumentException("A név értéke nem megfelelő!"); }
            }
        }
        public string FelhasznaloJelszo
        {
            get => felhasznaloJelszo;
            set
            {
                string regexPattern = @"(\d{4})";
                Regex regex = new Regex(regexPattern);
                if (regex.IsMatch(value)) { felhasznaloJelszo = value; }
                else { throw new ArgumentException("A felhasználói kódnak 4 számjegyből kell állnia!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Felhasznalo(string nev, string felhasznaloJelszo)
        {
            Nev = nev;
            FelhasznaloJelszo = felhasznaloJelszo;
            //kikolcsonzottJarmuvek = new List<Gepjarmu>();
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"Felhasználó neve: {nev} - kódja: [{felhasznaloJelszo}]";
        }

        public string FelhasznaloCSVMentes()
        {
            return $"{nev};{felhasznaloJelszo}";
        }

        public static Felhasznalo felhasznaloCSVBetoltes(string CSVsor)
        {
            Felhasznalo beolvasottFelhasznalo;
            string[] sorAdatai = CSVsor.Split(';');

            if (sorAdatai.Length == 2)
            {
                try
                {
                    beolvasottFelhasznalo = new Felhasznalo(sorAdatai[0], sorAdatai[1]);
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
            return beolvasottFelhasznalo;
        }

        //DateTime kolcsonzesIdeje;
        //public void GepjarmuKolcsonzes(Gepjarmu jarmu)
        //{
        //    if (jarmu.KolcsonzesiAllapot == false)
        //    {
        //        kikolcsonzottJarmuvek.Add(jarmu);
        //        kolcsonzesIdeje = DateTime.Now.Date;
        //    }
        //    else
        //    {
        //        GepjarmuKolcsonzesEredmenyEsemeny?.Invoke(this, jarmu, kolcsonzesIdeje);
        //    }
        //}
        #endregion

    }
}
