using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCRaktarKezelo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLetrehozas_Click(object sender, EventArgs e)
        {
            FrmTermek frm = new FrmTermek();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LsbAdatok.Items.Add(frm.Termek);
            }
        }

        private void BtnModositas_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmTermek frm = new FrmTermek((AltalanosTermek)LsbAdatok.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int index = LsbAdatok.SelectedIndex;
                    //LsbAdatok.Items[index] = frm.Termek; ??????????????????
                    LsbAdatok.Items.RemoveAt(index);
                    LsbAdatok.Items.Insert(index, frm.Termek);
                    LsbAdatok.SelectedIndex = index;
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolve termek a modositashoz!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void BtnMegjelenites_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                FrmTermek frm = new FrmTermek((AltalanosTermek)LsbAdatok.SelectedItem, true);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs kijelolve termek a megjeleniteshez!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1 && MessageBox.Show("Valoban ki szeretne torolni a kijelolt elemet?", "Torles...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LsbAdatok.Items.RemoveAt(LsbAdatok.SelectedIndex);
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki szeretne lepni?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
