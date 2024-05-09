using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillenoGombGDIOnalloFeladat
{
    internal class Csuszka
    {
        #region PRIVATE FIELDS
        Size meret;
        Point pozicio;
        #endregion

        #region PUBLIC PROPERTIES
        public Size Meret { get => meret; set => meret = value; }
        public Point Pozicio { get => pozicio; set => pozicio = value; }
        #endregion

        #region CONSTRUCTORS
        public Csuszka()
        {
            
        }
        public Csuszka(Size meret, Point pozicio)
        {
            Meret = meret;
            Pozicio = pozicio;
        }
        #endregion

        #region METHODS
        public void Kirajzolas(int x, int y, int width, int height, PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new Pen(Color.White, 1).Brush, x - (x - 2), y - (y - 2), width / 4, (int)(height * 0.85f));
        }

        public void KirajzolasCsusztatva(int x, int y, int width, int height, PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new Pen(Color.Gray, 1).Brush, (int)(x - width * 0.27f), y - (y - 2), width / 4, (int)(height * 0.85f));
        }

        public void Mozgas()
        {
            Pozicio = new Point(Pozicio.X + 5, Pozicio.Y);
        }
        #endregion

    }
}
