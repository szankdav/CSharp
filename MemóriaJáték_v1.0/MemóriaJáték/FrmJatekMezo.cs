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
        int jatekTipus;
        string jatekosNev;
        public FrmJatekMezo()
        {
            InitializeComponent();
        }

        bool ujJatek;
        private void FrmJatekMezo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ujJatek)
            {
                if (MessageBox.Show("Biztos be szeretné fejezni a folyamatban lévő játékot, és új játékot indít?", "Új játék...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Stopwatch.Stop();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Új játék indításva megszakítva!", "Új játék...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ujJatek = false;
                    e.Cancel = true;
                }
            }
            else
            {
                if (MessageBox.Show("Valóban ki szeretne lépni a játékból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        public FrmJatekMezo(int tipus) : this()
        {
            jatekosNev = Microsoft.VisualBasic.Interaction.InputBox("Kérlek add meg a neved:", "Játékosnév", "Anonym");
            List<int> gombIndexekAmikMarVoltak = new List<int>();
            if (tipus == 1)
            {
                JatekMezoGeneralas();
                jatekTipus = 1;
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
            else
            {
                JatekMezoGeneralas();
                jatekTipus = 2;
                int[,] szinek = new int[15, 3];
                for (int i = 0; i < szinek.GetLength(0); i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        szinek[i, j] = r.Next(0, 256);
                    }
                }

                List<int> randomSzinekListaja = new List<int>();
                for (int k = 0; k < GrbJatekMezo.Controls.Count / 2; k++)
                {
                    int randomSzinIndexeTombbol;
                    do
                    {
                        randomSzinIndexeTombbol = r.Next(0, szinek.GetLength(0));
                    } while (randomSzinekListaja.Contains(randomSzinIndexeTombbol));
                    randomSzinekListaja.Add(randomSzinIndexeTombbol);

                    int randomGombIndex1;
                    int randomGombIndex2;
                    do
                    {
                        randomGombIndex1 = r.Next(0, GrbJatekMezo.Controls.Count);
                        randomGombIndex2 = r.Next(0, GrbJatekMezo.Controls.Count);
                    } while (randomGombIndex1 == randomGombIndex2 || gombIndexekAmikMarVoltak.Contains(randomGombIndex1) || gombIndexekAmikMarVoltak.Contains(randomGombIndex2));
                    gombIndexekAmikMarVoltak.Add(randomGombIndex1);
                    gombIndexekAmikMarVoltak.Add(randomGombIndex2);

                    //GrbJatekMezo.Controls[randomGombIndex1].BackColor = Color.FromArgb(szinek[randomSzinIndexeTombbol, 0], szinek[randomSzinIndexeTombbol, 1], szinek[randomSzinIndexeTombbol, 2]);
                    //GrbJatekMezo.Controls[randomGombIndex2].BackColor = Color.FromArgb(szinek[randomSzinIndexeTombbol, 0], szinek[randomSzinIndexeTombbol, 1], szinek[randomSzinIndexeTombbol, 2]);
                    GrbJatekMezo.Controls[randomGombIndex1].Tag = $"{szinek[randomSzinIndexeTombbol, 0]}, {szinek[randomSzinIndexeTombbol, 1]}, {szinek[randomSzinIndexeTombbol, 2]}";
                    GrbJatekMezo.Controls[randomGombIndex2].Tag = $"{szinek[randomSzinIndexeTombbol, 0]}, {szinek[randomSzinIndexeTombbol, 1]}, {szinek[randomSzinIndexeTombbol, 2]}";
                }
                Stopwatch.Start();
            }
        }
        string gombSzama = string.Empty;
        int aktivGomb = 0;
        int zoldMezok = 0;
        Color aktivGombSzine;

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = Stopwatch.Elapsed;
            string totalTime = $"{ts.Minutes}:{ts.Seconds}";
            //string totalTime = $"{(int)Stopwatch.Elapsed.TotalMinutes}:{(int)Stopwatch.Elapsed.TotalSeconds}";
            LblIdomero.Text = totalTime; //??????
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (jatekTipus == 1)
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
                                        string elertEredmeny = $"Játékos: {jatekosNev} - Játéktípus: Színes memóriajáték - Játékidő: {LblIdomero.Text}";
                                        File.AppendAllText("eredmenyek.txt", elertEredmeny + Environment.NewLine);
                                        Stopwatch.Stop();
                                        if (MessageBox.Show("Gratulálok! Nyertél! Szeretnél új játékot indítani?", "Játék vége...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                        }
                                        else
                                        {
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
            else
            {
                if (sender is Button szinesBtn)
                {
                    if (aktivGomb == 0)
                    {
                        string[] rgb = szinesBtn.Tag.ToString().Split(',');
                        int[] szinKod = new int[rgb.Length];
                        for (int i = 0; i < szinKod.Length; i++)
                        {
                            szinKod[i] = int.Parse(rgb[i]);
                        }
                        szinesBtn.BackColor = Color.FromArgb(szinKod[0], szinKod[1], szinKod[2]);
                        aktivGombSzine = szinesBtn.BackColor;
                        aktivGomb++;
                    }
                    else if (szinesBtn.BackColor.Name == "Control" && aktivGomb == 1)
                    {
                        string[] rgb = szinesBtn.Tag.ToString().Split(',');
                        int[] szinKod = new int[rgb.Length];
                        for (int i = 0; i < szinKod.Length; i++)
                        {
                            szinKod[i] = int.Parse(rgb[i]);
                        }
                        szinesBtn.BackColor = Color.FromArgb(szinKod[0], szinKod[1], szinKod[2]);
                        aktivGomb++;

                        if (szinesBtn.BackColor == aktivGombSzine)
                        {
                            foreach (Button item in GrbJatekMezo.Controls)
                            {
                                if (item.BackColor == aktivGombSzine)
                                {
                                    item.Enabled = false;
                                    aktivGomb = 0;
                                    zoldMezok += 1;
                                    if (zoldMezok == 30)
                                    {
                                        string elertEredmeny = $"Játékos: {jatekosNev} - Játéktípus: Színes memóriajáték - Játékidő: {LblIdomero.Text}";
                                        File.AppendAllText("eredmenyek.txt", elertEredmeny + Environment.NewLine);
                                        Stopwatch.Stop();
                                        if (MessageBox.Show("Gratulálok! Nyertél! Szeretnél új játékot indítani?", "Játék vége...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                                        {
                                            this.DialogResult = DialogResult.OK;
                                        }
                                        else
                                        {
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (aktivGomb == 2)
                    {
                        //MessageBox.Show("Egyszerre csak kettő gomb lehet aktív!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        foreach (Button item in GrbJatekMezo.Controls)
                        {
                            if (item.Enabled)
                            {
                                item.BackColor = default(Color);
                                item.UseVisualStyleBackColor = true;
                            }
                        }
                        aktivGomb = 0;
                    }
                }
            }
        }

        private void BtnUjJatekJatekbol_Click(object sender, EventArgs e)
        {
            ujJatek = true;
            this.Close();
        }

        private void BtnKilepesJatekbol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JatekMezoGeneralas()
        {
            int top = GrbJatekMezo.Top, left = GrbJatekMezo.Left;

            for (int i = 1; i <= 30; i++)
            {
                Button btn = new Button()
                {
                    Parent = GrbJatekMezo,
                    Top = top - 40,
                    Left = left - 6,
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
        }
    }
}