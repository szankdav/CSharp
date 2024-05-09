using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetegsegManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki akar lepni?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnFelvitel_Click(object sender, EventArgs e)
        {
            FrmBetegseg frm = new FrmBetegseg();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LsbAdatok.Items.Add(frm.Betegseg);
                LsbAdatok.SelectedIndex = LsbAdatok.Items.Count - 1;
            }
        }

        private void BtnModositas_Click(object sender, EventArgs e)
        {
            ////LsbAdatok.SelectedItem != null
            if (LsbAdatok.Items.Count != 0)
            {
                if (LsbAdatok.SelectedIndex != -1)
                {
                    //Betegseg b = (Betegseg)LsbAdatok.SelectedItem;
                    FrmBetegseg frm = new FrmBetegseg((Betegseg)LsbAdatok.SelectedItem);
                    frm.ShowDialog();
                    LsbAdatok.Items[LsbAdatok.SelectedIndex] = LsbAdatok.Items[LsbAdatok.SelectedIndex];
                }
                else
                {
                    MessageBox.Show("Nincs kivalasztott elem!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Modositas nem lehetseges! Nincsen adat!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMegjelenites_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.Items.Count != 0)
            {
                if (LsbAdatok.SelectedIndex != -1)
                {
                    FrmBetegseg frm = new FrmBetegseg((Betegseg)LsbAdatok.SelectedItem, true);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nincs kivalasztott elem!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Megjelenites nem lehetseges! Nincsen adat!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTorles_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1 && MessageBox.Show("Valoban torli a kijelolt elemet?", "Torles...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LsbAdatok.Items.RemoveAt(LsbAdatok.SelectedIndex);
            }
        }

        private void BtnBezaras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
