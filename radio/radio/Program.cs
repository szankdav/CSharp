using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\radio\\radio\\bin\\Debug\\_veetel.txt");
            string fileTartalom = String.Empty;
            while (!file.EndOfStream)
            {
                fileTartalom += file.ReadLine() + "*";
            }
            file.Close();

            string[] sorok = fileTartalom.Split(new string[] { "*" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sorok.Length; i++)
            {
                Console.WriteLine(sorok[i]);
            }

            string[] elsoUzenetNapRogzito = sorok[0].Split(' ');
            string[] utolsoUzenetNapRogzito = sorok[sorok.Length - 2].Split(' ');
            Console.WriteLine("2. feladat:");
            Console.WriteLine($"Az elso uzenet rogzitoje: {elsoUzenetNapRogzito[1]}");
            Console.WriteLine($"Az utolso uzenet rogzitoje: {utolsoUzenetNapRogzito[1]}");

            string[] egyesitettAdatok = new string[sorok.Length / 2];

            int j = 0;
            for (int i = 0; i < egyesitettAdatok.Length; i++)
            {
                egyesitettAdatok[i] = sorok[j] + " " + sorok[j + 1];
                if (j >= sorok.Length - 2)
                {
                    continue;
                }
                else
                {
                    j += 2;
                }
            }

            Console.WriteLine("3. feladat:");

            for (int i = 0; i < egyesitettAdatok.Length; i++)
            {
                string[] tempAdatSor = egyesitettAdatok[i].Split(' ');

                for (int k = 0; k < tempAdatSor.Length; k++)
                {
                    if (tempAdatSor[k].ToLower().StartsWith("farkas"))
                    {
                        Console.WriteLine($"{tempAdatSor[0]}. nap {tempAdatSor[1]}. radioamator");
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

            for (int i = 0; i < egyesitettAdatok.Length; i++)
            {

                string[] tempAdatSor = egyesitettAdatok[i].Split(' ');

                if (tempAdatSor[0] == "1" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    elsoNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "2" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    masodiknapSzamlalo++;
                }
                else if (tempAdatSor[0] == "3" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    harmadikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "4" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    negyedikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "5" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    otodikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "6" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    hatodikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "7" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    hetedikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "8" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    nyolcadikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "9" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    kilencedikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "10" && Convert.ToByte(tempAdatSor[1]) > 0)
                {
                    tizedikNapSzamlalo++;
                }
                else if (tempAdatSor[0] == "11" && Convert.ToByte(tempAdatSor[1]) > 0)
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

            for (int i = 0; i < sorok.Length; i++)
            {
                if (sorok[i].StartsWith("1 "))
                {
                    elsoNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("2 "))
                {
                    masodikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("3 "))
                {
                    harmadikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("4 "))
                {
                    negyedikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("5 "))
                {
                    otodikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("6 "))
                {
                    hatodikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("7 "))
                {
                    hetedikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("8 "))
                {
                    nyolcadikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("9 "))
                {
                    kilencedikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("10 "))
                {
                    tizedikNapUzenetei.Add(sorok[i + 1]);
                }
                else if (sorok[i].StartsWith("11 "))
                {
                    tizenegyedikNapUzenetei.Add(sorok[i + 1]);
                }
            }

            

            StreamWriter adaas = new StreamWriter("adaas.txt", true, Encoding.UTF8);

            Console.ReadKey();
        }
    }
}
