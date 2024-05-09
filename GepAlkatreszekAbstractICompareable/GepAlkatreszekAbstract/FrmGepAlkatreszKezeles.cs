using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepAlkatreszekAbstract
{
    public partial class FrmGepAlkatreszKezeles : Form
    {
        GepAlkatresz alkatresz;
        GepAlkatresz masikAlkatresz;
        internal GepAlkatresz Alkatresz { get => alkatresz; /*set => alkatresz = value;*/ }

        public FrmGepAlkatreszKezeles()
        {
            InitializeComponent();
            CmbMemoria.DataSource = Enum.GetValues(typeof(MemoriaTipus));
            CmbTipus.DataSource = Enum.GetValues(typeof(MemoriaTipus));
        }

        internal FrmGepAlkatreszKezeles(GepAlkatresz alkatresz, bool megjelenites = false) : this()
        {
            this.alkatresz = alkatresz;
            this.masikAlkatresz = alkatresz;
            // Gepalkatresz altalanos adatai
            TxbMegnevezes.Text = alkatresz.Megnevezes;
            TxbSzeriaSzam.Text = alkatresz.SzeriaSzam;
            TxbSzeriaSzam.ReadOnly = true;
            NudAr.Value = alkatresz.Ar;
            NudSzelesseg.Value = alkatresz.Meret.Szelesseg;
            NudMagassag.Value = alkatresz.Meret.Magassag;

            if (alkatresz is Alaplap alaplap)
            {
                TbcReszletek.SelectedIndex = 0;
                TxbChipset.Text = alaplap.Chipset;
                CmbMemoria.SelectedItem = alaplap.TamogatottMemoria;
                TbcReszletek.TabPages[1].Enabled = false;
                TbcReszletek.TabPages[2].Enabled = false;
            }
            else if (alkatresz is Memoria memoria)
            {
                TbcReszletek.SelectedIndex = 1;
                CmbTipus.SelectedItem = memoria.Tipus;
                TxbArchitektura.Text = memoria.Architektura;
                NudFrekvencia.Value = (decimal)memoria.Frekvencia;
                TbcReszletek.TabPages[0].Enabled = false;
                TbcReszletek.TabPages[2].Enabled = false;
            }
            else if (alkatresz is Processzor processzor)
            {
                TbcReszletek.SelectedIndex = 2;
                TxbTokozas.Text = processzor.Tokozas;
                NudFrekvencia2.Value = (decimal)processzor.Frekvencia;
                NudKesleltetes.Value = processzor.Kesleltetes;
                TbcReszletek.TabPages[0].Enabled = false;
                TbcReszletek.TabPages[1].Enabled = false;
            }

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
            if (alkatresz == null)
            {
                try
                {
                    switch (TbcReszletek.SelectedIndex)
                    {
                        case 0:
                            alkatresz = new Alaplap(TxbMegnevezes.Text.Trim(), TxbSzeriaSzam.Text.Trim(), (int)NudAr.Value, new Meret((int)NudSzelesseg.Value, (int)NudMagassag.Value), TxbChipset.Text.Trim(), (MemoriaTipus)CmbMemoria.SelectedItem);
                            break;
                        case 1:
                            alkatresz = new Memoria(TxbMegnevezes.Text.Trim(), TxbSzeriaSzam.Text.Trim(), (int)NudAr.Value, new Meret((int)NudSzelesseg.Value, (int)NudMagassag.Value), (MemoriaTipus)CmbTipus.SelectedItem, TxbArchitektura.Text.Trim(), (float)NudFrekvencia.Value);
                            break;
                        case 2:
                            alkatresz = new Processzor(TxbMegnevezes.Text.Trim(), TxbSzeriaSzam.Text.Trim(), (int)NudAr.Value, new Meret((int)NudSzelesseg.Value, (int)NudMagassag.Value), (float)NudFrekvencia2.Value, (byte)NudKesleltetes.Value, TxbTokozas.Text.Trim());
                            break;
                    }

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
                    alkatresz.Megnevezes = TxbMegnevezes.Text.Trim();
                    //private setter miatt modositas nem lehetseges!
                    //alkatresz.SzeriaSzam = TxbSzeriaSzam.Text.Trim();
                    alkatresz.Ar = (int)NudAr.Value;
                    alkatresz.Meret.Szelesseg = (int)NudSzelesseg.Value;
                    alkatresz.Meret.Magassag = (int)NudMagassag.Value;

                    switch (TbcReszletek.SelectedIndex)
                    {
                        case 0:
                            (alkatresz as Alaplap).Chipset = TxbChipset.Text.Trim();
                            (alkatresz as Alaplap).TamogatottMemoria = (MemoriaTipus)CmbMemoria.SelectedItem;
                            break;
                        case 1:
                            (alkatresz as Memoria).Tipus = (MemoriaTipus)CmbTipus.SelectedItem;
                            (alkatresz as Memoria).Architektura = TxbArchitektura.Text.Trim();
                            (alkatresz as Memoria).Frekvencia = (float)NudFrekvencia.Value;
                            break;
                        case 2:
                            (alkatresz as Processzor).Tokozas = TxbTokozas.Text.Trim();
                            (alkatresz as Processzor).Frekvencia = (float)NudFrekvencia2.Value;
                            (alkatresz as Processzor).Kesleltetes = (byte)NudKesleltetes.Value;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }

            if (alkatresz != null && masikAlkatresz != null)
            {
                if (alkatresz.CompareTo(masikAlkatresz) == 0)
                {
                    MessageBox.Show("Ilyen nevvel mar szerepel alkatresz a listaban!", "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }
    }
}
