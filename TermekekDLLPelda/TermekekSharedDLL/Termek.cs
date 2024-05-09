using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermekekSharedDLL
{
    public enum TermekTipus
    {
        Hardver,
        Szoftver
    }
    public class Termek
    {
        #region PRIVATE FIELDS
        string gyarto, megnevezes;
        uint ar, darabSzam;
        TermekTipus tipus;
        #endregion

        #region PUBLIC PROPERTIES
        public string Gyarto
        {
            get => gyarto;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length <= 50) { gyarto = value; }
                else { throw new ArgumentException("A gyarto neve nem megfelelo!\nJavaslat: A gyarto neve nem lehet ures, es maximum 50 karakter lehet."); }
            }
        }
        public string Megnevezes
        {
            get => megnevezes;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Trim().Length <= 50) { megnevezes = value; }
                else { throw new ArgumentException("A megnevezes nem megfelelo!\nJavaslat: A megnevezes nem lehet ures, es maximum 50 karakter lehet."); }
            }
        }
        public uint Ar
        {
            get => ar;
            set
            {
                if (value > 0 && value <= uint.MaxValue) { ar = value; }
                else { throw new ArgumentException($"Az ar nem megfelelo!\nJavaslat: Az ar nem lehet 0, es maximum {uint.MaxValue} lehet."); }
            }
        }
        public uint DarabSzam
        {
            get => darabSzam;
            set
            {
                if (value > 0 && value <= uint.MaxValue) { darabSzam = value; }
                else { throw new ArgumentException($"A darabszam nem megfelelo!\nJavaslat: A darabszam nem lehet 0, es maximum {uint.MaxValue} lehet."); }
            }
        }
        public TermekTipus Tipus
        {
            get => tipus;
            set
            {
                if (Enum.IsDefined(typeof(TermekTipus), value)) { tipus = value; }
                else { throw new ArgumentException("A termek tipusa nem megfelelo!"); }
            }
        }
        #endregion

        #region CONSTRUCTORS
        public Termek(string gyarto, string megnevezes, uint ar, uint darabSzam, TermekTipus tipus)
        {
            Gyarto = gyarto;
            Megnevezes = megnevezes;
            Ar = ar;
            DarabSzam = darabSzam;
            Tipus = tipus;
        }
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="csvInput"></param>
        ///// <param name="szeparator"></param>
        public Termek(string csvInput, char szeparator)
        {
            if (szeparator == ',' || szeparator == ';' || szeparator == '|')
            {
                string[] sor = csvInput.Split(szeparator);
                if (sor.Length == 5)
                {
                    try
                    {
                        Gyarto = sor[0].Trim();
                        Megnevezes = sor[1].Trim();
                        Ar = uint.Parse(sor[2].Trim());
                        DarabSzam = uint.Parse(sor[3].Trim());
                        Tipus = (TermekTipus)int.Parse(sor[4].Trim());
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException($"A fajl felepitese nem megfelelo! {ex.Message}");
                    }
                }
                else
                {
                    throw new ArgumentException("A fajl felepitese nem megfelelo! Az adat mennyisege rossz.");
                }
            }
            else
            {
                throw new ArgumentException("A fajl felepitese nem megfelelo! Rossz szeparator.");
            }
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return $"[{gyarto} - {megnevezes}] | Ar: {ar}, Darabszam: {darabSzam}, Tipus: {tipus}";
        }

        public string ToCSV(char szeparator)
        {
            if (szeparator == ',' || szeparator == ';' || szeparator == '|')
            {
                return $"{gyarto}{szeparator}{megnevezes}{szeparator}{ar}{szeparator}{darabSzam}{szeparator}{(int)tipus}";
            }
            else
            {
                throw new ArgumentException("CSV letrehozasa nem lehetseges! Rossz szeparator.");
            }

        }
        #endregion
    }
}
