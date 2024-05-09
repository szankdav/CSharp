using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GombElkapoJatek
{
    public partial class Form1 : Form
    {
        enum Iranyok
        {
            Balfel,
            Bal,
            BalLe,
            Le,
            JobbLe,
            Jobb,
            Jobbfel,
            Fel
        }
        Array iranyok = Enum.GetValues(typeof(Iranyok));
        int kezdoIrany;
        static Random r;
        Stopwatch ora;

        static Form1()
        {
            r = new Random();
        }
        public Form1()
        {
            InitializeComponent();
            ora = new Stopwatch();
            ora.Start();
            kezdoIrany = KezdoIranyKiszamitasa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kezdoIrany == 0)
            {
                button1.Left -= 15;
                button1.Top -= 15;
            }
            else if (kezdoIrany == 1)
            {
                button1.Left -= 15;
            }
            else if (kezdoIrany == 2)
            {
                button1.Left -= 15;
                button1.Top += 15;
            }
            else if (kezdoIrany == 3)
            {
                button1.Top += 15;
            }
            else if (kezdoIrany == 4)
            {
                button1.Left += 15;
                button1.Top += 15;
            }
            else if (kezdoIrany == 5)
            {
                button1.Left += 15;
            }
            else if (kezdoIrany == 6)
            {
                button1.Left += 15;
                button1.Top -= 15;
            }
            else if (kezdoIrany == 7)
            {
                button1.Top -= 15;
            }

            if (button1.Top <= 0)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 0 || kezdoIrany == 7 || kezdoIrany == 1 || kezdoIrany == 5);
            }
            else if (button1.Left <= 0)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 2 || kezdoIrany == 3 || kezdoIrany == 7);
            }
            else if (button1.Bottom >= this.ClientSize.Height)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 2 || kezdoIrany == 3 || kezdoIrany == 4 || kezdoIrany == 1 || kezdoIrany == 5);
            }
            else if (button1.Right >= this.ClientSize.Width)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 4 || kezdoIrany == 5 || kezdoIrany == 6 || kezdoIrany == 3 || kezdoIrany == 7);
            }
            else if (button1.Top <= 0 && button1.Left <= 0)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 0 || kezdoIrany == 1 || kezdoIrany == 2 || kezdoIrany == 6 || kezdoIrany == 7);
            }
            else if (button1.Bottom >= this.ClientSize.Height && button1.Left <= 0)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 0 || kezdoIrany == 1 || kezdoIrany == 2 || kezdoIrany == 3 || kezdoIrany == 4);
            }
            else if (button1.Bottom >= this.ClientSize.Height && button1.Right >= this.ClientSize.Width)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 2 || kezdoIrany == 3 || kezdoIrany == 4 || kezdoIrany == 5 || kezdoIrany == 6);
            }
            else if (button1.Top <= 0 && button1.Right >= this.ClientSize.Width)
            {
                do
                {
                    kezdoIrany = r.Next(iranyok.Length);
                } while (kezdoIrany == 0 || kezdoIrany == 4 || kezdoIrany == 5 || kezdoIrany == 6 || kezdoIrany == 7);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Stop();
            timer1.Stop();
            MessageBox.Show($"Gratulalok, nyertel!\nAz idod: {ora.Elapsed}", "Jatek vege... Nyertel!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)  // 27 = ESC billentyu ASCII kodja
            {
                ora.Stop();
                timer1.Stop();
                e.Handled = true;
                Menu frm = new Menu();
                switch (frm.ShowDialog())
                {
                    //case DialogResult.None:
                    //    break;
                    case DialogResult.OK:
                        ora.Start();
                        timer1.Start();
                        break;
                    case DialogResult.Abort:
                        this.Close();
                        break;
                    case DialogResult.Retry:
                        button1.Height = 20;
                        button1.Width = 20;
                        ora.Restart();
                        timer1.Start();
                        break;
                }
            }
        }

        private int KezdoIranyKiszamitasa()
        {
            return (int)(Iranyok)iranyok.GetValue(r.Next(iranyok.Length));
        }
    }
}
