using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemóriaJáték
{
    public partial class FrmJatekTipusValasztas : Form
    {
        int jatekTipus;
        public int JatekTipus { get => jatekTipus; set => jatekTipus = value; }

        public FrmJatekTipusValasztas()
        {
            InitializeComponent();
            CmbJatekTipus.DataSource = Enum.GetValues(typeof(JatekTipus)).Cast<Enum>().Select(value => new
            {
                (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                value
            }).OrderBy(item => item.value).ToList();
            CmbJatekTipus.DisplayMember = "Description";
            CmbJatekTipus.ValueMember = "value";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (CmbJatekTipus.SelectedIndex == 0)
            {
                jatekTipus = 1;
            }
            else
            {
                jatekTipus = 2;
            }
        }

        private void CmbJatekTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbJatekTipus.SelectedIndex == 0)
            {
                LblJatekTipusInfo.Text = "Memóriajáték szám feliratos gombokkal!";
                LblJatekTipusInfo.Font = new Font(LblJatekTipusInfo.Font, FontStyle.Bold);
            }
            else
            {
                LblJatekTipusInfo.Text = "Memóriajáték színes gombokkal!";
                LblJatekTipusInfo.Font = new Font(LblJatekTipusInfo.Font, FontStyle.Bold);
            }
        }
    }
}
