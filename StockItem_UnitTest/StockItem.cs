using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockItem_UnitTest
{
    public class StockItem
    {
        #region PRIVATE FIELDS
        int id;
        string name;
        string accessionNumber;
        string manufacturer;
        string model;
        int stockAmount;
        DateTime publishDate;
        bool status;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string AccessionNumber { get => accessionNumber; set => accessionNumber = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Model { get => model; set => model = value; }
        public int StockAmount
        {
            get => stockAmount;
            set
            {
                if (stockAmount < 0)
                {
                    throw new StockItemException("A raktarkeszlet nem lehet negativ szam!");
                }
                else
                {
                    value = stockAmount;
                }
            }
        }
        public DateTime PublishDate { get => publishDate; set => publishDate = value; }
        public bool Status { get => status; set => status = value; }
        #endregion

        #region CONSTRUCTORS
        public StockItem(int id, string name, string accessionNumber, string manufacturer, string model, int stockAmount, DateTime publishDate, bool status)
        {
            Id = id;
            Name = name;
            AccessionNumber = accessionNumber;
            Manufacturer = manufacturer;
            Model = model;
            StockAmount = stockAmount;
            PublishDate = publishDate;
            Status = status;
        }
        #endregion

        #region METHODS
        public void SetStatusByStockAmount(int stockAmount)
        {
            Status = stockAmount != 0;               
        }
    #endregion
}
}
