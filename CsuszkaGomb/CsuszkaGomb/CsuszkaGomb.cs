using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CsuszkaGomb
{
    public class CsuszkaGomb : Button
    {
        #region PRIVATE FIELDS
        bool checkstate;
        bool clickState;
        Color backgroundColor;
        Color foregroundColor;
        Csuszka csuszka;
        Point egerPozicio;
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

        public bool ClickState
        {
            get => clickState; 
            set
            {
                clickState = value;
                this.Invalidate();
            }
        }
        public Csuszka Csuszka { get => csuszka; set => csuszka = value; }
        public Point EgerPozicio
        {
            get => egerPozicio; 
            set
            {
                egerPozicio = value;
                this.Invalidate();
            }
        }
        #endregion

        #region CONSTRUCTORS
        public CsuszkaGomb()
        {
            Checkstate = false;
            ClickState = false;
            BackgroundColor = Color.Green;
            ForegroundColor = Color.White;
            MinimumSize = new Size(100, 30);
            Csuszka = new Csuszka();
            EgerPozicio = MousePosition;
        }
        #endregion

        #region METHODS
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            pevent.Graphics.Clear(Color.LightGray); // Ostol szarmazo property
            pevent.Graphics.FillRectangle(new Pen(Color.Red, 1).Brush, 0, 0, Width, Height); // ????????????
            Csuszka.Kirajzolas(this.Width, this.Height, this.Width, this.Height, pevent);
            if (ClickState)
            {
                Csuszka.Kirajzolas(EgerPozicio.X, this.Height, this.Width, this.Height, pevent);
            }
            else if (Checkstate)
            {
                pevent.Graphics.FillRectangle(new Pen(this.BackgroundColor, 1).Brush, 0, 0, Width, Height);
                Csuszka.KirajzolasCsusztatva(EgerPozicio.X, this.Height, this.Width, this.Height, pevent);
            }
        }

        //protected override void OnClick(EventArgs e)
        //{
        //    base.OnClick(e);
        //    Checkstate = !Checkstate;
        //    this.Invalidate();
        //}

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            Checkstate = !Checkstate;
            this.Invalidate();
        }

        //protected override void OnMouseUp(MouseEventArgs mevent)
        //{
        //    base.OnMouseUp(mevent);
        //    ClickState = !ClickState;
        //    this.Invalidate();
        //}

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            EgerPozicio = MousePosition;
            this.Invalidate();
        }
        #endregion
    }
}
