using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatI
{
    internal class Program
    {
        //struct Tanulo
        //{
        //    public string nev;
        //    public double atlag;
        //    public long szemelyiSzam;

        //}
        static void Main(string[] args)
        {
            // Hibakezeles
            //try
            //{
            //    StreamReader file = new StreamReader("valami.txt", Encoding.UTF8);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Osztaly nelkuli letrehozas
            //if (File.Exists("tanulok.csv"))
            //{
            //    StreamReader file = new StreamReader("tanulok.csv", Encoding.UTF8);
            //    while (!file.EndOfStream)
            //    {
            //        Console.WriteLine(file.ReadLine());
            //    }
            //    file.Close();

            //    string[] tanulok = File.ReadAllLines("tanulok.csv", Encoding.Default);
            //    Tanulo[] tanulokStruktura = new Tanulo[tanulok.Length];

            //    for (int i = 0; i < tanulokStruktura.Length; i++)
            //    {
            //        string[] aktualisAdatok = tanulok[i].Split(';');
            //        tanulokStruktura[i].nev = aktualisAdatok[0].Trim();
            //        tanulokStruktura[i].atlag = Convert.ToDouble(aktualisAdatok[1].Trim());
            //        tanulokStruktura[i].szemelyiSzam = Convert.ToInt64(aktualisAdatok[2].Trim());
            //    }
            //    foreach (Tanulo item in tanulokStruktura)
            //    {
            //        Console.WriteLine($"Nev: {item.nev}, Atlag: {item.atlag}, Szemelyi szam: {item.szemelyiSzam}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Hiba! A file nem talalhato!");
            //}

            //try
            //{
            //    Tanulo x = new Tanulo("Orso", 2.4, 8383274114);
            //    Console.WriteLine($"{x.NevProperty} - {x.AtlagProperty} - {x.SzemelyiSzamProperty}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            Console.ReadKey();
        }
    }
}
