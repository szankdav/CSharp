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

namespace Forms_FeladatIV
{
    public partial class Form1 : Form
    {
        //private string fajlUtvonal = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void megnyitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog megnyitottFajl = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void mentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(openFileDialog1.FileName, textBox1.Lines);
        }

        private void mentesMaskentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog mentettFile = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string mentettFajlUtvonala = saveFileDialog1.FileName;
                File.WriteAllText(mentettFajlUtvonala, textBox1.Text);
            }
        }

        private void kivagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
            {
                textBox1.Cut();
            }
        }

        private void masolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
            {
                textBox1.Copy();
            }
        }

        private void beillesztesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
