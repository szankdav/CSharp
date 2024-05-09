using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    public partial class FrmMain : Form
    {
        List<ICSVMentes> adatok;
        public FrmMain()
        {
            InitializeComponent();
            adatok = new List<ICSVMentes>();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos ki szeretne lepni?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else 
            {
                try
                {
                    CSVFajl.CSVMentes(adatok, "cegek.csv");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLetrehozasC_Click(object sender, EventArgs e)
        {
            FrmCeg frm = new FrmCeg();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                adatok.Add(frm.Ceg);
                ListBoxRefresh();
                LsbCegek.SelectedIndex = LsbCegek.Items.Count - 1;
            }
        }

        private void BtnModositasC_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1)
            {
                FrmCeg frm = new FrmCeg((Ceg)LsbCegek.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ListBoxRefresh();
                }
            }
        }

        private void BtnMegjelenitesC_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1)
            {
                FrmCeg frm = new FrmCeg((Ceg)LsbCegek.SelectedItem);
                frm.ShowDialog();
            }
        }

        private void BtnTorlesC_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1 && MessageBox.Show("Valoban torli a kijelolt elemet?", "Elem torlese...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                adatok.RemoveAt(LsbCegek.SelectedIndex);
                ListBoxRefresh();
            }
            else
            {
                MessageBox.Show("Nincs kijelolve elem a torleshez!", "Elem torlese...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLetrehozasSz_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1)
            {
                FrmSzolgaltatas frm = new FrmSzolgaltatas();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    (LsbCegek.SelectedItem as Ceg).SzolgaltatasHozzaadas(frm.Szolgaltatas);
                    LsbCegek_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void BtnModositasSz_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1 && LsbSzolgaltatasok.SelectedIndex != -1)
            {
                FrmSzolgaltatas frm = new FrmSzolgaltatas((Szolgaltatas)LsbSzolgaltatasok.SelectedItem);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //(LsbCegek.SelectedItem as Ceg).SzolgaltatasModositas((Szolgaltatas)LsbSzolgaltatasok.SelectedItem, LsbSzolgaltatasok.SelectedIndex);
                    LsbCegek_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void BtnMegjelenitesSz_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1 && LsbSzolgaltatasok.SelectedIndex != -1)
            {
                FrmSzolgaltatas frm = new FrmSzolgaltatas((Szolgaltatas)LsbSzolgaltatasok.SelectedItem, true);
                frm.ShowDialog();
            }
        }

        private void BtnTorlesSz_Click(object sender, EventArgs e)
        {
            if (LsbCegek.SelectedIndex != -1 && LsbSzolgaltatasok.SelectedIndex != -1 && MessageBox.Show("Valoban torli a kijelolt elemet?", "Elem torlese...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                (LsbCegek.SelectedItem as Ceg).SzolgaltatasTorles(LsbSzolgaltatasok.SelectedIndex);
                LsbCegek_SelectedIndexChanged(sender, e);
            }
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxRefresh()
        {
            LsbCegek.DataSource = null;
            LsbCegek.DataSource = adatok;
        }

        private void LsbCegek_SelectedIndexChanged(object sender, EventArgs e)
        {
            LsbSzolgaltatasok.DataSource = null;
            if (LsbCegek.SelectedIndex != -1)
            {
                LsbSzolgaltatasok.DataSource = (LsbCegek.SelectedItem as Ceg).SzolgaltatasLista;
            }
        }
    }
}
