using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkaposJatekGDIPelda
{
    internal class Macska : KepesGrafikusObjektum
    {
        #region PRIVATE FIELDS
        Byte sebesseg;
        static Random r;
        #endregion

        #region PUBLIC PROPERTIES
        #endregion

        #region CONSTRUCTORS
        static Macska()
        {
            r = new Random(); // Random-ot peldanyositjuk
        }
        public Macska(int teruletSzelesseg) : base(Properties.Resources.macska1)
        {
            Generalas(teruletSzelesseg);
        }
        #endregion

        #region METHODS
        public void Generalas(int teruletSzelesseg)
        {
            int meret = r.Next(40, teruletSzelesseg / 5);
            Meret = new Size(meret, meret);
            Pozicio = new Point(r.Next(0, teruletSzelesseg - Meret.Width), r.Next(-teruletSzelesseg, -Meret.Height));
            Kep.Dispose();
            GC.Collect();
            switch (r.Next(1, 6))
            {
                case 1:
                    Kep = Properties.Resources.macska1;
                    break;
                case 2:
                    Kep = Properties.Resources.macska2;
                    break;
                case 3:
                    Kep = Properties.Resources.macska3;
                    break;
                case 4:
                    Kep = Properties.Resources.macska4;
                    break;
                case 5:
                    Kep = Properties.Resources.macska5;
                    break;
            }
            sebesseg = (byte)r.Next(1, 5);
        }

        public void Mozgas()
        {
            Pozicio = new Point(Pozicio.X, Pozicio.Y + sebesseg);
        }

        public override void Paint(Graphics g)
        {
            g.DrawImage(Kep, Pozicio.X, Pozicio.Y, Meret.Width, Meret.Height);
        }
        #endregion
    }
}
