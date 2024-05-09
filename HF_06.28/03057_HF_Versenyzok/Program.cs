using System;

namespace _03057_HF_Versenyzok
{
    internal class Program
    {
        struct Versenyzok
        {
            public string nev;
            public int elertPont;
            public int versenyAzonosito;
        }
        static void Main(string[] args)
        {
            //"Készítsen programot, mely segít a felhasználónak egy verseny eredményeinek kiértékelésében.
            //A program induláskor bekéri a versenyzők adatait(Név, Elért pont, Verseny azonosító), majd sorba állítja őket, az elért pontszám szerint.
            //A program ezután billentyű leütésre vár:
            //Amennyiben „L” betűt nyomnak le, kiadja a sorba rendezett versenyzőket.
            //Amennyiben „D” betűt nyomnak le, kiadja a 3 dobogós adatait.
            //Amennyiben „A” betűt nyomnak le, kiadja az átlag pontszámot.
            //Amennyiben „K” betűt nyomnak le, kilép.
            //A program csak a „K” billentyűre lép ki, tehát amíg le nem nyomják, addig lehetőség van a fent említett funkciók elérésére."

            Console.WriteLine("Kerem adja meg a versenyzok szamat:");
            int versenyzokSzama;
            while (int.TryParse(Console.ReadLine(), out versenyzokSzama) == false || versenyzokSzama <= 0)
            {
                Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot adjon meg!");
            }

            Versenyzok[] versenyzok = new Versenyzok[versenyzokSzama];

            for (int i = 0; i < versenyzok.Length; i++)
            {
                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. versenyzo nevet:");
                while ((versenyzok[i].nev = Console.ReadLine().Trim()) == "")
                {
                    Console.WriteLine("A A beirt adat nem megfelelo! Kerem helyes adatot adjon meg!");
                }

                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. versenyzo elert pontszamat:");
                while (int.TryParse(Console.ReadLine(), out versenyzok[i].elertPont) == false || versenyzok[i].elertPont < 0)
                {
                    Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot adjon meg!");
                }

                Console.WriteLine($"Kerem adja meg a(z) {i + 1}. versenyzo verseny azonositojat:");
                while (int.TryParse(Console.ReadLine(), out versenyzok[i].versenyAzonosito) == false || versenyzok[i].versenyAzonosito <= 0)
                {
                    Console.WriteLine("A beirt adat nem megfelelo! Kerem helyes adatot adjon meg!");
                }
            }

            //Egyszeru cseres rendezes
            for (int i = 0; i < versenyzok.Length - 1; i++)
            {
                for (int j = i + 1; j < versenyzok.Length; j++)
                {
                    if (versenyzok[i].elertPont < versenyzok[j].elertPont)
                    {
                        Versenyzok temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }

            //Neten talalt megoldas, de itt meg nem tartunk, ezert az eddig tanultak alapjan oldottam meg.
            //Array.Sort<Versenyzok>(versenyzok, (x, y) => y.elertPont.CompareTo(x.elertPont));

            for (int i = 0; i < versenyzok.Length; i++)
            {
                Console.WriteLine(versenyzok[i].elertPont);
            }


            Console.WriteLine("Kerem, adja meg, hogy milyen muveletet szeretne vegrahajtani:\nL - sorba rendezett versenyzok megjelenitese\nD - a harom dobogos adatai\nA - a versenyzok atlag pontszama\nK - kilepes a programbol");
            char muvelet;
            do
            {
                muvelet = Console.ReadKey().KeyChar;
                switch (muvelet.ToString().ToUpper())
                {
                    case "L":
                        SorbaRendezettVersenyzokMegjelenitese(versenyzok);
                        break;
                    case "D":
                        DobogosokAdatai(versenyzok);
                        break;
                    case "A":
                        VersenyzokAtlagPontszama(versenyzok);
                        break;
                }

            } while (muvelet.ToString().ToUpper() != "K");

        }

        static void SorbaRendezettVersenyzokMegjelenitese(Versenyzok[] versenyzok)
        {
            foreach (var versenyzo in versenyzok)
            {
                Console.WriteLine($"\nNev: {versenyzo.nev}, elert pontszam: {versenyzo.elertPont}, verseny azonositoja: {versenyzo.versenyAzonosito}");
            }
        }

        static void DobogosokAdatai(Versenyzok[] versenyzok)
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"\nNev: {versenyzok[i].nev}, elert pontszam: {versenyzok[i].elertPont}, verseny azonositja: {versenyzok[i].versenyAzonosito}");
            }
        }

        static void VersenyzokAtlagPontszama(Versenyzok[] versenyzok)
        {
            double atlag = 0;
            for (int i = 0; i < versenyzok.Length; i++)
            {
                atlag += versenyzok[i].elertPont;
            }

            Console.WriteLine($"\nA versenyzok atlag pontszama: {atlag / versenyzok.Length}");
        }
    }
}
