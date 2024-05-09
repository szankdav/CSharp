using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizsgaMgr
{
    public partial class FrmFeladat : Form
    {

        Feladat feladat;
        internal Feladat Feladat { get => feladat; /*set => feladat = value;*/ }

        // Új létrehozás
        public FrmFeladat(byte maxPont)
        {
            InitializeComponent();
            NudFeladatPontszama.Maximum = maxPont;
        }

        // Módosítás vagy megjelenítés
        internal FrmFeladat(byte maxPont, Feladat feladat, bool megjelenites = false)
        {
            InitializeComponent();
            // Pl. a vizsga 100 pont - ebből elhasználtunk 90 pontot.
            // maxPont = 10 - Ennyi van még hátra
            // feladat.PontSzam = 15 - ezt is bele kell kalkulálni a jelenlegi módosítás intervallumába
            NudFeladatPontszama.Maximum = maxPont + feladat.PontSzam;
            TxbFeladatLeirasa.Text = feladat.Leiras;
            NudFeladatPontszama.Value = feladat.PontSzam;
            this.feladat = feladat;
            if (megjelenites)
            {
                foreach (Control item in GrbFeladat.Controls)
                {
                    if (!(item is Label))
                    {
                        if (item is TextBox)
                        {
                            (item as TextBox).ReadOnly = true;
                        }
                        else
                        {
                            item.Enabled = false;
                        }
                    }
                }
                BtnOK.Enabled = false;
                this.ActiveControl = BtnMegsem;
            }

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.feladat == null)
                {
                    // Új létrehozás
                    this.feladat = new Feladat(TxbFeladatLeirasa.Text.Trim(), byte.Parse(NudFeladatPontszama.Value.ToString()));
                }
                else
                {
                    // Módosítás
                    this.feladat.Leiras = TxbFeladatLeirasa.Text.Trim();
                    this.feladat.PontSzam = byte.Parse(NudFeladatPontszama.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void TxbFeladatLeirasa_TextChanged(object sender, EventArgs e)
        {
            LblHatralevoKarakterekSzama.Text = $"Hatralevo karakterek szama: {TxbFeladatLeirasa.MaxLength - TxbFeladatLeirasa.Text.Length}";
        }
    }
}
