using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamitogepekDictionary
{
    public partial class FrmMain : Form
    {
        Dictionary<IPAddress, KeyValuePair<string, Szamitogep>> szamitoGepek;
        public FrmMain()
        {
            InitializeComponent();
            szamitoGepek = new Dictionary<IPAddress, KeyValuePair<string, Szamitogep>>();
        }

        private void BtnUjSzamitogep_Click(object sender, EventArgs e)
        {
            FrmFelvitel frm = new FrmFelvitel();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                szamitoGepek[frm.Ip] = new KeyValuePair<string, Szamitogep>(frm.Mac, frm.Szamitogep);
                ListBoxRefresh();
            }
        }

        private void LsbIPCimek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbIPCimek.SelectedIndex != -1)
            {
                KeyValuePair<string, Szamitogep> adat = szamitoGepek[(IPAddress)LsbIPCimek.SelectedItem];
                LblOperaciosRendszer.Text = adat.Value.Os;
                LblTulajdonos.Text = adat.Value.Tulaj;
            }
        }

        private void LsbMACCimek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbMACCimek.SelectedIndex != -1)
            {
                foreach (KeyValuePair<IPAddress, KeyValuePair<string, Szamitogep>> item in szamitoGepek)
                {
                    if (item.Value.Key == LsbMACCimek.SelectedItem.ToString())
                    {
                        LblOperaciosRendszer.Text = item.Value.Value.Os;
                        LblTulajdonos.Text = item.Value.Value.Tulaj;
                        break;
                    }
                }
            }
        }

        private void ListBoxRefresh()
        {
            LsbIPCimek.DataSource = null;
            LsbIPCimek.DataSource = szamitoGepek.Keys.ToList();
            LsbMACCimek.DataSource = null;
            List<string> macCimek = new List<string>();
            foreach (KeyValuePair<string, Szamitogep> item in szamitoGepek.Values)
            {
                macCimek.Add(item.Key);
            }
            LsbMACCimek.DataSource = macCimek;
        }
    }
}
