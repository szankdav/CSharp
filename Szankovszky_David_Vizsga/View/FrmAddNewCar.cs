using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Szankovszky_David_Vizsga.Model;

namespace Szankovszky_David_Vizsga.View
{
    public partial class FrmAddNewCar : Form
    {
        public FrmAddNewCar()
        {
            InitializeComponent();
            FillCategoryComboBox();
        }
        public void FillCategoryComboBox()
        {
            CarCategoryDAO categoryDAO = new CarCategoryDAO();
            CmbCategory.DataSource = categoryDAO.GetCarCategoryDataFromDatabase();
            CmbCategory.ValueMember = "id";
            CmbCategory.DisplayMember = "name";
        }

        public void SaveCarToDatabase(Car newCar)
        {
            CarDAO carDAO = new CarDAO();
            carDAO.CreateNewCar(newCar);
        }

        public Car CarDataFromFormFields()
        {
            Car newCar = new Car(TxbLicencePlateNumber.Text.Trim(), (int)NudNetPrice.Value, TxbManufacturer.Text.Trim(), (int)CmbCategory.SelectedValue, (int)ChbStatus.CheckState, TxbModel.Text.Trim(), (int)NudKMAmount.Value);
            return newCar;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            SaveCarToDatabase(CarDataFromFormFields());
            MessageBox.Show("Sikeres mentés!");
        }
    }
}
