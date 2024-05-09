using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05057_HF_ElektronikaiÁruház
{
    internal class Termek
    {
        #region PRIVATE FIELDS
        private string gyartoField;
        private string termekNevField;
        private uint arField;
        private string cikkszamField;
        #endregion

        #region PROPERTIES
        public string GyartoField { get => gyartoField; set => gyartoField = value; }
        public string TermekNevField { get => termekNevField; set => termekNevField = value; }
        public uint ArField { get => arField; set => arField = value; }
        public string CikkszamField { get => cikkszamField; set => cikkszamField = value; }
        #endregion

        #region CONSTRUCTORS
        public Termek(string gyartoField, string termekNevField, uint arField, string cikkszamField)
        {
            if (gyartoField.Length > 5 && gyartoField.Trim() != "")
            {
                GyartoField = gyartoField;
            }
            else
            {
                throw new ArgumentException("HIBA! A gyartonak minimum 5 karakternek kell lennie, es a mezo nem lehet ures!");
            }

            if (termekNevField.Length > 5 && termekNevField.Trim() != "")
            {
                TermekNevField = termekNevField;
            }
            else
            {
                throw new ArgumentException("HIBA! A termeknevnek minimum 5 karakternek kell lennie, es a mezo nem lehet ures!");
            }

            if (arField > 1)
            {
                ArField = arField;
            }
            else
            {
                throw new ArgumentException("HIBA! Az arnak minimum 1-nek kell lennie, es a mezo nem lehet ures!");
            }

            if (cikkszamField.Length == 10 && cikkszamField.Substring(0, 3).ToUpper() == termekNevField.Substring(0, 3).ToUpper() && cikkszamField.Substring(4) == DateTime.Now.ToString("yyMMdd") && cikkszamField.Trim() != "")
            {
                CikkszamField = cikkszamField;
            }
            else
            {
                throw new ArgumentException("HIBA! A cikkszam formatuma nem megfelelo! A helyes formatum: <rövid megnevezés 3 karakter, UpperCase> <_> <aktuális napi dátum eeHHnn formátumban>, valamint a mezo nem lehet ures!");
            }
            
        }
        #endregion

        #region METHODS
        public static void TermekFeltolto(string keszletFile)
        {
            int felvinniKivantTermekekDarabszama;
            Console.WriteLine("Kerem, adja meg hany termeket szeretne felvinni:");
            while (int.TryParse(Console.ReadLine(), out felvinniKivantTermekekDarabszama) == false || felvinniKivantTermekekDarabszama < 0)
            {
                Console.WriteLine("HIBA! A megadott adat nem pozitiv, egesz szam, vagy a mezo ures!");
            }
            try
            {
                StreamWriter ujKeszletFile = new StreamWriter(keszletFile, true, Encoding.UTF8);
                Termek[] termekek = new Termek[felvinniKivantTermekekDarabszama];
                for (int i = 0; i < termekek.Length; i++)
                {
                    Console.WriteLine($"Kerem, adja meg a(z) {i + 1}. termek gyartojat:");
                    string akutalisGyarto = Console.ReadLine();
                    Console.WriteLine($"Kerem, adja meg a(z) {i + 1}. termek megnevezeset:");
                    string aktualisMegnevezes = Console.ReadLine();
                    Console.WriteLine($"Kerem, adja meg a(z) {i + 1}. termek arat:");
                    uint aktualisAr;
                    while (uint.TryParse(Console.ReadLine(), out aktualisAr) == false)
                    {
                        Console.WriteLine("HIBA! Kerem, pozitiv, egesz szamot adjon meg!");
                    }
                    Console.WriteLine($"Kerem, adja meg a(z) {i + 1}. termek cikkszamat: (felépítése: <rövid megnevezés 3 karakter, UpperCase> <_> <aktuális napi dátum eeHHnn formátumban>)");
                    string aktualisCikkszam = Console.ReadLine();
                    termekek[i] = new Termek(akutalisGyarto, aktualisMegnevezes, aktualisAr, aktualisCikkszam);

                    ujKeszletFile.WriteLine($"{termekek[i].GyartoField};{termekek[i].TermekNevField};{termekek[i].ArField};{termekek[i].CikkszamField}");
                    ujKeszletFile.Flush();
                }
                ujKeszletFile.Close();
                char keresesValasz = '\0';
                Console.WriteLine("A termekek feltoltese sikeres! Szeretne keresni a keszlet.csv fajlban cikkszam alapjan? (I/N)");
                while(char.TryParse(Console.ReadLine(),out keresesValasz) == false || keresesValasz.ToString().Trim() == "" || (keresesValasz.ToString().ToUpper().Trim() != "I" && keresesValasz.ToString().ToUpper().Trim() != "N"))
                {
                    Console.WriteLine("HIBA! Kerem, igennel (I) vagy nemmel (N) valaszoljon!");
                }
                if (keresesValasz.ToString().ToUpper().Trim() == "I")
                {
                    Termek.Cikkszamkereso(termekek);
                }
                else if (keresesValasz.ToString().ToUpper().Trim() == "N")
                {
                    Console.WriteLine("A program kilep! Viszontlatasra!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void Cikkszamkereso(Termek[] termekek)
        {
            Console.WriteLine("Kerem irja be a keresett cikszamot! A helyes formatum: <rövid megnevezés 3 karakter, UpperCase> <_> <aktuális napi dátum eeHHnn formátumban>:");
            string keresettCikkszam = Console.ReadLine();
            if (keresettCikkszam.Trim().Length != 10 || keresettCikkszam.Substring(3, 1) != "_")
            {
                do
                {
                    Console.WriteLine("HIBA! A formatum nem helyes! Kerem, adjon meg egy masik cikkszamot:");
                    keresettCikkszam = Console.ReadLine();
                } while (keresettCikkszam.Trim().Length != 10 || keresettCikkszam.Substring(3, 1) != "_");
            }
            for (int i = 0; i < termekek.Length; i++)
            {
                if (termekek[i].CikkszamField == keresettCikkszam && i < termekek.Length)
                {
                    Console.WriteLine("A keresett termek adatai:");
                    Console.WriteLine($"Gyarto: {termekek[i].GyartoField}, Termekmegnevezes: {termekek[i].TermekNevField}, Ar: {termekek[i].ArField}, Cikkszam: {termekek[i].CikkszamField}");
                    Termek.CikkszamUjrakereso(termekek);
                }
                else if (i > termekek.Length)
                {
                    Console.WriteLine("A keresett cikkszammal nem talalhato termek!");
                    Termek.CikkszamUjrakereso(termekek);
                }
            }
        }

        public static void CikkszamUjrakereso(Termek[] termekek)
        {
            Console.WriteLine("Szeretne masik cikkszamot keresni? (I/N)");
            char valasz = '\0';
            while (char.TryParse(Console.ReadLine(), out valasz) == false || valasz.ToString().Trim() == "" || (valasz.ToString().ToUpper().Trim() != "I" && valasz.ToString().ToUpper().Trim() != "N"))
            {
                Console.WriteLine("HIBA! Kerem, igennel (I) vagy nemmel (N) valaszoljon!");
            }
            if (valasz.ToString().ToUpper().Trim() == "I")
            {
                Cikkszamkereso(termekek);
            }
            else if (valasz.ToString().ToUpper().Trim() == "N")
            {
                Console.WriteLine("A program kilep! Viszontlatasra!");
            }
        }
        #endregion
    }
}
