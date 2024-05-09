using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermekekSharedDLL;

namespace TermekekAdminDLL
{
    public partial class FrmTermek : Form
    {
        Termek termek;
        public Termek Termek { get => termek; /*set => termek = value;*/ }
        public FrmTermek()
        {
            InitializeComponent();
            NudAr.Maximum = uint.MaxValue;
            NudDarabSzam.Maximum = uint.MaxValue;
            CmbTipus.DataSource = Enum.GetValues(typeof(TermekTipus));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                termek = new Termek(TxbGyarto.Text.Trim(), TxbMegnevezes.Text.Trim(), (uint)NudAr.Value, (uint)NudDarabSzam.Value, (TermekTipus)CmbTipus.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
