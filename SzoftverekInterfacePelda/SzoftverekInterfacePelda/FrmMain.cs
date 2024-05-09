using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzoftverekInterfacePelda
{
    public partial class FrmMain : Form
    {
        List<Szoftver> szoftverLista;
        public FrmMain()
        {
            InitializeComponent();
            szoftverLista = new List<Szoftver>();
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
            FrmSzoftver frm = new FrmSzoftver();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                szoftverLista.Add(frm.Szoftver);
                ListBoxRefresh();
            }
            else
            {
                MessageBox.Show("Uj elem letrehozasa megszakitva!", "Letrehozas sikertelen...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModositas_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmSzoftver frm = new FrmSzoftver((Szoftver)LsbAdatok.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListBoxRefresh();
                }
                else
                {
                    MessageBox.Show("Modositas megszakitva!", "Modositas sikertelen...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a modositashoz!", "Elem modositasa...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMegjelenites_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmSzoftver frm = new FrmSzoftver((Szoftver)LsbAdatok.SelectedItem, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a megjeleniteshez!", "Elem megjelenitese...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1 && MessageBox.Show("Valoban torli a kijelolt elemet?", "Torles...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                szoftverLista.RemoveAt(LsbAdatok.SelectedIndex);
                ListBoxRefresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a torleshez!", "Elem torlese...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMasolas_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                szoftverLista.Add((Szoftver)(LsbAdatok.SelectedItem as ICloneable).Clone());
                //szoftverLista.Add((Szoftver)szoftverLista[LsbAdatok.SelectedIndex].Clone());
                ListBoxRefresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a masolashoz!", "Elem masolasa...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxRefresh()
        {
            szoftverLista.Sort(); // Ez most azert mukodik parameter nelkul, mert az IComparable implementalva van az osztalyba. Ellenkezo esetben nekunk kell parameterezni, hogy mi alapjan Sort-oljon!
            LsbAdatok.DataSource = null;
            LsbAdatok.DataSource = szoftverLista;

        }
    }
}
