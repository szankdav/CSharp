using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat1
{
    internal class Program
    {
        struct Tanulo //struct - általunk defíniált adatszerkezet
        {
            public string nev;
            public double atlag;
        }
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\Fajfeldolgozas\\FeladatIII\\bin\\Debug\\atlagok.txt", Encoding.UTF8);
            string fajlTartalom = String.Empty;

            while (!file.EndOfStream)
            {
                fajlTartalom += file.ReadLine() + "#";
            }
            // MUCH IMPORTANTO!
            file.Close();
            string[] sorok = fajlTartalom.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sorok.Length; i++)
            {
                Console.WriteLine(sorok[i]);
            }


            Tanulo[] diakok = new Tanulo[sorok.Length / 2];

            int j = 0;
            double osztalyAtlag = 0;
            Tanulo min, max;
            min.atlag = 6;
            max.atlag = 0;
            min.nev = String.Empty;
            max.nev = String.Empty;

            for (int i = 0; i < diakok.Length; i++)
            {
                diakok[i].nev = sorok[j];
                diakok[i].atlag = Convert.ToDouble(sorok[j + 1]);
                osztalyAtlag += diakok[i].atlag;

                if (diakok[i].atlag < min.atlag)
                {
                    min = diakok[i];
                }
                if (diakok[i].atlag > max.atlag)
                {
                    max = diakok[i];
                }
                j += 2;
                Console.WriteLine($"tanuló neve: {diakok[i].nev}, a tanuló átlaga: {diakok[i].atlag}, év végi jegye: {Math.Round(diakok[i].atlag)}");
            }
                osztalyAtlag /= diakok.Length;

            Console.WriteLine($"Az osztály év végi átlaga: {osztalyAtlag}");
            Console.WriteLine($"A legrosszabb tanuló neve: {min.nev} és átlaga: {min.atlag}");
            Console.WriteLine($"A legjobb tanuló neve: {max.nev} és átlaga: {max.atlag}");

            //Console.WriteLine(fajlTartaloms);

            //StreamReader file2 = new StreamReader("E:\\JuniorVisualC#2023_Béres_Gábor_2023.05.24-től\\Feladatok\\fajlkezeles\\adaas.txt", Encoding.UTF8);

            //while (!file2.EndOfStream)
            //{
            //    Console.WriteLine(file2.ReadLine());
            //}
            //file.Close();



            Console.ReadKey();
        }
    }
}
