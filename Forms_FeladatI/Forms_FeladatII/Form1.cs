using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FeladatII
{
    public partial class Szamkitalalo : Form
    {
        private int computerSzam;
        public Szamkitalalo()
        {
            InitializeComponent();
        }

        private void BtnKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki akar lepni ebbol a nagyszeru alkalmazasbol?", "Kilepes...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnTipp.Enabled = false;
            TxtbTipp.Enabled = false;
            BtnUjJatek.Enabled = true;
        }

        private void BtnUjJatek_Click(object sender, EventArgs e)
        {
            BtnTipp.Enabled = true;
            TxtbTipp.Enabled = true;
            BtnUjJatek.Enabled = false;
            Random randomNumber = new Random();
            computerSzam = randomNumber.Next(1, 102) - 1;
            // Ha 0-tol randomizalunk, akkor inkabb igy csinaljuk, mert a 0 statisztikailag tobbszor generalodik mint mas szamok.
            LblInformacio.Text = "Gondoltam egy szamra 0 es 100 kozott!";
            TxtbTipp.Text = string.Empty;
            LBTippek.Items.Clear();
            TxtbTipp.Focus();
        }

        private void BtnTipp_Click(object sender, EventArgs e)
        {
            int felhasznaloTipp = 0;
            if (int.TryParse(TxtbTipp.Text.Trim(), out felhasznaloTipp))
            {
                if (felhasznaloTipp < computerSzam)
                {
                    LblInformacio.Text = "Ennel nagyobb szamra gondoltam!";
                }
                else if (felhasznaloTipp > computerSzam)
                {
                    LblInformacio.Text = "Ennel kisebb szamra gondoltam!";
                }
                else
                {
                    LblInformacio.Text = "On nyert!";
                    BtnTipp.Enabled = false;
                    TxtbTipp.Text = string.Empty;
                    TxtbTipp.Enabled = false;
                    BtnUjJatek.Enabled = true;
                }
                LBTippek.Items.Add($"{felhasznaloTipp} - {LblInformacio.Text}");
                TxtbTipp.Text = string.Empty;
                TxtbTipp.Focus();
            }
            else
            {
                MessageBox.Show("Hibas adat!", "HIBA...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtbTipp.Text = string.Empty;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnTipp_Click(this, new EventArgs());
            }
        }
    }
}
