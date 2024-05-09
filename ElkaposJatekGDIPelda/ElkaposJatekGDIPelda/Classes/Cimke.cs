using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkaposJatekGDIPelda
{
    internal class Cimke : GrafikusObjektum
    { 
        #region PRIVATE FIELDS
        string szoveg;
        Color szin;
        #endregion

        #region PUBLIC PROPERTIES
        public string Szoveg { get => szoveg; set => szoveg = value; }
        public Color Szin { get => szin; set => szin = value; }
        #endregion

        #region CONSTRUCTORS
        public Cimke()
        {
            szin = Color.Black;
        }
        #endregion

        #region METHODS
        public override void Paint(Graphics g)
        {
            Font f = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
            g.DrawString(Szoveg, f, new Pen(Szin).Brush, Pozicio.X, Pozicio.Y);
        }
        #endregion
    }
}
