using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace feladatV
{
    internal class Program
    {

        struct Adatok
        {
            public int evszam;
            public int het;
            public string huzasDatum;
            public int otosTalalatDarab;
            public long otosTalalatNyeremeny;
            public int negyesTalalatDarab;
            public int negyesTalalatNyeremeny;
            public int harmasTalalatDarab;
            public int harmasTalalatNyeremeny;
            public int kettesTalalatDarab;
            public int kettesTalalatNyeremeny;
            public byte elsoHuzottSzam;
            public byte masodikHuzottSzam;
            public byte harmadikHuzottSzam;
            public byte negyedikHuzottSzam;
            public byte otodikHuzottSzam;
        }

        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("otos.csv");

            Adatok[] adatok = new Adatok[sorok.Length - 1];

            int j = 0;
            for (int i = 0; i < sorok.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }

                string[] sorokAdatai = sorok[i].Split(';');
                adatok[j].evszam = Convert.ToInt32(sorokAdatai[0]);
                adatok[j].het = Convert.ToInt32(sorokAdatai[1]);
                adatok[j].huzasDatum = sorokAdatai[2];
                adatok[j].otosTalalatDarab = Convert.ToInt32(sorokAdatai[3]);
                adatok[j].otosTalalatNyeremeny = Convert.ToInt64(sorokAdatai[4].Replace(" ", "").Replace("Ft", ""));
                adatok[j].negyesTalalatDarab = Convert.ToInt32(sorokAdatai[5]);
                adatok[j].negyesTalalatNyeremeny = Convert.ToInt32(sorokAdatai[6].Replace(" ", "").Replace("Ft", ""));
                adatok[j].harmasTalalatDarab = Convert.ToInt32(sorokAdatai[7]);
                adatok[j].harmasTalalatNyeremeny = Convert.ToInt32(sorokAdatai[8].Replace(" ", "").Replace("Ft", ""));
                adatok[j].kettesTalalatDarab = Convert.ToInt32(sorokAdatai[9]);
                adatok[j].kettesTalalatNyeremeny = Convert.ToInt32(sorokAdatai[10].Replace(" ", "").Replace("Ft", ""));
                adatok[j].elsoHuzottSzam = Convert.ToByte(sorokAdatai[11]);
                adatok[j].masodikHuzottSzam = Convert.ToByte(sorokAdatai[12]);
                adatok[j].harmadikHuzottSzam = Convert.ToByte(sorokAdatai[13]);
                adatok[j].negyedikHuzottSzam = Convert.ToByte(sorokAdatai[14]);
                adatok[j].otodikHuzottSzam = Convert.ToByte(sorokAdatai[15]);

                j++;
            }

            //StreamReader file = new StreamReader("otos.csv", Encoding.UTF8);
            //string fileTartalom = String.Empty;

            //while (!file.EndOfStream)
            //{
            //    fileTartalom += file.ReadLine() + "#";
            //}
            //file.Close();

            //string[] sorok = fileTartalom.Split(new string[] { "#" }, StringSplitOptions.RemoveEmptyEntries);

            //Adatok[] adatok = new Adatok[sorok.Length];

            //int j = 0;
            //for (int i = 0; i < sorok.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }

            //    string[] sorokAdatai = sorok[i].Split(';');
            //    adatok[j].evszam = Convert.ToInt32(sorokAdatai[0]);
            //    adatok[j].het = Convert.ToInt32(sorokAdatai[1]);
            //    adatok[j].huzasDatum = sorokAdatai[2];
            //    adatok[j].otosTalalatDarab = Convert.ToInt32(sorokAdatai[3]);
            //    adatok[j].otosTalalatNyeremeny = Convert.ToInt64(sorokAdatai[4].Replace(" ", "").Replace("Ft", ""));
            //    adatok[j].negyesTalalatDarab = Convert.ToInt32(sorokAdatai[5]);
            //    adatok[j].negyesTalalatNyeremeny = Convert.ToInt32(sorokAdatai[6].Replace(" ", "").Replace("Ft", ""));
            //    adatok[j].harmasTalalatDarab = Convert.ToInt32(sorokAdatai[7]);
            //    adatok[j].harmasTalalatNyeremeny = Convert.ToInt32(sorokAdatai[8].Replace(" ", "").Replace("Ft", ""));
            //    adatok[j].kettesTalalatDarab = Convert.ToInt32(sorokAdatai[9]);
            //    adatok[j].kettesTalalatNyeremeny = Convert.ToInt32(sorokAdatai[10].Replace(" ", "").Replace("Ft", ""));
            //    adatok[j].elsoHuzottSzam = Convert.ToByte(sorokAdatai[11]);
            //    adatok[j].masodikHuzottSzam = Convert.ToByte(sorokAdatai[12]);
            //    adatok[j].harmadikHuzottSzam = Convert.ToByte(sorokAdatai[13]);
            //    adatok[j].negyedikHuzottSzam = Convert.ToByte(sorokAdatai[14]);
            //    adatok[j].otodikHuzottSzam = Convert.ToByte(sorokAdatai[15]);

            //    j++;
            //}
            //Console.WriteLine(adatok[5].kettesTalalatNyeremeny);
            //Console.WriteLine(adatok[8].elsoHuzottSzam);

            //Maximum index kivalasztas - Hanyadik indexen talalhato a legmagasabb lottonyeremeny

            int maxIndex = 0;
            for (int i = 1; i < adatok.Length; i++)
            {
                if (adatok[i].otosTalalatNyeremeny > adatok[maxIndex].otosTalalatNyeremeny)
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"A legmagasabb otoslottonyeremeny a(z) {maxIndex}. indexen helyezkedik el, osszege: {adatok[maxIndex].otosTalalatNyeremeny} Ft.-");


            //Maximum ertek kivalasztas - Mennyi a legmagasabb 5 talalatos nyeremeny

            long maxNyeremeny = adatok[0].otosTalalatNyeremeny;
            for (int i = 1; i < adatok.Length; i++)
            {
                if (adatok[i].otosTalalatNyeremeny > maxNyeremeny)
                {
                    maxNyeremeny = adatok[i].otosTalalatNyeremeny;
                }
            }

            Console.WriteLine($"A legmagasabb 5 talalatos nyeremeny: {maxNyeremeny} Ft.-");

            //Minimum index kivalasztas - Hanyadik indexen talalhato a legalacsonyabb 2 talalatos nyeremeny

            int minIndex = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[minIndex].kettesTalalatNyeremeny > adatok[i].kettesTalalatNyeremeny)
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"A legalacsonyabb 2 talalatos nyeremeny a(z) {minIndex}. indexen helyezkedik el, osszege: {adatok[minIndex].kettesTalalatNyeremeny} Ft.-");

            //Minimum ertek kivalasztas - Mennyi a legalacsonyabb 2 talalatos nyeremeny

            int minNyeremeny = adatok[0].kettesTalalatNyeremeny;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].kettesTalalatNyeremeny < minNyeremeny)
                {
                    minNyeremeny = adatok[i].kettesTalalatNyeremeny;
                }
            }

            Console.WriteLine($"A legalacsonyabb 2 talalatos nyeremeny: {minNyeremeny} Ft.-");

            // Atlag szamitas - Az osszes talalatFt atlaga

            long otosAtlag = 0;
            long negyesAtlag = 0;
            int harmasAtlag = 0;
            int kettesAtlag = 0;

            for (int i = 0; i < adatok.Length; i++)
            {
                otosAtlag += adatok[i].otosTalalatNyeremeny;
                negyesAtlag += adatok[i].negyesTalalatNyeremeny;
                harmasAtlag += adatok[i].harmasTalalatNyeremeny;
                kettesAtlag += adatok[i].kettesTalalatNyeremeny;
            }

            Console.WriteLine($"Az otos talalatok atlaga: {otosAtlag / adatok.Length}");
            Console.WriteLine($"Az negyes talalatok atlaga: {negyesAtlag / adatok.Length}");
            Console.WriteLine($"Az harmas talalatok atlaga: {harmasAtlag / adatok.Length}");
            Console.WriteLine($"Az kettes talalatok atlaga: {kettesAtlag / adatok.Length}");

            // Kivalasztas - Az elso 30.000 Ft-nal nagyobb osszegu haromtalalatos indexe

            int elsoHarmincezerFelettiHaromTalalatosIndex = 0;
            int k = 0;

            while (k < adatok.Length && !(adatok[k].harmasTalalatNyeremeny >= 30000))
            {
                k++;
            }
            if (k < adatok.Length)
            {
                elsoHarmincezerFelettiHaromTalalatosIndex = k;
            }

            Console.WriteLine($"Az elso 30.000 Ft-nal nagyobb osszegu 3 talalatos nyeremeny indexe: {elsoHarmincezerFelettiHaromTalalatosIndex}");

            // Szetvalogatas - Valogassuk kulon a 2000 elotti, illetve a 2000 es utani sorokat

            Adatok[] kettoezerElottiSorok  = new Adatok[adatok.Length];
            Adatok[] kettoezerEsUtaniSorok = new Adatok[adatok.Length];
            int a = 0;
            int b = 0;

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].evszam < 2000)
                {
                    kettoezerElottiSorok[a] = adatok[i];
                    a++;
                }
                else
                {
                    kettoezerEsUtaniSorok[b] = adatok[i];
                    b++;
                }
            }

            // Kivalogatas - Valogassuk ki azokat a sorokat, ahol egyik kisorsolt szam se nagyobb, mint 50

            Adatok[] kivalogatottTomb = new Adatok[adatok.Length];
            int c = 0;

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].otodikHuzottSzam <= 50 && adatok[i].negyedikHuzottSzam <= 50 && adatok[i].harmadikHuzottSzam <= 50 && adatok[i].masodikHuzottSzam <= 50 && adatok[i].elsoHuzottSzam <= 50)
                {
                    kivalogatottTomb[c] = adatok[i];
                    c++;
                }
            }

            // Linearis kereses - Valasszuk ki az elso olyan sorsolast, ahol a kisorsolt szamok osszege nagyobb, mint 350

            int keresettSorsolasIndexe = 0;
            int l = 0;

            while (l < adatok.Length && !((adatok[l].elsoHuzottSzam + adatok[l].masodikHuzottSzam + adatok[l].harmadikHuzottSzam + adatok[l].negyedikHuzottSzam + adatok[l].otodikHuzottSzam) >= 350))
            {
                l++;
            }
            if (l < adatok.Length)
            {
                keresettSorsolasIndexe = l;
            }

            Console.WriteLine($"Az elso olyan sorsolas, ahol a kisorsolt szamok osszege nagyobb, mint 350: {keresettSorsolasIndexe}");

            // Binaris kereses - Valasszuk ki az elso olyan sorsolast, ahol a kisorsolt szamok osszege nagyobb, mint 350
            //int binarisanKeresettSorsolasIndexe = 0;
            //int elso = 0;
            //int kozepso;
            //int utolso = adatok.Length - 1;
            //int m = 0;

            //do
            //{
            //    m++;
            //    kozepso = (elso + utolso) / 2;
            //    if (adatok[kozepso].elsoHuzottSzam + adatok[kozepso].masodikHuzottSzam + adatok[kozepso].harmadikHuzottSzam + adatok[kozepso].negyedikHuzottSzam + adatok[kozepso].otodikHuzottSzam < 350)
            //    {
            //        elso = kozepso + 1;
            //    }
            //    else
            //    {
            //        utolso = kozepso - 1;
            //    }
            //} while (elso <= utolso && huzottSzamokOsszege[kozepso] != 350);

            //binarisanKeresettSorsolasIndexe = kozepso;

            //Console.WriteLine($"Az elso olyan sorsolas, ahol a kisorsolt szamok osszege nagyobb, mint 350: {binarisanKeresettSorsolasIndexe}");

            // Eldontes - Dontsuk el, hogy van-e olyan sorsolas, ahol a kisorsolt szamok mindegyike paratlan

            int n = 0;
            bool van = false;

            while (n < adatok.Length && !((adatok[n].elsoHuzottSzam % 2 != 0) && (adatok[n].masodikHuzottSzam % 2 != 0) && (adatok[n].harmadikHuzottSzam % 2 != 0) && (adatok[n].negyedikHuzottSzam % 2 != 0) && (adatok[n].otodikHuzottSzam % 2 != 0)))
            {
                n++;
            }
            string eredmeny = n < adatok.Length ? "Van" : "Nincs";
            Console.WriteLine($"Az eredmeny: {eredmeny}, indexe: {n}");

            // Megszamlalas - Szamoljuk meg, hogy hany alkalommal volt negytalalatos nyeremeny

            int negytalalatosNyeremenyDarabSzam = 0;
            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i].negyesTalalatNyeremeny > 0)
                {
                    negytalalatosNyeremenyDarabSzam++;
                }
            }

            Console.WriteLine($"Negytalalatos nyeremenyek darabszama: {negytalalatosNyeremenyDarabSzam}");

            Console.ReadKey();
    }
}
