using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtadasPelda
{
    public partial class Form1 : Form
    {
        Random r;
        List<int> szamok = new List<int>();
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            for (int i = 1; i <= 20; i++)
            {
                szamok.Add(r.Next(1, 101));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = szamok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromParosSzamok frm = new FromParosSzamok(szamok);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                szamok = frm.EredetiSzamok;
                listBox1.DataSource = null;
                listBox1.DataSource = szamok;
            }
        }
    }
}
