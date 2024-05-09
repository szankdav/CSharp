using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBoltSajatEsemenyPelda
{
    public partial class FrmMain : Form
    {
        static Random r;
        KonyvesBolt bolt;

        static FrmMain()
        {
            r = new Random();
        }

        public FrmMain()
        {
            InitializeComponent();
            bolt = new KonyvesBolt();
        }

        private void BtnMolyLetrehozasa_Click(object sender, EventArgs e)
        {
            FrmKonyvMoly frm = new FrmKonyvMoly();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LsbKonyvMolyok.Items.Add(frm.Moly);
                bolt.KonyvErkezett += frm.Moly.UjKonyvErkezettABoltba;
                frm.Moly.KonyvVasarlasEredmenyEsemeny += Moly_KonyvVasarlasEredmeny;
            }
        }

        private void BtnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            //string szoveg = (timer1.Enabled) ? "A Timer engedelyezve." : "A Timer megallitva.";
            //LblTimerStatus.Text = szoveg;
            LblTimerStatus.Text = (timer1.Enabled) ? "A Timer engedelyezve." : "A Timer megallitva.";
        }

        private void Moly_KonyvVasarlasEredmeny(KonyvMoly moly, Konyv konyv, string uzenet)
        {
            LsbEsemenyek.Items.Add($"{moly.Nev} a(z) [{konyv}] konyvet megkapta feldolgozasra. Az eredmeny: {uzenet}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] vezetek = { "Balogh", "Szabo", "Takacs", "Kovacs", "Beres", "Nagy", "Kis" };
            string[] kereszt = { "Jakab", "Ica", "Geza", "Bela", "Gabor", "Melinda", "Tibor" };
            string[] szavak = { "Kaland", "Gyuru", "Romok", "Hosok", "Ido", "Torony", "Kiralysag" };

            KonyvTipus[] tipusok = new KonyvTipus[Enum.GetValues(typeof(KonyvTipus)).Length]; // Az osszes indexen az enum elso tagja fog szerepelni, emiatt kell ujra atmasolni az enum-bol az ertekeket copyto-val
            Enum.GetValues(typeof(KonyvTipus)).CopyTo(tipusok, 0);

            bolt.Add(new Konyv(
                $"{vezetek[r.Next(0, vezetek.Length)]} {kereszt[r.Next(0, kereszt.Length)]}", $"{szavak[r.Next(0, szavak.Length)]} {szavak[r.Next(0, szavak.Length)]}", tipusok[r.Next(0, tipusok.Length)], r.Next(2000, 30000), r.Next(1, 4)
                ));
        }
    }
}
