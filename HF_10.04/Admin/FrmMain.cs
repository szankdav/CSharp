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
using Gepjarmuvek;

namespace Admin
{
    public partial class FrmMain : Form
    {
        List<Gepjarmu> jarmuvek;
        List<Felhasznalo> felhasznalok;
        public FrmMain()
        {
            InitializeComponent();
            jarmuvek = new List<Gepjarmu>();
            felhasznalok = new List<Felhasznalo>();
        }

        private void FrmMain_Load(object sender, EventArgs e)
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
            LsbAdminJarmuLista.DataSource = jarmuvek;

            FileInfo felhasznalokCSV = new FileInfo("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv");
            felhasznalokCSV.Attributes &= ~FileAttributes.Hidden;
            StreamReader felhasznaloReader = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv");
            if (File.Exists("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv"))
            {
                try
                {
                    while (!felhasznaloReader.EndOfStream)
                    {
                        felhasznalok.Add(Gepjarmuvek.Felhasznalo.felhasznaloCSVBetoltes(felhasznaloReader.ReadLine()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            felhasznaloReader.Close();
            File.SetAttributes("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv", FileAttributes.Hidden);
            LsbAdminFelhasznaloLista.DataSource = felhasznalok;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                FileInfo jarmuvekCSV = new FileInfo("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\jarmuvek.csv");
                jarmuvekCSV.Attributes &= ~FileAttributes.Hidden;
                StreamWriter jarmuWriter = new StreamWriter("jarmuvek.csv");
                File.SetAttributes("jarmuvek.csv", FileAttributes.Hidden);

                foreach (Gepjarmu jarmu in LsbAdminJarmuLista.Items)
                {
                    if (jarmu is Auto auto)
                    {
                        jarmuWriter.WriteLine(auto.AutoCSVMentes());
                    }
                    else if(jarmu is Motor motor)
                    {
                        jarmuWriter.WriteLine(motor.MotorCSVMentes());
                    }
                }
                jarmuWriter.Close();

                FileInfo felhasznalokCSV = new FileInfo("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv");
                felhasznalokCSV.Attributes &= ~FileAttributes.Hidden;
                StreamWriter felhasznaloWriter = new StreamWriter("felhasznalok.csv");
                File.SetAttributes("felhasznalok.csv", FileAttributes.Hidden);

                foreach (Felhasznalo felhasznalo in LsbAdminFelhasznaloLista.Items)
                {
                    felhasznaloWriter.WriteLine(felhasznalo.FelhasznaloCSVMentes());
                }
                felhasznaloWriter.Close();
            }
        }

        private void BtnAdminUjJarmu_Click(object sender, EventArgs e)
        {
            FrmUjJarmu frm = new FrmUjJarmu();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                jarmuvek.Add(frm.Jarmu);
                ListBoxRefresh();
                LsbAdminJarmuLista.SelectedIndex = LsbAdminJarmuLista.Items.Count - 1;
            }
        }

        private void BtnAdminJarmuModositasa_Click(object sender, EventArgs e)
        {
            if (LsbAdminJarmuLista.SelectedIndex != -1)
            {
                FrmUjJarmu frm = new FrmUjJarmu((Gepjarmu)LsbAdminJarmuLista.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Ön megszakította a módosítást!", "Jármű módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt jármű a módosításhoz!", "Jármű módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdminJarmuMegjelenitese_Click(object sender, EventArgs e)
        {
            if (LsbAdminJarmuLista.SelectedIndex != -1)
            {
                FrmUjJarmu frm = new FrmUjJarmu((Gepjarmu)LsbAdminJarmuLista.SelectedItem, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt jármű a megjelenítéshez!", "Jármű megjelenítése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdminJarmuTorlese_Click(object sender, EventArgs e)
        {
            if (LsbAdminJarmuLista.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan törölni szeretné a kijelölt járművet?", "Törlés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    jarmuvek.RemoveAt(LsbAdminJarmuLista.SelectedIndex);
                    ListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Törlés megszakítva!", "Törlés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolt jármű a törléshez!", "Jármű törlése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListBoxRefresh()
        {
            LsbAdminJarmuLista.DataSource = null;
            LsbAdminJarmuLista.DataSource = jarmuvek;
        }

        private void BtnAdminUjFelhasznalo_Click(object sender, EventArgs e)
        {
            FrmUjFelhasznalo frm = new FrmUjFelhasznalo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                felhasznalok.Add(frm.Felhasznalo);
                FelhasznaloListBoxRefresh();
            }
        }

        private void BtnAdminFelhasznaloModositasa_Click(object sender, EventArgs e)
        {
            if (LsbAdminFelhasznaloLista.SelectedIndex != -1)
            {
                FrmUjFelhasznalo frm = new FrmUjFelhasznalo((Felhasznalo)LsbAdminFelhasznaloLista.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    FelhasznaloListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Ön megszakította a módosítást!", "Felhasználó módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolt felhasználó a módosításhoz!", "Felhasználó módosítása...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdminFelhasznaloMegjelenitese_Click(object sender, EventArgs e)
        {
            if (LsbAdminFelhasznaloLista.SelectedIndex != -1)
            {
                FrmUjFelhasznalo frm = new FrmUjFelhasznalo((Felhasznalo)LsbAdminFelhasznaloLista.SelectedItem, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelölt felhasználó a megjelenítéshez!", "Felhasználó megjelenítése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAdminFelhasznaloTorlese_Click(object sender, EventArgs e)
        {
            if (LsbAdminFelhasznaloLista.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan törölni szeretné a kijelölt felhasználót?", "Törlés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    felhasznalok.RemoveAt(LsbAdminFelhasznaloLista.SelectedIndex);
                    FelhasznaloListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Törlés megszakítva!", "Törlés...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolt felhasználó a törléshez!", "Felhasználó törlése...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void FelhasznaloListBoxRefresh()
        {
            LsbAdminFelhasznaloLista.DataSource = null;
            LsbAdminFelhasznaloLista.DataSource = felhasznalok;
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LsbAdminJarmuLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsbAdminFelhasznaloLista.ClearSelected();
        }

        private void LsbAdminFelhasznaloLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsbAdminJarmuLista.ClearSelected();
        }
    }
}
