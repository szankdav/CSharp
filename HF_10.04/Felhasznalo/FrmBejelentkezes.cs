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
using Gepjarmuvek;

namespace Felhasznalo
{
    public partial class FrmBejelentkezes : Form
    {
        List<Gepjarmuvek.Felhasznalo> felhasznaloLista;
        Gepjarmuvek.Felhasznalo bejelentkezettFelhasznalo;
        public List<Gepjarmuvek.Felhasznalo> FelhasznaloLista { get => felhasznaloLista; set => felhasznaloLista = value; }
        public Gepjarmuvek.Felhasznalo BejelentkezettFelhasznalo { get => bejelentkezettFelhasznalo; set => bejelentkezettFelhasznalo = value; }

        public FrmBejelentkezes()
        {
            InitializeComponent();
            FelhasznaloLista = new List<Gepjarmuvek.Felhasznalo>();
        }

        private void FrmBejelentkezes_Load(object sender, EventArgs e)
        {
            FileInfo felhasznalokCSV = new FileInfo("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv");
            felhasznalokCSV.Attributes &= ~FileAttributes.Hidden;
            StreamReader felhasznaloReader = new StreamReader("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv");
            if (File.Exists("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv"))
            {
                try
                {
                    while (!felhasznaloReader.EndOfStream)
                    {
                        FelhasznaloLista.Add(Gepjarmuvek.Felhasznalo.felhasznaloCSVBetoltes(felhasznaloReader.ReadLine()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            felhasznaloReader.Close();
            File.SetAttributes("C:\\Users\\TUF Gaming\\source\\repos\\HF_10.04\\Admin\\bin\\Debug\\felhasznalok.csv", FileAttributes.Hidden);
            foreach (Gepjarmuvek.Felhasznalo felhasznalo in felhasznaloLista)
            {
                CmbFelhasznaloFelhasznaloLista.Items.Add(felhasznalo.Nev);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Gepjarmuvek.Felhasznalo kivalasztottFelhasznalo = (felhasznaloLista[CmbFelhasznaloFelhasznaloLista.SelectedIndex]);
            if (kivalasztottFelhasznalo.FelhasznaloJelszo == TxbFelhasznaloBelepesiJelszo.Text.Trim())
            {
                this.DialogResult = DialogResult.OK;
                bejelentkezettFelhasznalo = felhasznaloLista[CmbFelhasznaloFelhasznaloLista.SelectedIndex];
            }
            else
            {
                MessageBox.Show("A jelszó nem megfelelő!", "Hibás jelszó", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult= DialogResult.None;
            }
        }
    }
}
