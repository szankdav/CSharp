using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegyGomb
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnGeneralas_Click(object sender, EventArgs e)
        {
            int top = BtnGeneralas.Bottom + 20, left = BtnGeneralas.Right + 20;
            for (int i = 1; i <= 4; i++)
            {
                Button btn = new Button()
                {
                    Parent = this,
                    Top = top,
                    Left = left,
                    Width = 60,
                    Height = 60,
                    Text = i.ToString()
                };
                btn.Click += Btn_Click;
                if (i % 2 == 0)
                {
                    top += 65;
                    left = BtnGeneralas.Right + 20;
                }
                else
                {
                    left += 65;
                }
            }
            BtnGeneralas.Enabled = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // A sender egy Button tipusu adatot tarol? Ha igen, akkor a btn valtozoba jojjon is letre erre a Button-ra egy referencia.
            if (sender is Button btn)
            {
                MessageBox.Show($"A gombon levo szam: {btn.Text}", "Informacio...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //if (sender is Button)
            //{
            //    MessageBox.Show($"A gombon levo szam: {(sender as Button).Text}", "Informacio...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }
    }
}
