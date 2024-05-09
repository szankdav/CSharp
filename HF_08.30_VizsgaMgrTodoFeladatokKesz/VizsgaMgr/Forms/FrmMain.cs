using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizsgaMgr
{
    public partial class FrmMain : Form
    {
        List<Vizsga> vizsgak;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            vizsgak = new List<Vizsga>();
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (MessageBox.Show("Szeretne fajlt megnyitni?", "Megnyitas...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamReader file = new StreamReader(openFileDialog1.FileName);
                    while (!file.EndOfStream)
                    {
                        string csvSora = file.ReadLine();
                        string[] csvSorAdatai = csvSora.Split(';');
                        try
                        {
                            Vizsga betoltottVizsga = new Vizsga(csvSorAdatai[0], byte.Parse(csvSorAdatai[1]));
                            for (int i = 2; i < csvSorAdatai.Length; i += 2)
                            {
                                Feladat betoltottFeladat = new Feladat(csvSorAdatai[i], byte.Parse(csvSorAdatai[i + 1]));
                                betoltottVizsga.UjFeladat(betoltottFeladat);
                            }
                            vizsgak.Add(betoltottVizsga);
                            ListBoxRefresh();
                            LblVizsgak.Text =$"Vizsgak [Osszes vizsga pontszam: {Vizsga.OsszesVizsgaOsszesPontszama(vizsgak).ToString()}]";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.None;
                        }
                    }
                    file.Close();
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Valóban ki akar lépni?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                saveFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog1.DefaultExt = "csv";
                if (MessageBox.Show("Szeretne menteni a vizsgakat es a hozza tartozo feladatokat?", "Mentes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter file = new StreamWriter(saveFileDialog1.FileName);
                        foreach (Vizsga vizsga in LsbVizsgak.Items)
                        {
                            string csvSor = $"{vizsga.Megnevezes.Trim()};{vizsga.OsszPontszam.ToString().Trim()}";
                            foreach (Feladat feladat in vizsga.Feladatok)
                            {
                                csvSor += $";{feladat.Leiras};{feladat.PontSzam.ToString().Trim()}";
                            }
                            file.WriteLine(csvSor);
                            file.Flush();
                        }
                        file.Close();
                    }
                    else
                    {
                        MessageBox.Show("A program kilep! Viszontlatasra!", "Kilepes...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void VizsgaLetrehozasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVizsga frm = new FrmVizsga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                vizsgak.Add(frm.Vizsga);
                ListBoxRefresh();
                LblVizsgak.Text = $"Vizsgak [Osszes vizsga pontszam: {Vizsga.OsszesVizsgaOsszesPontszama(vizsgak).ToString()}]";
                LsbVizsgak.SelectedIndex = LsbVizsgak.Items.Count - 1;
            }
        }

        private void VizsgaModositasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (LsbVizsgak.SelectedItem != null)
            if (LsbVizsgak.SelectedIndex != -1)
            {
                FrmVizsga frm = new FrmVizsga((Vizsga)LsbVizsgak.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListBoxRefresh();
                    LblVizsgak.Text = $"Vizsgak [Osszes vizsga pontszam: {Vizsga.OsszesVizsgaOsszesPontszama(vizsgak).ToString()}]";
                }
            }
            else
            {
                MessageBox.Show("Nincs rekord kijelölve a vizsga módosításához!", "Vizsga módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VizsgaMegjeleniteseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (LsbVizsgak.SelectedItem != null)
            if (LsbVizsgak.SelectedIndex != -1)
            {
                FrmVizsga frm = new FrmVizsga((Vizsga)LsbVizsgak.SelectedItem, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs rekord kijelölve a vizsga megjelenítéséhez!", "Vizsga megjelenítése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VizsgaTorleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LsbVizsgak.SelectedIndex != -1 && MessageBox.Show("Biztosan törli a kijelölt vizsgát?", "Vizsga törlése...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vizsgak.RemoveAt(LsbVizsgak.SelectedIndex);
                ListBoxRefresh();
                LblVizsgak.Text = $"Vizsgak [Osszes vizsga pontszam: {Vizsga.OsszesVizsgaOsszesPontszama(vizsgak).ToString()}]";
            }
            else
            {
                MessageBox.Show("Nincs rekord kijelölve a vizsga törléséhez!", "Vizsga törlése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FeladatLetrehozasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LsbVizsgak.SelectedIndex != -1)
            {

                byte maxPont = (byte)(vizsgak[LsbVizsgak.SelectedIndex].OsszPontszam - vizsgak[LsbVizsgak.SelectedIndex].FeladatokOsszpontszama);
                if (maxPont == 0)
                {
                    MessageBox.Show("A vizsga már elérte a maximális pontszámát! Új feladatot az eddigiek mellé már nem lehet felvinni! Töröljön feladatot és utána próbálkozzon újra!", "Feladat létrehozása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmFeladat frm = new FrmFeladat(maxPont);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            vizsgak[LsbVizsgak.SelectedIndex].UjFeladat(frm.Feladat);
                            LsbVizsgak_SelectedIndexChanged(sender, e);
                            LsbFeladatok.SelectedIndex = LsbFeladatok.Items.Count - 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.None;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs vizsga kijelölve a feladat létrehozásához!", "Feladat létrehozása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FeladatModositasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LsbFeladatok.SelectedIndex != -1)
            {
                byte maxPont = (byte)(vizsgak[LsbVizsgak.SelectedIndex].OsszPontszam - vizsgak[LsbVizsgak.SelectedIndex].FeladatokOsszpontszama);

                //Feladat temp = vizsgak[LsbVizsgak.SelectedIndex].Feladatok[LsbFeladatok.SelectedIndex];

                FrmFeladat frm = new FrmFeladat(maxPont, vizsgak[LsbVizsgak.SelectedIndex].Feladatok[LsbFeladatok.SelectedIndex]);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = LsbFeladatok.SelectedIndex;
                    LsbVizsgak_SelectedIndexChanged(sender, e);
                    LsbFeladatok.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Nincs feladat kijelölve a módosításhoz!", "Feladat módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FeladatMegjeleniteseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LsbFeladatok.SelectedIndex != -1)
            {
                byte maxPont = (byte)(vizsgak[LsbVizsgak.SelectedIndex].OsszPontszam - vizsgak[LsbVizsgak.SelectedIndex].FeladatokOsszpontszama);
                FrmFeladat frm = new FrmFeladat(maxPont, vizsgak[LsbVizsgak.SelectedIndex].Feladatok[LsbFeladatok.SelectedIndex], true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs feladat kijelölve a megjelenítéshez!", "Feladat megjelenítése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FeladatTorleseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LsbFeladatok.SelectedIndex != -1 && MessageBox.Show("Biztosan törli a kijelölt feladatot?", "Feladat törlése...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                vizsgak[LsbVizsgak.SelectedIndex].FeladatTorlese(LsbFeladatok.SelectedIndex);
                LsbVizsgak_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Nincs feladat kijelölve a törléshez!", "Feladat törlése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void KilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LsbVizsgak_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsbFeladatok.DataSource = null;
            if (LsbVizsgak.SelectedIndex != -1)
            {
                LsbFeladatok.DataSource = vizsgak[LsbVizsgak.SelectedIndex].Feladatok;
                LblFeladatok.Text = $"Feladatok [Osszes feladat pontszam: {Feladat.OsszesFeladatOsszesPontSzama(vizsgak[LsbVizsgak.SelectedIndex]).ToString()}]";
            }
        }

        private void ListBoxRefresh()
        {
            LsbVizsgak.DataSource = null; // Kitörlöm a DS-t - megszűnik a kapcsolat
            LsbVizsgak.DataSource = vizsgak; // Újra létrejön a kapcsolat - és "új kép készül" a listáról
        }
    }
}
