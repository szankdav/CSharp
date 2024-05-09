using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JegyOsztasQueue
{
    public partial class FrmFeladat : Form
    {
        Feladat feladat;
        internal Feladat Feladat { get => feladat; /*set => feladat = value;*/ }
        public FrmFeladat()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                feladat = new Feladat(TxbCim.Text.Trim(), TxbLeiras.Text, DtpHatarido.Value.Date);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
