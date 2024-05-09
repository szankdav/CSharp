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
    public partial class FrmVizsga : Form
    {
        Vizsga vizsga;
        internal Vizsga Vizsga { get => vizsga; /*set => vizsga = value;*/ }

        // Új létrehozás
        public FrmVizsga()
        {
            InitializeComponent();
        }

        // Módosítás vagy megjelenítés
        internal FrmVizsga(Vizsga vizsga, bool megjelenites = false) : this() 
        {
            //InitializeComponent(); ==> Ehelyett a konstruktor utáni this() meghívja az alap konstruktort.
            this.vizsga = vizsga;
            TxbVizsgaMegnevezese.Text = vizsga.Megnevezes;
            NudVizsgaOsszpontszama.Value = vizsga.OsszPontszam;
            this.ActiveControl = TxbVizsgaMegnevezese;
            if (megjelenites)
            {
                foreach (Control item in GrbVizsga.Controls)
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
                if (this.vizsga == null)
                {
                    // Új létrehozás
                    this.vizsga = new Vizsga(TxbVizsgaMegnevezese.Text.Trim(), byte.Parse(NudVizsgaOsszpontszama.Value.ToString()));
                }
                else
                {
                    // Módosítás
                    this.vizsga.Megnevezes = TxbVizsgaMegnevezese.Text.Trim();
                    this.vizsga.OsszPontszam = byte.Parse(NudVizsgaOsszpontszama.Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
