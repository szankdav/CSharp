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

namespace Bombajatek
{
    public partial class Form1 : Form
    {
        int ido;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool result;
            do
            {
                result = int.TryParse(Interaction.InputBox("Kerem, adja meg, hany masodpercig fusson a program", "Bomba futasa...", "5"), out ido);
                if (result && (ido < 5 || ido > 10))
                {
                    result = !result;
                }
            } while (!result);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int percek = ido / 60;
            int masodpercek = ido - percek / 60;
            label1.Text = $"{percek} : {masodpercek}";
            if (ido > 0)
            {
                Console.Beep(2000, 20);
                ido--;
            }
            else
            {
                Console.Beep(2500, 1000);
                this.Close();
            }
        }
    }
}
