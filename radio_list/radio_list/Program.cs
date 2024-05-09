using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace radio_list
{
    internal class Program
    {

        struct Adatok
        {
            public int napSzama;
            public int radiosSzama;
            public string uzenetSzovege;
        }
        static void Main(string[] args)
        {
            Adatok temp;
            string sor;
            StreamReader file = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\radio\\radio\\bin\\Debug\\_veetel.txt");
            List<Adatok> expedicio = new List<Adatok>();

            while (!file.EndOfStream)
            {
                sor = file.ReadLine();
                temp.napSzama = Convert.ToInt32(sor.Split(' ')[0]);
                temp.radiosSzama = Convert.ToInt32(sor.Split(' ')[1]);
                temp.uzenetSzovege = file.ReadLine();
                expedicio.Add(temp);
            }
            file.Close();

            Console.WriteLine("2. feladat:");

            Console.WriteLine($"Az elso uzenet rogzitoje; {expedicio[0].radiosSzama}");
            Console.WriteLine($"Az utolso uzenet rogzitoje; {expedicio[expedicio.Count - 1].radiosSzama}");

            Console.WriteLine("3. feladat:");

            foreach (Adatok s in expedicio)
            {
                string[] tempUzenetSzovege = s.uzenetSzovege.Split(' ');

                for (int i = 0; i < tempUzenetSzovege.Length; i++)
                {
                    if (tempUzenetSzovege[i].StartsWith("farkas"))
                    {
                        Console.WriteLine($"{s.napSzama}.nap {s.radiosSzama}. radioamator");
                    }
                }
            }

            Console.WriteLine("4. feladat:");

            int elsoNapSzamlalo = 0;
            int masodiknapSzamlalo = 0;
            int harmadikNapSzamlalo = 0;
            int negyedikNapSzamlalo = 0;
            int otodikNapSzamlalo = 0;
            int hatodikNapSzamlalo = 0;
            int hetedikNapSzamlalo = 0;
            int nyolcadikNapSzamlalo = 0;
            int kilencedikNapSzamlalo = 0;
            int tizedikNapSzamlalo = 0;
            int tizenegyedikNapSzamlalo = 0;

            foreach (Adatok s in expedicio)
            {
                if (s.napSzama == 1 && s.radiosSzama > 0)
                {
                    elsoNapSzamlalo++;
                }
                else if (s.napSzama == 2 && s.radiosSzama > 0)
                {
                    masodiknapSzamlalo++;
                }
                else if (s.napSzama == 3 && s.radiosSzama > 0)
                {
                    harmadikNapSzamlalo++;
                }
                else if (s.napSzama == 4 && s.radiosSzama > 0)
                {
                    negyedikNapSzamlalo++;
                }
                else if (s.napSzama == 5 && s.radiosSzama > 0)
                {
                    otodikNapSzamlalo++;
                }
                else if (s.napSzama == 6 && s.radiosSzama > 0)
                {
                    hatodikNapSzamlalo++;
                }
                else if (s.napSzama == 7 && s.radiosSzama > 0)
                {
                    hetedikNapSzamlalo++;
                }
                else if (s.napSzama == 8 && s.radiosSzama > 0)
                {
                    nyolcadikNapSzamlalo++;
                }
                else if (s.napSzama == 9 && s.radiosSzama > 0)
                {
                    kilencedikNapSzamlalo++;
                }
                else if (s.napSzama == 10 && s.radiosSzama > 0)
                {
                    tizedikNapSzamlalo++;
                }
                else if (s.napSzama == 11 && s.radiosSzama > 0)
                {
                    tizenegyedikNapSzamlalo++;
                }
            }

            Console.WriteLine($"1. nap: {elsoNapSzamlalo} radioamator");
            Console.WriteLine($"2. nap: {masodiknapSzamlalo} radioamator");
            Console.WriteLine($"3. nap: {harmadikNapSzamlalo} radioamator");
            Console.WriteLine($"4. nap: {negyedikNapSzamlalo} radioamator");
            Console.WriteLine($"5. nap: {otodikNapSzamlalo} radioamator");
            Console.WriteLine($"6. nap: {hatodikNapSzamlalo} radioamator");
            Console.WriteLine($"7. nap: {hetedikNapSzamlalo} radioamator");
            Console.WriteLine($"8. nap: {nyolcadikNapSzamlalo} radioamator");
            Console.WriteLine($"9. nap: {kilencedikNapSzamlalo} radioamator");
            Console.WriteLine($"10. nap: {tizenegyedikNapSzamlalo} radioamator");
            Console.WriteLine($"11. nap: {tizenegyedikNapSzamlalo} radioamator");

            Console.WriteLine("5. feladat:");

            List<string> elsoNapUzenetei = new List<string>();
            List<string> masodikNapUzenetei = new List<string>();
            List<string> harmadikNapUzenetei = new List<string>();
            List<string> negyedikNapUzenetei = new List<string>();
            List<string> otodikNapUzenetei = new List<string>();
            List<string> hatodikNapUzenetei = new List<string>();
            List<string> hetedikNapUzenetei = new List<string>();
            List<string> nyolcadikNapUzenetei = new List<string>();
            List<string> kilencedikNapUzenetei = new List<string>();
            List<string> tizedikNapUzenetei = new List<string>();
            List<string> tizenegyedikNapUzenetei = new List<string>();

            foreach (Adatok s in expedicio)
            {
                if (s.napSzama == 1)
                {
                    elsoNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 2)
                {
                    masodikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 3)
                {
                    harmadikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 4)
                {
                    negyedikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 5)
                {
                    otodikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 6)
                {
                    hatodikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 7)
                {
                    hetedikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 8)
                {
                    nyolcadikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 9)
                {
                    kilencedikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 10)
                {
                    tizedikNapUzenetei.Add(s.uzenetSzovege);
                }
                else if (s.napSzama == 11)
                {
                    tizenegyedikNapUzenetei.Add(s.uzenetSzovege);
                }
            }

            char[] elsoUzenetKarakterTomb = new char[90];
            char[] masodikUzenetKarakterTomb = new char[90];
            char[] harmadikUzenetKarakterTomb = new char[90];
            char[] negyedikUzenetKarakterTomb = new char[90];
            char[] otodikUzenetKarakterTomb = new char[90];
            char[] hatodikUzenetKarakterTomb = new char[90];
            char[] hetedikUzenetKarakterTomb = new char[90];
            char[] nyolcadikUzenetKarakterTomb = new char[90];
            char[] kilencedikUzenetKarakterTomb = new char[90];
            char[] tizedikUzenetKarakterTomb = new char[90];
            char[] tizenegyedikUzenetKarakterTomb = new char[90];

            for (int i = 0; i < elsoNapUzenetei.Count; i++)
            {
                for (int k = 0; k < elsoNapUzenetei[i].Length; k++)
                {
                    if (elsoNapUzenetei[i][k] != '#')
                    {
                        elsoUzenetKarakterTomb[k] = elsoNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < masodikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < masodikNapUzenetei[i].Length; k++)
                {
                    if (masodikNapUzenetei[i][k] != '#')
                    {
                        masodikUzenetKarakterTomb[k] = masodikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < harmadikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < harmadikNapUzenetei[i].Length; k++)
                {
                    if (harmadikNapUzenetei[i][k] != '#')
                    {
                        harmadikUzenetKarakterTomb[k] = harmadikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < negyedikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < negyedikNapUzenetei[i].Length; k++)
                {
                    if (negyedikNapUzenetei[i][k] != '#')
                    {
                        negyedikUzenetKarakterTomb[k] = negyedikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < otodikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < otodikNapUzenetei[i].Length; k++)
                {
                    if (otodikNapUzenetei[i][k] != '#')
                    {
                        otodikUzenetKarakterTomb[k] = otodikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < hatodikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < hatodikNapUzenetei[i].Length; k++)
                {
                    if (hatodikNapUzenetei[i][k] != '#')
                    {
                        hatodikUzenetKarakterTomb[k] = hatodikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < hetedikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < hetedikNapUzenetei[i].Length; k++)
                {
                    if (hetedikNapUzenetei[i][k] != '#')
                    {
                        hetedikUzenetKarakterTomb[k] = hetedikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < nyolcadikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < nyolcadikNapUzenetei[i].Length; k++)
                {
                    if (nyolcadikNapUzenetei[i][k] != '#')
                    {
                        nyolcadikUzenetKarakterTomb[k] = nyolcadikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < kilencedikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < kilencedikNapUzenetei[i].Length; k++)
                {
                    if (kilencedikNapUzenetei[i][k] != '#')
                    {
                        kilencedikUzenetKarakterTomb[k] = kilencedikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < tizedikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < tizedikNapUzenetei[i].Length; k++)
                {
                    if (tizedikNapUzenetei[i][k] != '#')
                    {
                        tizedikUzenetKarakterTomb[k] = tizedikNapUzenetei[i][k];
                    }
                }
            }

            for (int i = 0; i < tizenegyedikNapUzenetei.Count; i++)
            {
                for (int k = 0; k < tizenegyedikNapUzenetei[i].Length; k++)
                {
                    if (tizenegyedikNapUzenetei[i][k] != '#')
                    {
                        tizenegyedikUzenetKarakterTomb[k] = tizenegyedikNapUzenetei[i][k];
                    }
                }
            }

            Console.WriteLine(elsoUzenetKarakterTomb);
            Console.WriteLine(masodikUzenetKarakterTomb);
            Console.WriteLine(harmadikUzenetKarakterTomb);
            Console.WriteLine(negyedikUzenetKarakterTomb);
            Console.WriteLine(otodikUzenetKarakterTomb);
            Console.WriteLine(hatodikUzenetKarakterTomb);
            Console.WriteLine(hetedikUzenetKarakterTomb);
            Console.WriteLine(nyolcadikUzenetKarakterTomb);
            Console.WriteLine(kilencedikUzenetKarakterTomb);
            Console.WriteLine(tizenegyedikUzenetKarakterTomb);
            Console.WriteLine(tizenegyedikUzenetKarakterTomb);

            string elsoTeljesUzenet = String.Empty;
            string masodikTeljesUzenet = String.Empty;
            string harmadikTeljesUzenet = String.Empty;
            string negyedikTeljesUzenet = String.Empty;
            string otodikTeljesUzenet = String.Empty;
            string hatodikTeljesUzenet = String.Empty;
            string hetedikTeljesUzenet = String.Empty;
            string nyolcadikTeljesUzenet = String.Empty;
            string kilencedikTeljesUzenet = String.Empty;
            string tizedikTeljesUzenet = String.Empty;
            string tizenegyedikTeljesUzenet = String.Empty;

            for (int i = 0; i < 90; i++)
            {
                elsoTeljesUzenet += elsoUzenetKarakterTomb[i];
                masodikTeljesUzenet += masodikUzenetKarakterTomb[i];
                harmadikTeljesUzenet += harmadikUzenetKarakterTomb[i];
                negyedikTeljesUzenet += negyedikUzenetKarakterTomb[i];
                otodikTeljesUzenet += otodikUzenetKarakterTomb[i];
                hatodikTeljesUzenet += hatodikUzenetKarakterTomb[i];
                hetedikTeljesUzenet += hetedikUzenetKarakterTomb[i];
                nyolcadikTeljesUzenet += nyolcadikUzenetKarakterTomb[i];
                kilencedikTeljesUzenet += kilencedikUzenetKarakterTomb[i];
                tizedikTeljesUzenet += tizedikUzenetKarakterTomb[i];
                tizenegyedikTeljesUzenet += tizenegyedikUzenetKarakterTomb[i];
            }

            StreamWriter adas = new StreamWriter("adaas.txt", true, Encoding.UTF8);

            adas.WriteLine($"1. nap: {elsoTeljesUzenet}");
            adas.WriteLine($"2. nap: {masodikTeljesUzenet}");
            adas.WriteLine($"3. nap: {harmadikTeljesUzenet}");
            adas.WriteLine($"4. nap: {negyedikTeljesUzenet}");
            adas.WriteLine($"5. nap: {otodikTeljesUzenet}");
            adas.WriteLine($"6. nap: {hatodikTeljesUzenet}");
            adas.WriteLine($"7. nap: {hetedikTeljesUzenet}");
            adas.WriteLine($"8. nap: {nyolcadikTeljesUzenet}");
            adas.WriteLine($"9. nap: {kilencedikTeljesUzenet}");
            adas.WriteLine($"10. nap: {tizedikTeljesUzenet}");
            adas.WriteLine($"11. nap: {tizenegyedikTeljesUzenet}");
            adas.Flush();
            adas.Close();

            Console.WriteLine("6. feladat:");

            bool szame(string szo)
            {
                bool valasz = true;
                for (int i = 0; i < szo.Length; i++)
                {
                    if (Convert.ToInt32(szo[i]) < 0 || Convert.ToInt32(szo[i]) > 9)
                    {
                        valasz = false;
                    }
                }
                return valasz;
            }

            Console.WriteLine("7. feladat:");

            int napSzama;
            int radiosSzama;

            Console.WriteLine("Kerem adja meg a keresett nap szamat:");

            while (int.TryParse(Console.ReadLine(), out napSzama) == false || (napSzama <= 0 || napSzama > 11))
            {
                Console.WriteLine("Helytelen adatot adott meg! Kerem adjon meg masikat:");
            }

            Console.WriteLine("Kerem adja meg a keresett naphoz tartozo radioamator szamat:");

            while (int.TryParse(Console.ReadLine(), out radiosSzama) == false || (radiosSzama <= 0 || radiosSzama > 20))
            {
                Console.WriteLine("Helytelen adatot adott meg! Kerem adjon meg masikat:");
            }

            for (int i = 0; i < expedicio.Count; i++)
            {
                if (expedicio[i].napSzama == napSzama && expedicio[i].radiosSzama == radiosSzama)
                {
                    for (int k = 0; k < expedicio[i].uzenetSzovege.Length; k++)
                    {
                        if ((Convert.ToInt32(expedicio[i].uzenetSzovege[k]) + Convert.ToInt32(expedicio[i].uzenetSzovege[k + 2])) > 0)
                        {
                            Console.WriteLine(expedicio[i].uzenetSzovege[k]);
                            Console.WriteLine(expedicio[i].uzenetSzovege[k + 2]);
                            Console.WriteLine($"A megfigyelt egyedek szama: {Convert.ToInt32(expedicio[i].uzenetSzovege[k]) + Convert.ToInt32(expedicio[i].uzenetSzovege[k + 2])}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nincs informacio!");
                            break;
                        }
                    }
                }

                if (i == expedicio.Count)
                {
                    Console.WriteLine("Nincs ilyen feljegyzes!!");
                }
            }

            Console.ReadKey();
        }
    }
}
