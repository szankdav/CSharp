using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanulokFajlbolOOP
{

    // Készítsünk programot, mely képes fájlból felolvasni tanulók adatait.
    // A tanulókról a fájlban lévő adatok: Név, Átlag, Személyi szám.
    // Oldjuk meg, hogy a program objektumokban tárolja le az egyes tanulókat, majd ezután mondjuk meg a tanulók átlagát.


    internal class Program
    {
        //struct Tanulo
        //{
        //    public string nev;
        //    public double atlag;
        //    public long adoAzonositoJel;
        //}
        static void Main(string[] args)
        {
            // 1. verzió
            // Osztály nélkül
            //if (File.Exists("tanulok.csv"))
            //{
            //    StreamReader reader = new StreamReader("tanulok.csv", Encoding.Default);
            //    while (!reader.EndOfStream)
            //    {
            //        Console.WriteLine(reader.ReadLine());
            //    }
            //    reader.Close();
            //    string[] tanulokTomb = File.ReadAllLines("tanulok.csv", Encoding.Default);
            //    Tanulo[] tanulokStruktrura = new Tanulo[tanulokTomb.Length];
            //    for (int i = 0; i < tanulokTomb.Length; i++)
            //    {
            //        string[] aktualisAdatok = tanulokTomb[i].Split(';');
            //        tanulokStruktrura[i].nev = aktualisAdatok[0].Trim();
            //        tanulokStruktrura[i].atlag = Convert.ToDouble(aktualisAdatok[1].Trim());
            //        tanulokStruktrura[i].adoAzonositoJel = Convert.ToInt64(aktualisAdatok[2].Trim());
            //    }
            //    foreach (Tanulo item in tanulokStruktrura)
            //    {
            //        Console.WriteLine($"Név: {item.nev}, Átlag: {item.atlag}, Személyi szám: {item.adoAzonositoJel}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("A megadott fájl nem található!");
            //}
            // Console.WriteLine(Directory.GetCurrentDirectory());


            // 2. verzió
            // Osztállyal
            if (File.Exists("tanulok.csv"))
            {
                try
                {
                    string[] tanulokTomb = File.ReadAllLines("tanulok.csv", Encoding.Default);
                    TanuloCls[] tanuloClsTomb = new TanuloCls[tanulokTomb.Length];
                    double atlag = 0;
                    for (int i = 0; i < tanulokTomb.Length; i++)
                    {
                        //TanuloCls temp = new TanuloCls(tanulokTomb[i]);
                        //tanuloClsTomb[i] = temp;
                        try
                        {
                            tanuloClsTomb[i] = new TanuloCls(tanulokTomb[i]);
                            atlag += tanuloClsTomb[i].AtlagProperty;
                            Console.WriteLine($"SIKER - a(z) {i + 1}. sor feldolgozva: Nev: {tanuloClsTomb[i].NevProperty} - Atlag: {tanuloClsTomb[i].AtlagProperty} - Adoazonositojel: {tanuloClsTomb[i].AdoAzonositoJelProperty}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    atlag = atlag / tanuloClsTomb.Length;
                    Console.WriteLine($"A tanulok atlaga alprogram nelkul: {atlag}");
                    Console.WriteLine($"A tanulok atlaga alprogrammal: {TanuloCls.Atlagszamitas(tanuloClsTomb)}");
                    //foreach(TanuloCls item in tanuloClsTomb)
                    //{
                    //    Console.WriteLine($"Nev: {item.NevProperty} - Atlag: {item.AtlagProperty} - Adoazonositojel: {item.AdoAzonositoJelProperty}");
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                Console.WriteLine("A megadott fájl nem található!");
            }
            Console.ReadKey();
        }
    }
}
