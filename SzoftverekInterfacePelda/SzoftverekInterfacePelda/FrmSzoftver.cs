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
    public partial class FrmSzoftver : Form
    {
        Szoftver szoftver;
        internal Szoftver Szoftver { get => szoftver; /*set => szoftver = value;*/ }
        public FrmSzoftver()
        {
            InitializeComponent();
            CmbTipus.DataSource = Enum.GetValues(typeof(Szoftvertipus));
            NudAr.Maximum = int.MaxValue;
        }

        internal FrmSzoftver(Szoftver szoftver, bool megjelenites = false) : this()
        {
            this.szoftver = szoftver;
            TxbGyarto.Text = szoftver.Gyarto;
            TxbMegnevezes.Text = szoftver.Megnevezes;
            NudAr.Value = szoftver.Ar;
            CmbTipus.SelectedItem = szoftver.Tipus;
            CmbTipus.Enabled = false;

            if (megjelenites)
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
                BtnMegsem.Enabled = true;
                this.ActiveControl = BtnMegsem;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (szoftver == null)
            {
                try
                {
                    szoftver = new Szoftver(TxbGyarto.Text.Trim(), TxbMegnevezes.Text.Trim(), (int)NudAr.Value, (Szoftvertipus)CmbTipus.SelectedItem);
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
                    szoftver.Gyarto = TxbGyarto.Text.Trim();
                    szoftver.Megnevezes = TxbMegnevezes.Text.Trim();
                    szoftver.Ar = (int)NudAr.Value;
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
