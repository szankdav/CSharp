using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga
{
    public class Car
    {
        #region PRIVATE FIELDS
        private int id;
        private string licent_plate_number;
        private int net_price;
        private string manufacturer;
        private string model;
        private int category_id;
        private string category_name;
        private int km_amount;
        private int status_id;
        private string status;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; }
        public string Licent_plate_number { get => licent_plate_number; }
        public int Net_price { get => net_price; }
        public string Manufacturer { get => manufacturer; }
        public int Category_id { get => category_id; }
        public int Status_Id { get => status_id; }
        public string Model { get => model; set => model = value; }
        public int Km_amount { get => km_amount; set => km_amount = value; }
        public string Status { get => status; set => status = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        #endregion

        #region CONSTRUCTORS
        public Car(string licent_plate_number, int net_price, string manufacturer, int category_id, int status_id, string model = null, int km_amount = 0, string status = null, int id = -1, string category_name = null)
        {
            if (id != -1)
            {
                this.id = id;
            }
            this.licent_plate_number = licent_plate_number;
            this.net_price = net_price;
            this.manufacturer = manufacturer;
            this.Model = model;
            this.category_id = category_id;
            this.category_name = category_name;
            this.Km_amount = km_amount;
            this.status_id = status_id;
            this.status = status;
        }
        #endregion
    }
}
