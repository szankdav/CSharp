using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoSorsolas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            int top = BtnSorsolas.Bottom + 20, left = BtnSorsolas.Left;
            for (int i = 1; i <= 90; i++)
            {
                Button btn = new Button()
                {
                    Top = top,
                    Left = left,
                    Width = 70,
                    Height = 50,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Name = "BtnSzamok",
                    Text = i.ToString()
                };
                this.Controls.Add(btn);
                btn.Click += Szamok_Click;
                if (i % 10 == 0)
                {
                    top += 55;
                    left = BtnSorsolas.Left;
                }
                else
                {
                    left += 75;
                }
            }
        }

        private void BtnSorsolas_Click(object sender, EventArgs e)
        {
            if (JeloltGombokSzama() == 5)
            {
                int[] huzottak = OtHuzottSzam();
                foreach (Control item in this.Controls)
                {
                    if (item is Button btn && btn.Name == "BtnSzamok")
                    {
                        if (huzottak.Contains(int.Parse(btn.Text)))
                        {
                            if (btn.ForeColor == Color.Red)
                            {
                                btn.ForeColor = Color.Green;
                            }
                            else
                            {
                                btn.ForeColor= Color.Blue;
                            }
                        }
                        else if (btn.ForeColor == Color.Black)
                        {
                            btn.Enabled = false;
                        }
                        // Minden gombrol leiratjuk a metodust, igy nem lesz Click vezerles az uj jatek kezdeseig.
                        btn.Click -= Szamok_Click;
                    }
                }
                BtnSorsolas.Enabled = false;
                BtnUjJatek.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nincs eleg szam a sorsolashoz!", "Figyelmeztetes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUjJatek_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button btn && btn.Name == "BtnSzamok")
                {
                    btn.ForeColor = Color.Black;
                    btn.Enabled = true;
                    btn.Click += Szamok_Click;
                }
            }
            BtnSorsolas.Enabled = true;
            BtnUjJatek.Enabled = false;
        }

        private int JeloltGombokSzama() 
        {
            int jelolt = 0;
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Name == "BtnSzamok" && item.ForeColor == Color.Red)
                {
                    jelolt++;
                }
            }
            return jelolt;
        }

        private void Szamok_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.ForeColor == Color.Black && JeloltGombokSzama() < 5)
                {
                    btn.ForeColor = Color.Red;
                }
                else if (btn.ForeColor == Color.Black && JeloltGombokSzama() == 5)
                {
                    MessageBox.Show("Maximum 5 szam jelolheto!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private int[] OtHuzottSzam()
        {
            int[] huzottSzamok = new int[5];
            Random r = new Random();
            for (int i = 0; i < huzottSzamok.Length; i++)
            {
                int huzott;
                do
                {
                    huzott = r.Next(1, 91);
                } while (huzottSzamok.Contains(huzott));
                huzottSzamok[i] = huzott;
            }
            return huzottSzamok;
        } 
    }
}
