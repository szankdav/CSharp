using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gepjarmuvek;

namespace Admin
{
    public partial class FrmUjJarmu : Form
    {
        Gepjarmu jarmu;
        public Gepjarmu Jarmu { get => jarmu; /*set => jarmu = value;*/ }
        public FrmUjJarmu()
        {
            InitializeComponent();
            CmbAdminUjAutoMotorTipus.DataSource = Enum.GetValues(typeof(MotorTipus));
            NudFutottKM.Maximum = uint.MaxValue;
            NudAdminUjMotorKobcentimeter.Maximum = ushort.MaxValue;
        }

        public FrmUjJarmu(Gepjarmu jarmu, bool megjelenites = false) : this()
        {
            this.jarmu = jarmu;
            TxbRendszam.Text = jarmu.Rendszam;
            NudFutottKM.Value = jarmu.FutottKM;

            if (jarmu is Auto auto)
            {
                TbcAdminUjJarmu.SelectedIndex = 0;
                TbcAdminUjJarmu.TabPages[1].Enabled = false;
                CmbAdminUjAutoMotorTipus.SelectedItem = auto.MotorTipus;
            }
            else if (jarmu is Motor motor)
            {
                TbcAdminUjJarmu.SelectedIndex = 1;
                TbcAdminUjJarmu.TabPages[0].Enabled = false;
                NudAdminUjMotorKobcentimeter.Value = motor.MotorTerfogat;
            }

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
            if (this.jarmu == null)
            {
                try
                {
                    switch (TbcAdminUjJarmu.SelectedIndex)
                    {
                        case 0:
                            jarmu = new Auto(TxbRendszam.Text.Trim(), (uint)NudFutottKM.Value, false, (MotorTipus)CmbAdminUjAutoMotorTipus.SelectedIndex);
                            break;
                        case 1:
                            jarmu = new Motor(TxbRendszam.Text.Trim(), (uint)NudFutottKM.Value, false, (ushort)NudAdminUjMotorKobcentimeter.Value);
                            break;
                    }
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
                    jarmu.Rendszam = TxbRendszam.Text.Trim();
                    jarmu.FutottKM = (uint)NudFutottKM.Value;
                    jarmu.KolcsonzesiAllapot = false;

                    switch (TbcAdminUjJarmu.SelectedIndex)
                    {
                        case 0:
                            (jarmu as Auto).MotorTipus = (MotorTipus)CmbAdminUjAutoMotorTipus.SelectedItem;
                            break;
                        case 1:
                            (jarmu as Motor).MotorTerfogat = (ushort)NudAdminUjMotorKobcentimeter.Value;
                            break;
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
}
