using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsuszkaGomb
{
    public class Csuszka
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
            pevent.Graphics.FillRectangle(new Pen(Color.DimGray, 1).Brush, x - (x - 2), y - (y - 2), width / 4, (int)(height * 0.9f));
            Pozicio = new Point(x - (x - 2), y - (y - 2));
            Meret = new Size(width / 4, (int)(height * 0.9f));
        }

        public void KirajzolasCsusztatva(int x, int y, int width, int height, PaintEventArgs pevent)
        {
            pevent.Graphics.FillRectangle(new Pen(Color.Red, 1).Brush, (int)(x - width * 0.27f), y - (y - 2), width / 4, (int)(height * 0.85f));
            Pozicio = new Point(x - (x - 2), y - (y - 2));
        }

        public void Mozgas(int egerXpozicio)
        {
            Pozicio = new Point(egerXpozicio, Pozicio.Y);
        }
        #endregion
    }
}
