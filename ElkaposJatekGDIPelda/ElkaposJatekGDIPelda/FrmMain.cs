using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElkaposJatekGDIPelda
{
    public partial class FrmMain : Form
    {
        Elkapo elkapo;
        List<Macska> macskakLista;
        int elkapva, leesett;
        Cimke elkapvaC, leesettC;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UjJatek();
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (Macska item in macskakLista)
            {
                item.Paint(e.Graphics);
            }
            elkapo.Paint(e.Graphics);
            elkapvaC.Szoveg = $"{elkapva} db macskat kaptunk el";
            leesettC.Szoveg = $"{leesett} db macskat ejtettunk le";
            elkapvaC.Paint(e.Graphics);
            leesettC.Paint(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point egerPozicio = MousePosition;
            if (egerPozicio.X < 0)
            {
                egerPozicio.X += Screen.GetBounds(MousePosition).Width;
            }
            elkapo.Mozgas(egerPozicio.X);
            foreach (Macska item in macskakLista)
            {
                item.Mozgas();
                if (elkapo.HitTest(item)) // ??????????
                {
                    elkapva++;
                    item.Generalas(ClientSize.Width);
                }
                else if (item.Pozicio.Y > ClientSize.Height)
                {
                    leesett++;
                    item.Generalas(ClientSize.Width);
                }
            }
            this.Invalidate();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            // N, mint uj jatek
            if (e.KeyCode == Keys.N)
            {
                timer1.Enabled = !timer1.Enabled;
                Cursor.Show();
                if (MessageBox.Show("Szeretne uj jatekot inditani?", "Uj jatek...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    UjJatek();
                }
                else
                {
                    timer1.Enabled = !timer1.Enabled;
                    Cursor.Hide();
                }
            }
            // P, mint szunet
            else if (e.KeyCode == Keys.P)
            {
                timer1.Enabled = !timer1.Enabled;
                if (timer1.Enabled)
                {
                    Cursor.Hide();
                }
                else
                {
                    Cursor.Show();
                }
            }
            // E, mint kilepes
            else if (e.KeyCode == Keys.E)
            {
                timer1.Enabled = !timer1.Enabled;
                Cursor.Show();
                if (MessageBox.Show("Szeretne kilepni a jatekbol?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    timer1.Enabled = !timer1.Enabled;
                    Cursor.Hide();
                }
            }
        }

        private void UjJatek()
        {
            elkapva = leesett = 0;
            elkapvaC = new Cimke();
            leesettC = new Cimke();
            elkapvaC.Szin = Color.Green;
            leesettC.Szin = Color.Red;
            elkapvaC.Pozicio = new Point(ClientSize.Width - 250, 20);
            leesettC.Pozicio = new Point(ClientSize.Width - 250, 40);
            elkapo = new Elkapo(new Size(150, 20), new Point(0, ClientSize.Height - 100));
            macskakLista = new List<Macska>();
            for (int i = 0; i < 20; i++)
            {
                macskakLista.Add(new Macska(ClientSize.Width));
            }
            timer1.Enabled = true;
            Cursor.Hide();
        }
    }
}
