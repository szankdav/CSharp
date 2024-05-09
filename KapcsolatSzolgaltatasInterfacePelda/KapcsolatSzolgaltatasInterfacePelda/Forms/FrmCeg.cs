using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapcsolatSzolgaltatasInterfacePelda
{
    public partial class FrmCeg : Form
    {
        Ceg ceg;
        internal Ceg Ceg { get => ceg; /*set => ceg = value;*/ }
        public FrmCeg()
        {
            InitializeComponent();
            //CmbTelefonSzamTipus.DataSource = Enum.GetValues(typeof(TelefonTipus));
            CmbTelefonSzamTipus.DataSource = Enum.GetValues(typeof(TelefonTipus)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            CmbTelefonSzamTipus.DisplayMember = "Description";
            CmbTelefonSzamTipus.ValueMember = "value";
        }

        internal FrmCeg(Ceg ceg, bool megjelenites = false) : this()
        {
            this.ceg = ceg;
            TxbCegNev.Text = ceg.CegNev;
            NudIranyitoSzam.Value = ceg.CegCim.IranyitoSzam;
            TxbHelyseg.Text = ceg.CegCim.Helyseg;
            TxbUtca.Text = ceg.CegCim.Utca;
            NudHazSzam.Value = ceg.CegCim.HazSzam;
            TxbEmail.Text = ceg.Email;
            MtbTelefonSzam.Text = ceg.Telefon;
            CmbTelefonSzamTipus.SelectedItem = ceg.Tipus;
            CmbTelefonSzamTipus.Enabled = false;

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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ceg == null)
            {
                try
                {
                    ceg = new Ceg(TxbCegNev.Text.Trim(), new Cim((short)NudIranyitoSzam.Value, TxbHelyseg.Text.Trim(), TxbUtca.Text.Trim(), (short)NudHazSzam.Value), TxbEmail.Text.Trim(), MtbTelefonSzam.Text.Trim(), (TelefonTipus)CmbTelefonSzamTipus.SelectedValue);
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
                    ceg.CegNev = TxbCegNev.Text.Trim();
                    ceg.CegCim.IranyitoSzam = (short)NudIranyitoSzam.Value;
                    ceg.CegCim.Helyseg = TxbHelyseg.Text.Trim();
                    ceg.CegCim.Utca = TxbUtca.Text.Trim();
                    ceg.CegCim.HazSzam = (short)NudHazSzam.Value;
                    ceg.Email = TxbEmail.Text.Trim();
                    ceg.Telefon = MtbTelefonSzam.Text.Trim();
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
