using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CSVLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Adatok bekerese es jelszo titkositasa
            Console.WriteLine("Kerem, adja meg a felhasznalonevet!");
            string nev = Console.ReadLine().Trim();
            Console.WriteLine("Kerem, adja meg a jelszot!");
            ConsoleColor foreColor = Console.ForegroundColor;
            Console.ForegroundColor = Console.BackgroundColor;
            string jelszo = Titkositas(Console.ReadLine().Trim());
            Console.ForegroundColor = foreColor;
            Console.Clear();

            // 2. CSV beolvasasa es az adatok osszehasonlitasa
            StreamReader file = new StreamReader("login.csv");
            bool auth = false;
            while (!file.EndOfStream && !auth)
            {
                string[] sor = file.ReadLine().Split(';');
                if (sor.Length == 2 && sor[0] == nev && sor[1] == jelszo)
                {
                    auth = true;
                }
            }
            if (auth)
            {
                Console.WriteLine("A belepes sikeres!");
            }
            else
            {
                Console.WriteLine("A belepes sikertelen!");
            }
            // 123456aA
            Console.ReadKey();
        }

        static string Titkositas(string jelszo)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] jelszoByte = Encoding.UTF8.GetBytes(jelszo);
            byte[] crypted = sha1.ComputeHash(jelszoByte);
            string jelszoTitkos = BitConverter.ToString(crypted).Replace("-", "").ToLower();
            return jelszoTitkos;
        }
    }
}
