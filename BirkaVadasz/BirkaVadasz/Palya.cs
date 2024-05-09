using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace BirkaVadasz
{
    enum JatekAllapot
    {
        Játékban,
        Vesztett,
        Nyert
    }

    static class Palya
    {
        #region PRIVATE FIELDS
        static Birka[] birkak;
        static Size meret;
        static Point utolsoLovesHelye;
        static JatekAllapot allapot;
        static SoundPlayer player;
        #endregion

        #region PUBLIC PROPERTIES
        internal static Birka[] Birkak
        {
            get
            {
                Birka[] birkakMasolat = new Birka[birkak.Length];
                for (int i = 0; i < birkak.Length; i++)
                {
                    birkakMasolat[i] = birkak[i];
                }
                return birkakMasolat;
            }
            //set => birkak = value;
        }

        public static Size Meret
        {
            get => meret;
            set
            {
                if (value.Width >= 5 && value.Height >= 5)
                {
                    meret = value;
                }
                else
                {
                    // Hiba dobas...
                    meret = new Size(5, 5);
                }
                meret = value;
            }
        }

        public static Point UtolsoLovesHelye { get => utolsoLovesHelye; /*set => utolsoLovesHelye = value;*/ }
        internal static JatekAllapot Allapot { get => allapot; /*set => allapot = value;*/ }
        #endregion

        #region CONSTRUCTORS
        static Palya()
        {
            player = new SoundPlayer(Properties.Resources.shotgun);
        }
        #endregion

        #region METHODS
        public static void JatekInditas(Size palyaMerete, byte birkakSzama)
        {
            Meret = palyaMerete;
            birkak = new Birka[birkakSzama];
            allapot = JatekAllapot.Játékban;
            for (int i = 0; i < birkakSzama; i++)
            {
                birkak[i] = new Birka(Meret);
            }
        }

        static void BirkakMozgatasa()
        {
            foreach (Birka item in birkak)
            {
                if (item.Elet > BirkaElet.Halott)
                {
                    item.Mozog();
                    if (item.Pozicio.X < 1 || item.Pozicio.Y < 1 || item.Pozicio.X > meret.Width || item.Pozicio.Y > meret.Height)
                    {
                        allapot = JatekAllapot.Vesztett;
                        return;
                    }
                }
            }
        }

        static void LovesHangLejatszas()
        {
            player.Play();
        }

        public static void Loves(Point pozicio)
        {
            BirkakMozgatasa();
            if (Allapot == JatekAllapot.Vesztett)
            {
                return;
            }
            LovesHangLejatszas();
            utolsoLovesHelye = pozicio;
            int i = 0;
            while (i < birkak.Length && (birkak[i].Pozicio != pozicio || birkak[i].Elet == BirkaElet.Halott))
            {
                i++;
            }
            if (i < birkak.Length)
            {
                birkak[i].Elet--; //Habar az enum az elet, a mogottes tipus az int, igy az alapveto matematikai muveletek alkalmazhatoak
            }
            int eloBirkak = 0;
            foreach (Birka item in birkak) 
            {
                if (item.Elet > BirkaElet.Halott)
                {
                    eloBirkak++;
                }
            }
            if (eloBirkak == 0)
            {
                allapot = JatekAllapot.Nyert;
            }
        }
        #endregion
    }
}
