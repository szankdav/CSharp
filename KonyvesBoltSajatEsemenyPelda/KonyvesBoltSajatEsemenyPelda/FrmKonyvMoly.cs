using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBoltSajatEsemenyPelda
{
    public partial class FrmKonyvMoly : Form
    {
        KonyvMoly moly;
        internal KonyvMoly Moly { get => moly; /*set => moly = value;*/ }
        public FrmKonyvMoly()
        {
            InitializeComponent();
            NudVagyon.Maximum = int.MaxValue;
            CmbKedvencTipus.DataSource = Enum.GetValues(typeof(KonyvTipus));
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                moly = new KonyvMoly(TxbNev.Text.Trim(), (int)NudVagyon.Value, (KonyvTipus)CmbKedvencTipus.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
