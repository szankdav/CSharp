using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCRaktarKezelo
{
    public partial class FrmTermek : Form
    {
        AltalanosTermek termek;
        internal AltalanosTermek Termek { get => termek; /*set => termek = value;*/ }
        const string Title = "Termek kezelese - ";
        public FrmTermek()
        {
            InitializeComponent();
            CmbValasztas.DataSource = Enum.GetValues(typeof(TermekTipus));
            CmbTejtermekTipus.DataSource = Enum.GetValues(typeof(TejtermekTipus));
            CmbZoldsegVagyGyumolcs.DataSource = Enum.GetValues(typeof(ZoldsegGyumolcs));
            this.Text = $"{Title}Uj termek felvitele";
            CmbValasztas.SelectedIndex = (int)TermekTipus.Altalanos_termek;
            //CmbValasztas_SelectedIndexChanged(null, null); ????????????????????
        }

        internal FrmTermek(AltalanosTermek termek, bool megjelenites = false) : this()
        {
            this.termek = termek;
            this.Text = $"{Title}Meglevo termek modositasa";
            TxbMegnevezes.Text = termek.Megnevezes;
            TxbCikkszam.Text = termek.CikkSzam;
            NudAr.Value = termek.Ar;
            NudDarabszam.Value = termek.DarabSzam;

            //if (termek is Tejtermek)
            //{
            //    CmbValasztas.SelectedIndex = (int)TermekTipus.Tejtermek;
            //    NudZsirtartalom.Value = (decimal)(termek as Tejtermek).Zsirtartalom;
            //    CmbTejtermekTipus.SelectedItem = (termek as Tejtermek).Tipus;
            //}

            if (termek is Tejtermek tej)
            {
                CmbValasztas.SelectedIndex = (int)TermekTipus.Tejtermek;
                NudZsirtartalom.Value = (decimal)tej.Zsirtartalom;
                CmbTejtermekTipus.SelectedItem = tej.Tipus;
            }
            else if (termek is Pekaru pekaru)
            {
                CmbValasztas.SelectedIndex = (int)TermekTipus.Pekaru;
                ChbTeljesKiorlesu.Checked = pekaru.TeljesKiorlesu;
            }
            else if (termek is ZoldsegVagyGyumolcs zoldsegvagygyumolcs)
            {
                CmbValasztas.SelectedIndex = (int)TermekTipus.Zoldseg_Vagy_Gyumolcs;
                CmbZoldsegVagyGyumolcs.SelectedItem = zoldsegvagygyumolcs.Tipus;
            }
            CmbValasztas.Enabled = false;
            if (megjelenites)
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = false;
                }
                BtnMegsem.Enabled = true;
                this.ActiveControl = BtnMegsem;
                this.Text = $"{Title}Meglevo termek megjelenitese";
            }
        }

        private void CmbValasztas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Amikor valtoztatom a combobox erteket, akkor csak a megfelelo groupbox legyen engedelyezve. A tobbit vagy letiltom (enabled), vagy eltuntetem (visible).
            //switch ((TermekTipus)CmbValasztas.SelectedItem)
            //{
            //    case TermekTipus.Altalanos_termek:
            //        foreach (Control item in this.Controls)
            //        {
            //            if (item is GroupBox grb && grb.Name == "GrbAltalanosTermek")
            //            {
            //                item.Enabled = true;
            //            }
            //            else if (item is GroupBox)
            //            {
            //                item.Enabled = false;
            //            }
            //        }
            //        break;
            //    case TermekTipus.Tejtermek:
            //        foreach (Control item in this.Controls)
            //        {
            //            if (item is GroupBox grb && (grb.Name == "GrbAltalanosTermek" || grb.Name == "GrbTejtermek"))
            //            {
            //                item.Enabled = true;
            //            }
            //            else if(item is GroupBox)
            //            {
            //                item.Enabled = false;
            //            }
            //        }
            //        break;
            //    case TermekTipus.Pekaru:
            //        foreach (Control item in this.Controls)
            //        {
            //            if (item is GroupBox grb && (grb.Name == "GrbAltalanosTermek" || grb.Name == "GrbPekaru"))
            //            {
            //                item.Enabled = true;
            //            }
            //            else if (item is GroupBox)
            //            {
            //                item.Enabled = false;
            //            }
            //        }
            //        break;
            //    case TermekTipus.Zoldseg_Vagy_Gyumolcs:
            //        foreach (Control item in this.Controls)
            //        {
            //            if (item is GroupBox grb && (grb.Name == "GrbAltalanosTermek" || grb.Name == "GrbZoldsegVagyGyumolcs"))
            //            {
            //                item.Enabled = true;
            //            }
            //            else if (item is GroupBox)
            //            {
            //                item.Enabled = false;
            //            }
            //        }
            //        break;
            //}
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox grb)
                {
                    //if (int.Parse(grb.Tag.ToString()) == CmbValasztas.SelectedIndex || grb.Name == "GrbAltalanosTermek") ?????????????????????
                    //{
                    //    grb.Enabled = true;
                    //}
                    //else
                    //{
                    //    grb.Enabled = false;
                    //}

                    if (int.Parse(grb.Tag.ToString()) == 0)
                    {
                        grb.Enabled = true;
                    }
                    else if (int.Parse(grb.Tag.ToString()) == CmbValasztas.SelectedIndex)
                    {
                        grb.Enabled = true;
                    }
                    else
                    {
                        grb.Enabled = false;
                    }

                    //if (int.Parse(grb.Tag.ToString()) == 0)
                    //{
                    //    grb.Visible = true;
                    //}
                    //else if (int.Parse(grb.Tag.ToString()) == CmbValasztas.SelectedIndex)
                    //{
                    //    grb.Visible = true;
                    //}
                    //else
                    //{
                    //    grb.Visible = false;
                    //}
                }
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (this.termek == null)
            {
                try
                {
                    switch ((TermekTipus)CmbValasztas.SelectedItem)
                    {
                        case TermekTipus.Altalanos_termek:
                            termek = new AltalanosTermek(TxbMegnevezes.Text.Trim(), TxbCikkszam.Text.Trim(), (int)NudAr.Value, (int)NudDarabszam.Value);
                            break;
                        case TermekTipus.Tejtermek:
                            termek = new Tejtermek(TxbMegnevezes.Text.Trim(), TxbCikkszam.Text.Trim(), (int)NudAr.Value, (int)NudDarabszam.Value, (float)NudZsirtartalom.Value, (TejtermekTipus)CmbTejtermekTipus.SelectedIndex);
                            break;
                        case TermekTipus.Pekaru:
                            termek = new Pekaru(TxbMegnevezes.Text.Trim(), TxbCikkszam.Text.Trim(), (int)NudAr.Value, (int)NudDarabszam.Value, ChbTeljesKiorlesu.Checked);
                            break;
                        case TermekTipus.Zoldseg_Vagy_Gyumolcs:
                            termek = new ZoldsegVagyGyumolcs(TxbMegnevezes.Text.Trim(), TxbCikkszam.Text.Trim(), (int)NudAr.Value, (int)NudDarabszam.Value, (ZoldsegGyumolcs)CmbZoldsegVagyGyumolcs.SelectedIndex);
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
                    switch ((TermekTipus)CmbValasztas.SelectedItem)
                    {
                        case TermekTipus.Altalanos_termek:
                            termek.Megnevezes = TxbMegnevezes.Text.Trim();
                            termek.CikkSzam = TxbCikkszam.Text.Trim();
                            termek.Ar = (int)NudAr.Value;
                            termek.DarabSzam = (int)NudDarabszam.Value;
                            break;
                        case TermekTipus.Tejtermek:
                            termek.Megnevezes = TxbMegnevezes.Text.Trim();
                            termek.CikkSzam = TxbCikkszam.Text.Trim();
                            termek.Ar = (int)NudAr.Value;
                            termek.DarabSzam = (int)NudDarabszam.Value;
                            (termek as Tejtermek).Zsirtartalom = (int)NudZsirtartalom.Value;
                            (termek as Tejtermek).Tipus = (TejtermekTipus)CmbTejtermekTipus.SelectedIndex;
                            break;
                        case TermekTipus.Pekaru:
                            termek.Megnevezes = TxbMegnevezes.Text.Trim();
                            termek.CikkSzam = TxbCikkszam.Text.Trim();
                            termek.Ar = (int)NudAr.Value;
                            termek.DarabSzam = (int)NudDarabszam.Value;
                            (termek as Pekaru).TeljesKiorlesu = ChbTeljesKiorlesu.Checked;
                            break;
                        case TermekTipus.Zoldseg_Vagy_Gyumolcs:
                            termek.Megnevezes = TxbMegnevezes.Text.Trim();
                            termek.CikkSzam = TxbCikkszam.Text.Trim();
                            termek.Ar = (int)NudAr.Value;
                            termek.DarabSzam = (int)NudDarabszam.Value;
                            (termek as ZoldsegVagyGyumolcs).Tipus = (ZoldsegGyumolcs)CmbZoldsegVagyGyumolcs.SelectedIndex;
                            break;
                        default:
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
