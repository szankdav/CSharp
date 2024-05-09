using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefPelda
{
    // ***** PROGRAM OSZTALY
    internal class Program
    {
        static Random r;
        static void Main(string[] args)
        {
            r = new Random();
            int a = 5;
            int b = a;
            Console.WriteLine($"Az a valtozo erteke: {a}");
            Console.WriteLine($"A b valtozo erteke: {b}");
            Szorzas(a);
            Console.WriteLine($"Az a valtozo erteke novelessel: {a}");
            Console.WriteLine($"A b valtozo erteke az a novelse utan: {b}");

            // 1. pelda
            RandomNoveles(ref a);
            Console.WriteLine($"Az a valtozo erteke a noveles utan: {a}");

            // 2. pelda
            Pelda p = new Pelda(4, 20);
            Console.WriteLine($"A p osztalypeldany A tagjanak erteke a noveles elott: {p.A}, a p osztalypeldany B tagjanak erteke a noveles elott: {p.B}");
            RandomNovelesPelda(p);
            Console.WriteLine($"A p osztalypeldany A tagjanak erteke a noveles utan: {p.A}, a p osztalypeldany B tagjanak erteke a noveles utan: {p.B}");

            // 3. pelda
            Console.WriteLine($"Az eredeti p osztaly referencia szintu A tagjanak erteke a feluliras elott: {p.A}, az eredeti p osztaly referencia szintu B tagjanak erteke a feluliras elott: {p.B}");
            LegyenPeldaMas(ref p);
            Console.WriteLine($"Az eredeti p osztaly referencia szintu A tagjanak erteke a feluliras utan: {p.A}, az eredeti p osztaly referencia szintu B tagjanak erteke a feluliras utan: {p.B}");
            Console.ReadKey();
        }

        static void Szorzas(int a)
        {
            a *= 20;
        }

        static void RandomNoveles(ref int a)
        {
            a += r.Next(1, 1000);
        }

        static void RandomNovelesPelda(Pelda p) //Osztaly letrehozasa mindig referencia atadas! Ilyenkor az osztalpeldany valtozo ertekei kerulnek atadasra!
        {
            p.A += r.Next(1, 1000);
        }

        static void LegyenPeldaMas(ref Pelda p) //Osztalypeldany atadasa referencia szerint, ebben az esetben maga a peldany kerul atadasra, nem csak az osztaly valtozoi.
        {
            p = new Pelda(10, 200);
        }
    }
    // ***** PROGRAM OSZTALY VEGE

    // ***** PELDA OSZTALY
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
    // ***** PELDA OSZTALY VEGE
}