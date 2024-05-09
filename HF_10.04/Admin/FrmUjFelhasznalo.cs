using Gepjarmuvek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class FrmUjFelhasznalo : Form
    {
        Felhasznalo felhasznalo;
        public Felhasznalo Felhasznalo { get => felhasznalo; /*set => felhasznalo = value;*/ }
        public FrmUjFelhasznalo()
        {
            InitializeComponent();
        }

        public FrmUjFelhasznalo(Felhasznalo felhasznalo, bool megjelenites = false) : this()
        {
            this.felhasznalo = felhasznalo;
            TxbAdminUjFelhasznalonev.Text = felhasznalo.Nev;
            TxbAdminUjFelhasznaloJelszo.Text = felhasznalo.FelhasznaloJelszo;

            if (megjelenites)
            {
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
                BtnMegsem.Enabled = true;
                this.ActiveControl = BtnMegsem;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (felhasznalo == null)
            {
                try
                {
                    felhasznalo = new Felhasznalo(TxbAdminUjFelhasznalonev.Text.Trim(), TxbAdminUjFelhasznaloJelszo.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    felhasznalo.Nev = TxbAdminUjFelhasznalonev.Text.Trim();
                    felhasznalo.FelhasznaloJelszo = TxbAdminUjFelhasznaloJelszo.Text.Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
        }
    }
}
