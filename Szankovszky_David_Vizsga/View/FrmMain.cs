using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szankovszky_David_Vizsga.View;

namespace Szankovszky_David_Vizsga
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            LoadAllCars();
        }

        public void LoadAllCars()
        {
            CarDAO carDAO = new CarDAO();
            DgvCars.DataSource = null;
            DgvCars.DataSource = carDAO.GetAllCars();
        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            FrmAddNewCar frmAddNewCar = new FrmAddNewCar();
            if (frmAddNewCar.ShowDialog() == DialogResult.OK)
            {
                LoadAllCars();
            }
        }

        private void BtnAveragePrice_Click(object sender, EventArgs e)
        {
            CarDAO carDao = new CarDAO();
            MessageBox.Show($"The average price of the vehicles: {carDao.GetAverageNetPrice()} Ft.-");
        }

        private void BtnMostExpensiveCar_Click(object sender, EventArgs e)
        {
            CarDAO carDAO = new CarDAO();
            MessageBox.Show($"The most expensive car on the list is: Licence plate number : {carDAO.GetMostExpensivePersonalCar().Licent_plate_number}, Price: {carDAO.GetMostExpensivePersonalCar().Net_price}");
        }
    }
}
