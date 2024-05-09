using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaVizsga.Model
{
    public class Product
    {
		#region PRIVATE FIELDS
		private int id;
		private string name;
		private int netPrice;
		private int vatId;
		private string manufacturer;
		private string model;
		private int categoryId;
		private string createdAt;
        private string categoryName;
        private string vatAmount;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; }
        public string Name { get => name; }
        public int NetPrice { get => netPrice; }
        public int VatId { get => vatId; }
        public string Manufacturer { get => manufacturer; }
        public string Model { get => model; }
        public int CategoryId { get => categoryId; }
        public string CreatedAt { get => createdAt; }
        public string CategoryName { get => categoryName; }
        public string VatAmount { get => vatAmount; }
        #endregion

        #region CONSTRUCTORS
        public Product(string name, int netPrice, int vatId, string manufacturer, string model, int categoryId, string createdAt, string categoryName = null, string vatAmount = null, int id = -1)
        {
            if (id != -1)
            {
                this.id = id;
            }
            this.name = name;
            this.netPrice = netPrice;
            this.vatId = vatId;
            this.manufacturer = manufacturer;
            this.model = model;
            this.categoryId = categoryId;
            this.createdAt = createdAt;
            this.categoryName = categoryName;
            this.vatAmount = vatAmount;
        }
        #endregion

        //public string NameChecker(string name)
        //{
        //    if (name == string.Empty)
        //    {
        //        throw new ArgumentException("Hiba");
        //    }
        //    else
        //    {
        //        return name;
        //    }
        //}
    }
}
