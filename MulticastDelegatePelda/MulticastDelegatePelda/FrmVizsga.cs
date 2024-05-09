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
    public partial class FrmVizsga : Form
    {
        Vizsga vizsga;
        internal Vizsga Vizsga { get => vizsga; /*set => vizsga = value;*/ }
        public FrmVizsga()
        {
            InitializeComponent();
        }

        private void BtnTallozas_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxbKep.Text = openFileDialog1.FileName;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                vizsga = new Vizsga(TxbCim.Text.Trim(), TxbFeladat.Text.Trim(), TxbKep.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
