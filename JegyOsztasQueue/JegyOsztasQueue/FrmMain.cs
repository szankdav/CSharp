using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JegyOsztasQueue
{
    public partial class FrmMain : Form
    {
        Queue<Feladat> feladatok;
        public FrmMain()
        {
            InitializeComponent();
            feladatok = new Queue<Feladat>();
        }

        private void BtnUjFeladat_Click(object sender, EventArgs e)
        {
            FrmFeladat frm = new FrmFeladat();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                feladatok.Enqueue(frm.Feladat);
                ListboxRefresh();
            }
        }

        private void BtnKovetkezoFeladat_Click(object sender, EventArgs e)
        {
            if (GrbFeladat.Tag != null)
            {
                feladatok.Enqueue((Feladat)GrbFeladat.Tag);
                ListboxRefresh();
            }
            TxbCim.Text = string.Empty;
            TxbLeiras.Text = string.Empty;
            DtpHatarido.Value = DateTime.Now;
            if (feladatok.Count > 0)
            {
                Feladat kovetkezo = feladatok.Dequeue();
                ListboxRefresh();
                GrbFeladat.Tag = kovetkezo;
                TxbCim.Text = kovetkezo.Cim;
                TxbLeiras.Text = kovetkezo.Leiras;
                DtpHatarido.Value = kovetkezo.Hatarido;
            }
            else
            {
                MessageBox.Show("A feladat sor ures!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnElvegezve_Click(object sender, EventArgs e)
        {
            TxbCim.Text = string.Empty;
            TxbLeiras.Text= string.Empty;
            DtpHatarido.Value= DateTime.Now;
            GrbFeladat.Tag = null;
        }

        private void ListboxRefresh()
        {
            // A listbox adatszerkezeti elvarasa csak tomb/lista lehet! Barmilyen specialis adatszerkezet megjelenitese DataSource-on keresztul benne nem lehetseges! Csak atalakitas utan!
            LsbAdatok.DataSource = null;
            LsbAdatok.DataSource = feladatok.ToList();
        }
    }
}
