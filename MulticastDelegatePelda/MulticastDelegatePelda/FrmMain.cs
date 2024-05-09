using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulticastDelegatePelda
{
    public partial class FrmMain : Form
    {
        MentesMetodusok mentesek;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnUjVizsga_Click(object sender, EventArgs e)
        {
            FrmVizsga frm = new FrmVizsga();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LsbAdatok.Items.Add(frm.Vizsga);
                if (mentesek == null)
                {
                    mentesek = new MentesMetodusok(frm.Vizsga.VizsgaMentes);
                }
                else
                {
                    mentesek += frm.Vizsga.VizsgaMentes;
                }

                if (frm.Vizsga.KepUtvonal != "")
                {
                    mentesek += frm.Vizsga.KepMentes;
                }
            }
        }

        private void BtnVizsgaTorles_Click(object sender, EventArgs e)
        {
            if (LsbAdatok.SelectedIndex != -1)
            {
                if (MessageBox.Show("Valoban torli a kijelolt elemet?", "Torles...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    mentesek -= (LsbAdatok.SelectedItem as Vizsga).VizsgaMentes;
                    if ((LsbAdatok.SelectedItem as Vizsga).KepUtvonal != "")
                    {
                        mentesek -= (LsbAdatok.SelectedItem as Vizsga).KepMentes;
                    }
                    LsbAdatok.Items.RemoveAt(LsbAdatok.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a torlsehez!", "Torles...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    mentesek(folderBrowserDialog1.SelectedPath + '\\');
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
