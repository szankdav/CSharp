using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkaposJatekGDIPelda
{
    abstract class GrafikusObjektum
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
        protected GrafikusObjektum()
        {
            // Nem csinalok semmit.
        }

        protected GrafikusObjektum(Size meret, Point pozicio)
        {
            Meret = meret;
            Pozicio = pozicio;
        }
        #endregion

        #region METHODS
        public abstract void Paint(Graphics g);

        public virtual bool HitTest(GrafikusObjektum masik)
        {
            Rectangle ezMintTeglalap = new Rectangle(Pozicio, Meret);
            Rectangle masikMintTeglalap = new Rectangle(masik.Pozicio, masik.Meret);
            return ezMintTeglalap.IntersectsWith(masikMintTeglalap);
        }
        #endregion
    }
}
