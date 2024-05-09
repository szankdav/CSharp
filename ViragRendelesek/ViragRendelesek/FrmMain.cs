using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ViragRendelesek
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CmbViragTipus.DataSource = Enum.GetValues(typeof(ViragTipus));
        }

        private void BtnViragFelvitele_Click(object sender, EventArgs e)
        {
            if (LsbViragok.Items.Count < 10)
            {
                try
                {
                    //Virag temp = new Virag(TxbViragNeve.Text.Trim(), (uint)NudViragAra.Value, (byte)NudViragDarabszama.Value, (ViragTipus)CmbViragTipus.SelectedIndex);
                    //LsbViragok.Items.Add(temp);
                    LsbViragok.Items.Add(new Virag(TxbViragNeve.Text.Trim(), (uint)NudViragAra.Value, (byte)NudViragDarabszama.Value, (ViragTipus)CmbViragTipus.SelectedIndex));
                    TxbViragNeve.Text = String.Empty;
                    NudViragAra.Value = NudViragAra.Minimum;
                    NudViragDarabszama.Value = NudViragAra.Minimum;
                    CmbViragTipus.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Felvitel nem lehetseges! Kerem, adja le a rendelest!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRendelesLeadasa_Click(object sender, EventArgs e)
        {
            if (LsbViragok.Items.Count > 0)
            {
                Virag[] viragok = new Virag[LsbViragok.Items.Count];
                int i = 0;
                foreach (Virag item in LsbViragok.Items)
                {
                    viragok[i] = item;
                    i++;
                }

                //for (int j = 0; j < LsbViragok.Items.Count; j++)
                //{
                //    viragok[j] = (Virag)LsbViragok.Items[j];
                //}
                string megnevezes = string.Empty;
                do
                {
                    megnevezes = Interaction.InputBox("Kerem, adja meg a megrendeles megnevezeset!", "Megrendeles megnevezese", "Megrendeles");
                } while (megnevezes.Trim().Length < 5 || megnevezes.Trim().Length > 30);
                try
                {
                    Rendeles temp = new Rendeles(megnevezes, viragok);
                    LsbRendelesek.Items.Add(temp);
                    LsbViragok.Items.Clear();
                    Rendeles[] rendelesek = new Rendeles[LsbRendelesek.Items.Count];
                    i = 0;
                    foreach (Rendeles item in LsbRendelesek.Items)
                    {
                        rendelesek[i] = item;
                        i++;
                    }
                    label2.Text = $"A rendelesek osszerteke: {Rendeles.OsszesRendelesAra(rendelesek)} Ft.-";
                    //label2.Text = $"A rendelesek osszerteke: {temp.OsszesRendelesAra(rendelesek)}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rendeles leada nem lehetseges! Nincs adat!", "Figyelmeztetes...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LsbViragok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbViragok.Items.Count != 0 && LsbViragok.SelectedIndex != -1)
            {
                label1.Text = (LsbViragok.SelectedItem as Virag).Nev;
            }
        }
    }
}
