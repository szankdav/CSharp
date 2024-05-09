using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gepjarmuvek;

namespace Felhasznalo
{
    public delegate void GepjarmuKolcsonzeseEsemenyKezelo(Gepjarmu jarmu, Gepjarmuvek.Felhasznalo kolcsonzoFelhasznalo);
    public delegate void GepjarmuKolcsonzeseNemLehetsegesEsemenyKezelo(Gepjarmu jarmu);
    public partial class FrmMain : Form
    {
        public event GepjarmuKolcsonzeseEsemenyKezelo JarmuKolcsonzes;
        public event GepjarmuKolcsonzeseNemLehetsegesEsemenyKezelo JarmuKolcsonzesNemLehetseges;
        List<Gepjarmu> jarmuvek;
        Gepjarmuvek.Felhasznalo bejelentkezettFelhasznalo;
        public FrmMain()
        {
            InitializeComponent();
            jarmuvek = new List<Gepjarmu>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmBejelentkezes frm = new FrmBejelentkezes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FileInfo jarmuvekCSV = new FileInfo("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\jarmuvek.csv");
                jarmuvekCSV.Attributes &= ~FileAttributes.Hidden;
                StreamReader jarmuReader = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\jarmuvek.csv");
                if (File.Exists("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\jarmuvek.csv"))
                {
                    try
                    {
                        while (!jarmuReader.EndOfStream)
                        {
                            Gepjarmu beolvasottJarmu = Gepjarmu.GepjarmuCSVBetoltes(jarmuReader.ReadLine());
                            jarmuvek.Add(beolvasottJarmu);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                jarmuReader.Close();
                File.SetAttributes("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\jarmuvek.csv", FileAttributes.Hidden);
                JarmuKolcsonzes = KolcsonzesiAllapotModositas;
                JarmuKolcsonzesNemLehetseges = KolcsonzesNemLehetseges;
                LsbFelhasznaloJarmuvek.DataSource = jarmuvek;
                bejelentkezettFelhasznalo = frm.BejelentkezettFelhasznalo;
                LblFelhasznaloBejelnetkezettFelhasznalo.Text = $"Bejelentkezett felhasználó: {bejelentkezettFelhasznalo.Nev}";
            }
            else
            {
                MessageBox.Show("Bejelentkezés megszakítva! A program kilép!", "Kilépés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnFelhasznaloValtas_Click(object sender, EventArgs e)
        {
            FrmBejelentkezes frm = new FrmBejelentkezes();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bejelentkezettFelhasznalo = frm.BejelentkezettFelhasznalo;
                LblFelhasznaloBejelnetkezettFelhasznalo.Text = $"Bejelentkezett felhasználó: {bejelentkezettFelhasznalo.Nev}";

            }
            else
            {
                MessageBox.Show("Felhasználóváltás megszakítva!", "Felhasználóváltás...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnJarmuKolcsonzese_Click(object sender, EventArgs e)
        {
            if (LsbFelhasznaloJarmuvek.SelectedIndex != -1)
            {
                Gepjarmu kivalasztottJarmu = (LsbFelhasznaloJarmuvek.SelectedItem as Gepjarmu);
                if (kivalasztottJarmu.KolcsonzesiAllapot == false)
                {
                    JarmuKolcsonzes?.Invoke(kivalasztottJarmu, bejelentkezettFelhasznalo);
                    ListBoxRefresh();
                }
                else if (kivalasztottJarmu.KolcsonzesiAllapot == true && kivalasztottJarmu.KolcsonzoFelhasznalo.Nev == bejelentkezettFelhasznalo.Nev)
                {
                    MessageBox.Show("Már kikölcsönözte ezt a járművet! Jármű kölcsönzésének visszavonásához használja a \"Jármű kölcsönzésének visszavonása\" gombot!", "Kölcsönzés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (kivalasztottJarmu.KolcsonzesiAllapot == true)
                {
                    //Amennyiben a jármű már ki van kölcsönözve, az váltson ki egy újabb eseményt.Ebben az eseményben legyen benne, hogy mikor lett bejegyezve a kölcsönzés és ki váltotta ki az eseményt és ezt jelenítsük meg a felhasználónak."
                    JarmuKolcsonzesNemLehetseges?.Invoke(kivalasztottJarmu);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölve jármű a kölcsönzéshez!", "Kölcsönzés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void KolcsonzesiAllapotModositas(Gepjarmu jarmu, Gepjarmuvek.Felhasznalo felhasznalo)
        {
            jarmu.KolcsonzesiAllapot = true;
            jarmu.KolcsonzoFelhasznalo = felhasznalo;
            jarmu.KolcsonzesIdeje = DateTime.Now;
            MessageBox.Show("Kikölcsönözte ezt a járművet!", "Kölcsönzés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KolcsonzesNemLehetseges(Gepjarmu jarmu)
        {
            MessageBox.Show($"A jármű kölcsönzése nem lehetséges, mert azt kikölcsönözte {jarmu.KolcsonzoFelhasznalo.Nev} nevű felhasználó, {jarmu.KolcsonzesIdeje.ToShortDateString()} időpontban!", "Kölcsönzés nem lehetséges...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFelhasznaloJarmukolcsonzesVisszavonasa_Click(object sender, EventArgs e)
        {
            if (jarmuvek[LsbFelhasznaloJarmuvek.SelectedIndex].KolcsonzoFelhasznalo != null)
            {
                if (LsbFelhasznaloJarmuvek.SelectedIndex != -1 && jarmuvek[LsbFelhasznaloJarmuvek.SelectedIndex].KolcsonzoFelhasznalo.Nev == bejelentkezettFelhasznalo.Nev)
                {
                    jarmuvek[LsbFelhasznaloJarmuvek.SelectedIndex].KolcsonzesiAllapot = false;
                    jarmuvek[LsbFelhasznaloJarmuvek.SelectedIndex].KolcsonzoFelhasznalo = null;
                    jarmuvek[LsbFelhasznaloJarmuvek.SelectedIndex].KolcsonzesIdeje = default;
                    MessageBox.Show("Kikölcsönzés visszavonva!", "Kölcsönzés visszavonása...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Kölcsönzést csak a kölcsönző felhasználó vonhat vissza!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("A jármű nincs kikölcsönözve, így kölcsönzés visszavonása nem lehetséges!", "Kölcsönzés visszavonása...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListBoxRefresh()
        {
            LsbFelhasznaloJarmuvek.DataSource = null;
            LsbFelhasznaloJarmuvek.DataSource = jarmuvek;
        }
    }
}
