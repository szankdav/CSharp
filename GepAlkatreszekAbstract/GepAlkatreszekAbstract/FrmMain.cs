using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepAlkatreszekAbstract
{
    public partial class FrmMain : Form
    {
        List<GepAlkatresz> alkatreszlista;
        Font font;
        public FrmMain()
        {
            InitializeComponent();
            alkatreszlista = new List<GepAlkatresz>();
            font = BtnLetrehozas.Font;
            FrmLogo frm = new FrmLogo();
            frm.ShowDialog();
            Memoria mem = new Memoria("valami", "1234567890", 150, new Meret(15, 20), (MemoriaTipus)1, "LDD", 100.50f);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki szeretne lepni?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnLetrehozas_Click(object sender, EventArgs e)
        {
            FrmGepAlkatreszKezeles frm = new FrmGepAlkatreszKezeles(alkatreszlista);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //if (alkatreszlista.Count > 0)
                //{
                //    foreach (GepAlkatresz item in alkatreszlista)
                //    {
                //        if (item.Megnevezes == frm.Alkatresz.Megnevezes)
                //        {
                //            MessageBox.Show("Ilyen nevvel mar szerepel alkatresz a listaban! Kerem, mas nevet adjon meg!", "Nev utkozes...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }
                //        else
                //        {
                //            alkatreszlista.Add(frm.Alkatresz);
                //            ListBoxRefresh();
                //            LsbAdatok.SelectedIndex = LsbAdatok.Items.Count - 1;
                //        }
                //    }
                //}
                //else
                //{
                //    alkatreszlista.Add(frm.Alkatresz);
                //    ListBoxRefresh();
                //    LsbAdatok.SelectedIndex = LsbAdatok.Items.Count - 1;
                //}
                alkatreszlista.Add(frm.Alkatresz);
                ListBoxRefresh();
                LsbAdatok.SelectedIndex = LsbAdatok.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("On megszakitotta a felvitelt!", "Uj alkatresz letrehozasa...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModositas_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmGepAlkatreszKezeles frm = new FrmGepAlkatreszKezeles((GepAlkatresz)LsbAdatok.SelectedItem, alkatreszlista);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("On megszakitotta a modositast!", "Alkatresz modositasa...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolt elem a modositashoz!", "Elem modositasa...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMegjelenites_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmGepAlkatreszKezeles frm = new FrmGepAlkatreszKezeles((GepAlkatresz)LsbAdatok.SelectedItem, alkatreszlista, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelolt elem a megjeleniteshez!", "Elem megjelenitese...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1 && MessageBox.Show("Valoban torli a kijelolt elemet?", "Torles...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                alkatreszlista.RemoveAt(LsbAdatok.SelectedIndex);
                ListBoxRefresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelolt elem a torleshez!", "Elem torlese...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxRefresh()
        {
            LsbAdatok.DataSource = null;
            LsbAdatok.DataSource = alkatreszlista;
        }

        private void LsbAdatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                TxbAlapanyagAr.Text = $"{alkatreszlista[LsbAdatok.SelectedIndex].AlapanyagAr()} Ft.-";
            }
            else
            {
                TxbAlapanyagAr.Text = string.Empty;
            }
        }

        private void LsbAdatok_DoubleClick(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                MessageBox.Show($"A kivalasztott alkatreszben talalhato nemesfem erteke: {alkatreszlista[LsbAdatok.SelectedIndex].AlapanyagAr()} Ft.-", "Nemsfem ertek...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nincs kivalasztott elem a megjeleniteshez!", "Nemesfem ertek...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLetrehozas_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button).Font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
            }

        }

        private void BtnLetrehozas_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                (sender as Button).Font = font;
            }
        }
    }
}
