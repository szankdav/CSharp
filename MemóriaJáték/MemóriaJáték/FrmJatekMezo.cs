using MemóriaJáték;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemóriaJáték
{
    public partial class FrmJatekMezo : Form
    {
        Random r = new Random();
        Stopwatch Stopwatch = new Stopwatch();
        public FrmJatekMezo()
        {
            InitializeComponent();
        }

        private void FrmJatekMezo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // e.CloseReason == CloseReason.UserClosing
            //if (sender is Button btn)
            //{
            //    if (btn.Text == "Új játék")
            //    {
            //        Stopwatch.Stop();
            //        FrmJatekTipusValasztas frm = new FrmJatekTipusValasztas();
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            if (frm.JatekTipus == 1)
            //            {
            //                FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
            //                frmJatekMezo.ShowDialog();
            //            }
            //            else
            //            {
            //                FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
            //                frmJatekMezo.ShowDialog();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    if (MessageBox.Show("Valóban ki szeretne lépni a játékból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //    {
            //        e.Cancel = true;
            //    }
            //}

            if (MessageBox.Show("Valóban ki szeretne lépni a játékból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        public FrmJatekMezo(int tipus) : this()
        {
            if (tipus == 1)
            {
                int top = GrbJatekMezo.Top, left = GrbJatekMezo.Left;

                for (int i = 1; i <= 30; i++)
                {
                    Button btn = new Button()
                    {
                        Parent = GrbJatekMezo,
                        Top = top,
                        Left = left,
                        Width = 92,
                        Height = 35,
                    };
                    btn.Click += Btn_Click;
                    if (i % 5 == 0)
                    {
                        top += 41;
                        left = GrbJatekMezo.Left;
                    }
                    else
                    {
                        left += 98;
                    }
                }

                List<int> randomSzamokListaja = new List<int>();
                for (int j = 0; j < 15; j++)
                {
                    int randomSzam;
                    do
                    {
                        randomSzam = r.Next(1, 10000);
                    } while (randomSzamokListaja.Contains(randomSzam));
                    randomSzamokListaja.Add(randomSzam);
                }

                List<int> szamIndexekAmikMarVoltak = new List<int>();
                List<int> gombIndexekAmikMarVoltak = new List<int>();
                for (int k = 0; k < GrbJatekMezo.Controls.Count / 2; k++)
                {
                    int randomSzamIndexeListabol;
                    do
                    {
                        randomSzamIndexeListabol = r.Next(0, randomSzamokListaja.Count);
                    } while (szamIndexekAmikMarVoltak.Contains(randomSzamIndexeListabol));
                    szamIndexekAmikMarVoltak.Add(randomSzamIndexeListabol);

                    int randomGombIndex1;
                    int randomGombIndex2;
                    do
                    {
                        randomGombIndex1 = r.Next(0, GrbJatekMezo.Controls.Count);
                        randomGombIndex2 = r.Next(0, GrbJatekMezo.Controls.Count);
                    } while (randomGombIndex1 == randomGombIndex2 || gombIndexekAmikMarVoltak.Contains(randomGombIndex1) || gombIndexekAmikMarVoltak.Contains(randomGombIndex2));
                    gombIndexekAmikMarVoltak.Add(randomGombIndex1);
                    gombIndexekAmikMarVoltak.Add(randomGombIndex2);

                    GrbJatekMezo.Controls[randomGombIndex1].Tag = randomSzamokListaja[randomSzamIndexeListabol].ToString();
                    GrbJatekMezo.Controls[randomGombIndex2].Tag = randomSzamokListaja[randomSzamIndexeListabol].ToString();
                }
                Stopwatch.Start();
            }
        }
        string gombSzama = string.Empty;
        int aktivGomb = 0;
        int zoldMezok = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string totalTime = $"{(int)Stopwatch.Elapsed.TotalMinutes}:{(int)Stopwatch.Elapsed.TotalSeconds}";
            LblIdomero.Text = totalTime; //??????
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (aktivGomb == 0)
            {
                gombSzama = string.Empty;
            }
            if (sender is Button btn)
                if (btn.Text == string.Empty && gombSzama == string.Empty && aktivGomb == 0)
                {
                    btn.Text = btn.Tag.ToString();
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                    gombSzama = btn.Text;
                    aktivGomb++;
                }
                else if (btn.Text == string.Empty && aktivGomb == 1)
                {
                    btn.Text = btn.Tag.ToString();
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                    aktivGomb++;
                    //Thread.Sleep(3000);
                    if (btn.Text == gombSzama)
                    {
                        foreach (Button item in GrbJatekMezo.Controls)
                        {
                            if (item.Tag.ToString() == gombSzama)
                            {
                                item.Enabled = false;
                                item.BackColor = Color.Green;
                                aktivGomb = 0;
                                zoldMezok += 1;
                                if (zoldMezok == 30)
                                {
                                    Stopwatch.Stop();
                                    if (MessageBox.Show("Gratulálok! Nyertél! Szeretnél új játékot indítani?", "Játék vége...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                    {
                                        FrmJatekTipusValasztas frm = new FrmJatekTipusValasztas();
                                        frm.ShowDialog();
                                    }
                                    else
                                    {
                                        string jatekosNev = Microsoft.VisualBasic.Interaction.InputBox("Kérlek add meg a neved:", "Játékosnév", "Anonym");
                                        string elertEredmeny = $"Játékos: {jatekosNev} - Játékidő: {LblIdomero.Text}";
                                        File.AppendAllText("eredmenyek.txt", elertEredmeny + Environment.NewLine);
                                        this.Close();
                                    }
                                }
                            }
                        }
                    }
                    //else
                    //{
                    //    foreach (Button item in GrbJatekMezo.Controls)
                    //    {
                    //        if (item.BackColor != Color.Green)
                    //        {
                    //            item.Text = string.Empty;
                    //            gombSzama = string.Empty;
                    //        }
                    //    }
                    //    aktivGomb = 0;
                    //}
                }
                else if (aktivGomb == 2)
                {
                    //MessageBox.Show("Egyszerre csak kettő gomb lehet aktív!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    foreach (Button item in GrbJatekMezo.Controls)
                    {
                        if (item.BackColor != Color.Green)
                        {
                            item.Text = string.Empty;
                            gombSzama = string.Empty;
                        }
                    }
                    aktivGomb = 0;
                }
            //else
            //{
            //    btn.Text = string.Empty;
            //    aktivGomb--;
            //}
        }

        private void BtnUjJatekJatekbol_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos be szeretné fejezni a folyamatban lévő játékot, és új játékot indít?", "Új játék...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Stopwatch.Stop();
                this.Close();
                //ujJatek = !ujJatek;
                //FrmJatekTipusValasztas frm = new FrmJatekTipusValasztas();
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //    if (frm.JatekTipus == 1)
                //    {
                //        FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
                //        frmJatekMezo.ShowDialog();
                //    }
                //    else
                //    {
                //        FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
                //        frmJatekMezo.ShowDialog();
                //    }
                //}
            }
            else
            {
                MessageBox.Show("Új játék indításva megszakítva!", "Új játék...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnKilepesJatekbol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}