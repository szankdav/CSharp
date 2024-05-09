using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPelda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nagyobb = ANagyobbEsOsszead(3, 6, out int result);
            Console.WriteLine($"Az elso operandus erteke: {(nagyobb ? "nagyobb" : "kisebb vagy egyenlo")}, mint a masodik operandus erteke. Egyebkent az osszeguk: {result}");

            bool palindrom = Palindrom("indul a gorog aludni", out string tukor);
            Console.WriteLine($"A megadott szoveg: {(palindrom ? $"Palindrom es a tukor szoveg: {tukor}" : "nem Palindrom")}");

            //int szam = int.Parse("15");
            //szam = int.Parse("abcd"); Hibat dob, nekem kell lekezelni, kulonben a program lefekszik.
            if (int.TryParse(Console.ReadLine(), out int szam))
            {
                Console.WriteLine($"Amit megadtal, az szamkent (int) ertelmezheto es megduplazva: {szam * 2}");
            }
            else
            {
                Console.WriteLine("Amit megadtal, az nem ertelmezheto szamkent!");
            }

            Console.ReadKey();
        }

        static bool ANagyobbEsOsszead(int a, int b, out int eredmeny)
        {
            eredmeny = a + b;
            return a > b;
        }

        static bool Palindrom(string szoveg, out string tukorBaloldal)
        {
            szoveg = szoveg.ToLower().Replace(" ", "");
            string tukor = "";
            foreach (char item in szoveg.Reverse())
            {
                tukor += item;
            }
            if (szoveg == tukor)
            {
                tukorBaloldal = szoveg.Substring(0, (int)Math.Ceiling(szoveg.Length * 1.0 / 2));
                return true;
            }
            else
            {
                tukorBaloldal = null;
                return false;
            }
        }
    }
    class Pelda
    {
        int a;
        int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; private set => b = value; }

        public Pelda(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}