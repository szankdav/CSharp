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
    public partial class FromParosSzamok : Form
    {
        List<int> parosSzamok;
        List<int> eredetiSzamok;
        public List<int> EredetiSzamok { get => eredetiSzamok; /*set => eredetiSzamok = value;*/ }
        public FromParosSzamok()
        {
            InitializeComponent();
            parosSzamok = new List<int>();
            eredetiSzamok = new List<int>();
        }

        public FromParosSzamok(List<int> szamok) : this()
        {
            eredetiSzamok = szamok;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    parosSzamok.Add(szamok[i]);
                }
            }
            listBox1.DataSource = parosSzamok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eredetiSzamok.Remove((int)listBox1.SelectedItem);
            parosSzamok.Remove((int)listBox1.SelectedItem);
            listBox1.DataSource = null;
            listBox1.DataSource = parosSzamok;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
