namespace scoobydoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat:");
            string[] nyomozasok = TombbeOlvasas("nyomozas.txt");
            Console.WriteLine("Sikeres beolvasás!");

            Console.WriteLine("2. feladat:");
            KepernyoreIras(nyomozasok);

            Console.WriteLine("3. feladat:");
            Console.WriteLine($"{NyomozasokSzama(nyomozasok)} nyomozáson vettek részt összesen.");

            Console.WriteLine("4. feladat:");
            Console.WriteLine($"Átlagosan {AtlagosSnackSzam(nyomozasok).ToString("0.0")} snacket gyűjtött össze Scobby-Doo egy nyomozás során!");

            Console.WriteLine("5. feladat:");
            Console.WriteLine($"Összesen {NyomozasiHelyszinSzamlalo(nyomozasok, "Hévízi-tó")} alkalommal nyomoztak a Hévízi-tónál!");

            Console.WriteLine("6. feladat:");
            Console.WriteLine($"{LegtobbNyomHelyszine(nyomozasok)} helyszínen találta a legtöbb nyomot a csapat!");

            Console.WriteLine("7. feladat:");
            Console.Write("Kérem írja be a keresett nyom számot: ");
            Console.WriteLine($"{(BekertNyomSzamKereses(nyomozasok, int.Parse(Console.ReadLine())) ? "Volt ilyen nyom számmal helyszín!" : "Nem volt ilyen nyom számmal helyszín!")}");

            Console.WriteLine("8. feladat:");
            Console.Write("Kérem írja be a keresett helyszínt: ");
            string keresettHelyszin = Console.ReadLine();
            Console.WriteLine($"{(SnackSzamKeresoHelyszinAlapjan(nyomozasok, keresettHelyszin) > 0 ? $"Volt ilyen nyomozási helyszín, ahol összesen {SnackSzamKeresoHelyszinAlapjan(nyomozasok, keresettHelyszin)} darab snacket gyűjtöttek!" : "Nem volt ilyen helyszín!")}");

            Console.WriteLine("9. feladat:");
            int[] parosok = parosSzamValogato(nyomozasok);
            foreach (int szam in parosok)
            {
                if (szam > 0)
                {
                    Console.WriteLine(szam);
                }
            }

            Console.WriteLine("10. feladat:");
            FajlKiiras(nyomozasok);
            Console.WriteLine("A file kiírása megtörtént!");

            Console.WriteLine("11. feladat");
            int[] harommalOszthato = snackOszthatoHarommal(nyomozasok);
            int[] harommalNemOszthato = snackNemOszthatoHarommal(nyomozasok);

            foreach (int szam in harommalOszthato)
            {
                if (szam > 0)
                {
                    Console.Write($"{szam}; ");
                }
            }

            Console.WriteLine();

            foreach (int szam in harommalNemOszthato)
            {
                if (szam > 0)
                {
                    Console.Write($"{szam}; ");
                }
            }



            string[] TombbeOlvasas(string utvonal)
            {
                string[] beolvasottAdatok = new string[500];
                StreamReader scoobyReader = new StreamReader(utvonal);
                int index = 0;
                while (!scoobyReader.EndOfStream)
                {
                    string[] adatok = scoobyReader.ReadLine().Split(' ');
                    if (adatok.Length == 3)
                    {
                        beolvasottAdatok[index++] = $"{adatok[0]} {adatok[1]}";
                        beolvasottAdatok[index++] = adatok[2];
                    }
                    else if (adatok.Length == 4)
                    {
                        beolvasottAdatok[index++] = $"{adatok[0]} {adatok[1]} {adatok[2]}";
                        beolvasottAdatok[index++] = adatok[3];
                    }
                    else
                    {
                        beolvasottAdatok[index++] = adatok[0];
                        beolvasottAdatok[index++] = adatok[1];
                    }
                }
                scoobyReader.Close();

                return beolvasottAdatok;
            }

            void KepernyoreIras(string[] tomb)
            {
                for (int i = 0; i < tomb.Length; i += 2)
                {
                    if (tomb[i] != null)
                    {
                        Console.WriteLine($"{tomb[i]} - {tomb[i + 1]}");
                    }
                }
            }

            int NyomozasokSzama(string[] tomb)
            {
                int nyomozasokSzama = 0;
                foreach (string nyomozas in tomb) 
                {
                    if (nyomozas != null && int.TryParse(nyomozas, out _) == false)
                    {
                        nyomozasokSzama++;
                    }
                }
                return nyomozasokSzama;
            }

            double AtlagosSnackSzam(string[] tomb)
            {
                int osszesSnack = 0;
                int snackSzamlalo = 0;
                double atlagSnack = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int snack) == true)
                    {
                        osszesSnack += snack;
                        snackSzamlalo++;
                    }
                }
                return atlagSnack = osszesSnack / snackSzamlalo;
            }

            int NyomozasiHelyszinSzamlalo(string[] tomb, string helyszin)
            {
                int szamalo = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] == helyszin)
                    {
                        szamalo++;
                    }
                }
                return szamalo;
            }

            string LegtobbNyomHelyszine(string[] tomb)
            {
                string helyszin = string.Empty;
                int legtobbNyomIndexe = 1;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[legtobbNyomIndexe], out int a) == true && int.TryParse(tomb[i], out int b) == true)
                    {
                        if (a < b)
                        {
                            legtobbNyomIndexe = i;
                        }
                    }
                }
                helyszin = $"{tomb[legtobbNyomIndexe - 1]}";
                return helyszin;
            }

            bool BekertNyomSzamKereses(string[] tomb, int szam)
            {
                bool voltIlyenSzamuNyomozas = false;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int a) == true)
                    {
                        if(a == szam)
                        {
                            voltIlyenSzamuNyomozas = true;
                            break;
                        }
                    }
                }
                if (voltIlyenSzamuNyomozas)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int SnackSzamKeresoHelyszinAlapjan(string[] tomb, string helyszin)
            {
                bool voltIlyenHelyszin = false;
                int keresettHelyszinIndex = 0;
                int snackekSzama = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] == helyszin)
                    {
                        voltIlyenHelyszin = true;
                        snackekSzama += int.Parse(tomb[i + 1]);
                    }
                }
                if (voltIlyenHelyszin)
                {
                    return snackekSzama;
                }
                else
                {
                    return 0;
                }
            }

            int[] parosSzamValogato(string[] tomb)
            {
                int[] parosSzamok = new int[tomb.Length];
                int index = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int a) == true && a % 2 == 0)
                    {
                        parosSzamok[index] = a;
                        index++;
                    }
                }
                return parosSzamok;
            }

            void FajlKiiras(string[] tomb)
            {
                StreamWriter scoobyWriter = new StreamWriter("helyszinek.txt");
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int a) == true && a >= 50)
                    {
                        scoobyWriter.WriteLine($"{tomb[i - 1]}");
                    }
                }
                scoobyWriter.Close();
            }

            int[] snackOszthatoHarommal(string[] tomb)
            {
                int[] harommalOszthato = new int[tomb.Length];
                int index = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int a) == true && a % 3 == 0)
                    {
                        harommalOszthato[index] = a;
                        index++;
                    }
                }
                return harommalOszthato;
            }

            int[] snackNemOszthatoHarommal(string[] tomb)
            {
                int[] harommalNemOszthato = new int[tomb.Length];
                int index = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (int.TryParse(tomb[i], out int a) == true && a % 3 != 0)
                    {
                        harommalNemOszthato[index] = a;
                        index++;
                    }
                }
                return harommalNemOszthato;
            }

            Console.ReadLine();
        }
    }
}
