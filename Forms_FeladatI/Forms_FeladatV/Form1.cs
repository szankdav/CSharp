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

namespace Forms_FeladatV
{
    public partial class Form1 : Form
    {
        private string mappaEleresiUt = string.Empty;
        private Form1 form;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog mappa = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                mappaEleresiUt = folderBrowserDialog1.SelectedPath;
            }
            if (File.Exists($"{mappaEleresiUt}\\tmp.log") && File.Exists($"{mappaEleresiUt}\\tmp.log"))
            {
               DialogResult result = MessageBox.Show("A kivalasztott mappaban mar letezik egy tmp.log es egy main.log nevu fajl! Kivanja felulirni?", "Letezo fajl", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    File.Create($"{mappaEleresiUt}\\tmp.log").Close();
                    File.Create($"{mappaEleresiUt}\\main.log").Close();
                }
                else
                {
                    MessageBox.Show("A fajlok letrehozasa nem sikerult!", "Informacio...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.Create($"{mappaEleresiUt}\\tmp.log").Close();
                File.Create($"{mappaEleresiUt}\\main.log").Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            do
            {
                if (textBox1.Text.Length >= 5 && textBox1.Text.Length % 5 == 0)
                {
                    File.WriteAllText($"{mappaEleresiUt}\\tmp.log", textBox1.Text);
                }
            } while (form != null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valoban ki akar lepni ebbol a nagyszeru alkalmazasbol?", "Kilepes...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText($"{mappaEleresiUt}\\main.log", textBox1.Text);
        }
    }
}
