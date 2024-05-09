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

namespace MemóriaJáték
{
    public partial class FrmEredmenyek : Form
    {
        public FrmEredmenyek()
        {
            InitializeComponent();
        }

        private void FrmEredmenyek_Load(object sender, EventArgs e)
        {
            foreach (string item in File.ReadLines("eredmenyek.txt"))
            {
                TxbEredmenyek.Text += $"{item}{Environment.NewLine}";
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
