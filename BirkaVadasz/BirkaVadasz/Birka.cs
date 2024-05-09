using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirkaVadasz
{
    enum BirkaElet
    {
        Sértetlen = 2,
        Sérült = 1,
        Halott = 0
    }

    internal class Birka
    {
        static Random r/* = new Random()*/;
        Point pozicio;
        BirkaElet elet;

        public Point Pozicio { get => pozicio; /*set => pozicio = value;*/ }
        internal BirkaElet Elet
        {
            get => elet;
            set
            {
                if (value <= elet) { elet = value; }
                else { /* Hiba dobás...*/ }
            }
        }

        static Birka()
        {
            r = new Random(); // Mivel az r egy osztály (statikus) szintű változó, ezért az osztály szintű konstruktor (statikus) kell, hogy létrehozza!
        }

        public Birka(Size palyaMerete)
        {
            //r = new Random();
            pozicio.X = r.Next(2, palyaMerete.Width - 1);
            pozicio.Y = r.Next(2, palyaMerete.Height - 1);
            elet = BirkaElet.Sértetlen;
        }

        public void Mozog()
        {
            if (elet > BirkaElet.Halott)
            {
                if (elet == BirkaElet.Sértetlen && r.Next(1, 101) <= 70 || elet == BirkaElet.Sérült && r.Next(1, 101) <= 35)
                {
                    switch (r.Next(1, 9))
                    {
                        case 1: // Fel
                            pozicio.Y--;
                            break;
                        case 2: // Jobbra fel
                            pozicio.X++;
                            pozicio.Y--;
                            break;
                        case 3: // Jobbra
                            pozicio.X++;
                            break;
                        case 4: // Jobbra le
                            pozicio.X++;
                            pozicio.Y++;
                            break;
                        case 5: // Le
                            pozicio.Y++;
                            break;
                        case 6: // Balra le
                            pozicio.X--;
                            pozicio.Y++;
                            break;
                        case 7: // Balra
                            pozicio.X--;
                            break;
                        case 8: // Balra fel
                            pozicio.X--;
                            pozicio.Y--;
                            break;
                    }
                }
            }
        }
    }
}
