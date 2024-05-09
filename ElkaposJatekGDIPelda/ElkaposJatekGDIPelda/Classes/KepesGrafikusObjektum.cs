using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkaposJatekGDIPelda
{
    abstract class KepesGrafikusObjektum : GrafikusObjektum
    {
        #region PRIVATE FIELDS
        Image kep;
        #endregion

        #region PUBLIC PROPERTIES
        public Image Kep { get => kep; protected set => kep = value; }
        #endregion

        #region CONSTRUCTORS
        protected KepesGrafikusObjektum(Image kep)
        {
            Kep = kep;
        }

        protected KepesGrafikusObjektum(Size meret, Point pozicio, Image kep) : base(meret, pozicio)
        {
            Kep = kep;
        }
        #endregion

        #region METHODS
        #endregion

    }
}
