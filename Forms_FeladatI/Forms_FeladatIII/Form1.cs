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

namespace Forms_FeladatIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int felhasznaloSzamok = 0;
            //int felhasznaloSzamokSzorzata = 1;
            //do
            //{
            //    felhasznaloSzamok += Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Kerem, irjon be egy szamot:", "Szamszorzo"));
            //    felhasznaloSzamokSzorzata *= felhasznaloSzamok;
            //} while (felhasznaloSzamok < 100);
            //MessageBox.Show($"A beirt szamok szorzata: {felhasznaloSzamokSzorzata}");
            //this.Close();

            int osszeg = 0;
            int szorzat = 1;
            
            while (osszeg < 100)
            {
                int tmp = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Kerem, adja meg a kovetkezo szamot!", "Szambekeres...", "0"));
                osszeg += tmp;
                szorzat *= tmp;
            }
            MessageBox.Show($"A szamok szorzata: {szorzat}");
        }
    }
}
