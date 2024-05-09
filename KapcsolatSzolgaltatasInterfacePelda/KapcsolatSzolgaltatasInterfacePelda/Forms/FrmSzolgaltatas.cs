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
    public partial class FrmSzolgaltatas : Form
    {
        Szolgaltatas szolgaltatas;
        internal Szolgaltatas Szolgaltatas { get => szolgaltatas; /*set => szolgaltatas = value;*/ }
        public FrmSzolgaltatas()
        {
            InitializeComponent();
            NudSzolgaltatasAra.Maximum = int.MaxValue;
        }

        internal FrmSzolgaltatas(Szolgaltatas szolgaltatas, bool megjelenites = false)
        {
            this.szolgaltatas = szolgaltatas;
            TxbSzolgaltatasNev.Text = szolgaltatas.Megnevezes;
            NudSzolgaltatasAra.Value = szolgaltatas.Ar;

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
            if (szolgaltatas == null)
            {
                try
                {
                    szolgaltatas = new Szolgaltatas(TxbSzolgaltatasNev.Text.Trim(), (int)NudSzolgaltatasAra.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                try
                {
                    szolgaltatas.Megnevezes = TxbSzolgaltatasNev.Text.Trim();
                    szolgaltatas.Ar = (int)NudSzolgaltatasAra.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
