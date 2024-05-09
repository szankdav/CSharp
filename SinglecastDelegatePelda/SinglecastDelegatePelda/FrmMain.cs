using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinglecastDelegatePelda
{
    public partial class FrmMain : Form
    {
        MatekFunkcio delegalt;
        public FrmMain()
        {
            InitializeComponent();
            CmbMuvelet.DataSource = Enum.GetValues(typeof(AlapMuveletek));
            delegalt = new MatekFunkcio(Matek.Osszeadas);
        }

        private void CmbMuvelet_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((AlapMuveletek)CmbMuvelet.SelectedItem)
            {
                case AlapMuveletek.Osszeadas:
                    delegalt = Matek.Osszeadas;
                    break;
                case AlapMuveletek.Kivonas:
                    delegalt = Matek.Kivonas;
                    break;
                case AlapMuveletek.Szorzas:
                    delegalt = Matek.Szorzas;
                    break;
                case AlapMuveletek.Osztas:
                    delegalt = Matek.Osztas;
                    break;
            }
        }

        private void BtnSzamolas_Click(object sender, EventArgs e)
        {
            double eredmeny = delegalt((int)NudElsoOp.Value, (int)NudMasodikOp.Value);
            MessageBox.Show($"A szamolas eredmenye:{eredmeny}");
        }
    }
}
