using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeladatListaDinamikus
{
    public partial class FrmMain : Form
    {
        int grbTop;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CmbFeladatPrioritasa.DataSource = Enum.GetValues(typeof(FeladatPrioritas));
            grbTop = BtnFeladatLetrehozasa.Bottom + 6;
            // ***** TESZTELÉSHEZ *****
            //// 1. Létrehozunk egy új Feladat osztálypéldányt.
            //Feladat f = new Feladat("Ez a cím", "Ez a leírás", DateTime.Now, FeladatPrioritas.Alacsony);
            //// 2. Létre kell hozni a Feladat osztály segítségével egy groupboxot, benne az összes elemmel.
            //GroupBox grb = Feladat.FealadatKomponens(f, GrbUjFeladat.Width, GrbUjFeladat.Height);
            //// 3. Meg kell adni a Parent tulajdonságot.
            //grb.Parent = this;
            //grb.Top = grbTop;
            //grb.Left = GrbUjFeladat.Left;
            // **********

            if (File.Exists("feladatok.csv"))
            {
                try
                {
                    StreamReader reader = new StreamReader("feladatok.csv");
                    while (!reader.EndOfStream)
                    {
                        Feladat f = new Feladat(reader.ReadLine());
                        GroupBox grb = Feladat.FealadatKomponens(f, GrbUjFeladat.Width, GrbUjFeladat.Height);
                        grb.Left = GrbUjFeladat.Left;
                        grb.Top = grbTop;
                        grb.Parent = this;
                        grbTop += grb.Height + 6;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnFeladatLetrehozasa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Létrehozzuk az osztály példányt.
                Feladat f = new Feladat(TxbFeladatCime.Text.Trim(), TxbFeladatLeirasa.Text.Trim(), DtpFeladatDatuma.Value, (FeladatPrioritas)CmbFeladatPrioritasa.SelectedItem);
                // 2. Sikeres példányosítás esetén az eredeti mezők alapheléyzetbe állítása
                TxbFeladatCime.Clear();
                TxbFeladatLeirasa.Clear();
                DtpFeladatDatuma.Value = DateTime.Now;
                CmbFeladatPrioritasa.SelectedIndex = 0;
                // 3. Az új GroupBox-ot létrehozzuk és pozicionáljuk.
                GroupBox grb = Feladat.FealadatKomponens(f, GrbUjFeladat.Width, GrbUjFeladat.Height);
                grb.Left = GrbUjFeladat.Left;
                grb.Top = grbTop;
                grb.Parent = this;
                grbTop += grb.Height + 6;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("feladatok.csv");
                foreach (Control item in this.Controls)
                {
                    if (item is GroupBox grb && grb.Name == "Feladat")
                    {
                        writer.WriteLine((grb.Tag as Feladat).CSVFormatum());
                    }
                }
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
