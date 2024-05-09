using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FeladatI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki akar lepni ebbol a nagyszeru alkalmazasbol?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtnMasolas_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != string.Empty)
            {
                label1.Text = textBox1.Text;
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Kerem adjon meg ertekes adatot!", "Figyelmeztetes...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
