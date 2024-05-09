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

namespace MemóriaJáték
{
    enum JatekTipus
    {
        [Description("Számos memóriajáték")]
        Szam,
        [Description("Színes memóriajáték")]
        Szin
    }
    public partial class FrmIndulasiKepernyo : Form
    {
        public FrmIndulasiKepernyo()
        {
            InitializeComponent();
        }

        private void FrmIndulasiKepernyo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki szeretne lépni ebből a csodálatos játékból?", "Kilépés...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void BtnUjJatek_Click(object sender, EventArgs e)
        {
            FrmJatekTipusValasztas frm = new FrmJatekTipusValasztas();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.JatekTipus == 1)
                {
                    FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
                    this.Hide();
                    frmJatekMezo.ShowDialog();
                }
                else
                {
                    FrmJatekMezo frmJatekMezo = new FrmJatekMezo(frm.JatekTipus);
                    this.Hide();
                    frmJatekMezo.ShowDialog();
                }
                
                this.Show();
            }
        }

        private void BtnEredmenyek_Click(object sender, EventArgs e)
        {
            if (File.Exists("eredmenyek.txt"))
            {
                FrmEredmenyek frm = new FrmEredmenyek();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs megjeleníthető eredmény!", "Információ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
