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
        List<GepAlkatresz> alkatreszListaMasolat;
        internal GepAlkatresz Alkatresz { get => alkatresz; /*set => alkatresz = value;*/ }

        public FrmGepAlkatreszKezeles()
        {
            InitializeComponent();
            CmbMemoria.DataSource = Enum.GetValues(typeof(MemoriaTipus));
            CmbTipus.DataSource = Enum.GetValues(typeof(MemoriaTipus));
            alkatreszListaMasolat = new List<GepAlkatresz>();
        }

        internal FrmGepAlkatreszKezeles(List<GepAlkatresz> alkatreszLista) : this()
        {
            foreach (GepAlkatresz item in alkatreszLista)
            {
                alkatreszListaMasolat.Add(item);
            }
        }

        internal FrmGepAlkatreszKezeles(GepAlkatresz alkatresz, List<GepAlkatresz> alkatreszLista, bool megjelenites = false) : this() // Mi az elegans modja, hogy itt is lefusson az alkatreszLista masolasa?
        {
            foreach (GepAlkatresz item in alkatreszLista)
            {
                alkatreszListaMasolat.Add(item);
            }

            this.alkatresz = alkatresz;
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
                    if (alkatreszListaMasolat.Count > 0)
                    {

                        if (NevIsmetlodesEllenorzes() == false)
                        {
                            MessageBox.Show("Ilyen nevvel mar szerepel alkatresz a listaban! Kerem, mas nevet adjon meg!", "Nev utkozes...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.None;
                        }
                        else
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

                    }
                    else
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
                    if (NevIsmetlodesEllenorzes() == false)
                    {
                        MessageBox.Show("Ilyen nevvel mar szerepel alkatresz a listaban! Kerem, mas nevet adjon meg!", "Nev utkozes...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.None;
                    }
                    else
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DialogResult = DialogResult.None;
                }
            }
        }

        private bool NevIsmetlodesEllenorzes()
        {
            bool megfelelo = true;
            foreach (GepAlkatresz item in alkatreszListaMasolat)
            {
                if (item.Megnevezes == TxbMegnevezes.Text.Trim())
                {
                    megfelelo = false;
                    break;
                }
            }
            return megfelelo;
        }
    }
}
