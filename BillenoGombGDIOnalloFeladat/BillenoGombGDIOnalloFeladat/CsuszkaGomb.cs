using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillenoGombGDIOnalloFeladat
{
    internal class CsuszkaGomb : Button
    {
        #region PRIVATE FIELDS
        bool checkstate;
        Color backgroundColor;
        Color foregroundColor;
        #endregion

        #region PUBLIC PROPERTIES
        public bool Checkstate
        {
            get => checkstate;
            set
            {
                checkstate = value;
                this.Invalidate();
            }
        }
        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                this.Invalidate();
            }
        }
        public Color ForegroundColor
        {
            get => foregroundColor;
            set
            {
                foregroundColor = value;
                this.Invalidate();
            }
        }
        #endregion

        #region CONSTRUCTORS
        public CsuszkaGomb()
        {
            Checkstate = false;
            BackgroundColor = Color.Blue;
            ForegroundColor = Color.White;
            MinimumSize = new Size(100, 30);
        }
        #endregion

        #region METHODS
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            Csuszka csuszka = new Csuszka();
            pevent.Graphics.Clear(Color.Gray); // Ostol szarmazo property
            pevent.Graphics.DrawRectangle(new Pen(this.ForeColor, 1), 0, 0, Width - 1, Height - 1); // ????????????
            csuszka.Kirajzolas(this.Width, this.Height, this.Width, this.Height, pevent);
            if (Checkstate)
            { 
                pevent.Graphics.FillRectangle(new Pen(this.BackgroundColor, 1).Brush, 0, 0, Width - 1, Height - 1);
                csuszka.KirajzolasCsusztatva(this.Width, this.Height, this.Width, this.Height, pevent);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Checkstate = !Checkstate;
            this.Invalidate();
        }
        #endregion
    }
}
