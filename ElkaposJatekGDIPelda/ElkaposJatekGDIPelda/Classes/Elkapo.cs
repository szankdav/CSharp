using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkaposJatekGDIPelda
{
    internal class Elkapo : KepesGrafikusObjektum
    {
        #region PRIVATE FIELDS
        #endregion

        #region PUBLIC PROPERTIES
        #endregion

        #region CONSTRUCTORS
        public Elkapo(Size meret, Point pozicio) : base(meret, pozicio, Properties.Resources.elkapo)
        {
            // Nem kell csinalni semmit, mert peldanyosodaskor tovabbadodnak az osoknek az ososztalyokon keresztul a bejovo parameterek
        }
        #endregion

        #region METHODS
        public void Mozgas(int egerX)
        {
            Pozicio = new Point(egerX - Meret.Width / 2, Pozicio.Y); // Ezzel az egerhez viszonyitom az elkapo poziciojat. A settert hasznaltuk
        }

        public override void Paint(Graphics g)
        {
            g.DrawImage(Kep, Pozicio.X, Pozicio.Y, Meret.Width, Meret.Height);
        }
        #endregion
    }
}
