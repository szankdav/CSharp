using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillenoGombGDIPelda
{
    internal class BillenoGomb : Button
    {
        #region PRIVATE FIELDS
        bool checkState;
        Color ledColor;
        #endregion

        #region PUBLIC PROPERTIES
        public bool CheckState
        {
            get => checkState;
            set
            {
                checkState = value;
                this.Invalidate();
            }
        }
        public Color LedColor
        {
            get => ledColor;
            set
            {
                ledColor = value;
                this.Invalidate();
            }
        }
        #endregion

        #region CONSTRUCTORS
        public BillenoGomb()
        {
            CheckState = false;
            LedColor = Color.Green;
            MinimumSize = new Size(100, 70);
        }

        public BillenoGomb(bool checkState, Color ledColor) : this()
        {
            CheckState = checkState;
            LedColor = ledColor;
        }
        #endregion

        #region METHODS
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            pevent.Graphics.Clear(this.BackColor); // Ostol szarmazo property
            pevent.Graphics.DrawRectangle(new Pen(this.ForeColor, 1), 0, 0, Width - 1, Height - 1); // ????????????
            SizeF szovegMeret = pevent.Graphics.MeasureString(this.Text, this.Font);
            PointF szovegPozicio = new PointF(this.Padding.Left, this.Height / 4);
            if (this.TextAlign == ContentAlignment.TopRight || this.TextAlign == ContentAlignment.MiddleRight || this.TextAlign == ContentAlignment.BottomRight)
            {
                szovegPozicio.X = (float)Math.Ceiling(this.Width - this.Padding.Right - szovegMeret.Width);
            }
            else if (this.TextAlign == ContentAlignment.MiddleCenter || this.TextAlign == ContentAlignment.TopCenter || this.TextAlign == ContentAlignment.BottomCenter)
            {
                szovegPozicio.X = this.Width / 2 - szovegMeret.Width / 2;
            }
            pevent.Graphics.DrawString(this.Text, this.Font, new Pen(this.ForeColor).Brush, szovegPozicio);
            pevent.Graphics.DrawRectangle(new Pen(this.ForeColor, 1), this.Width / 8, (int)(this.Height * 0.66f), (int)(this.Width * 0.75f), (int)(this.Height * 0.1f));
            if (CheckState)
            {
                pevent.Graphics.FillRectangle(new Pen(this.LedColor).Brush, this.Width / 8 + 1, (int)(this.Height * 0.66f + 1), (int)(this.Width * 0.75f - 1), (int)(this.Height * 0.1f - 1));
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            CheckState = !CheckState;
            this.Invalidate();
        }
        #endregion
    }
}
