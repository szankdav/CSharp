using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_UnitTest
{
    public class Product
    {
		#region PRIVATE FIELDS
		int id;
		string name;
		double netPrice;
		double taxPercent;
		int stockAmount;
        #endregion

        #region PUBLIC PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double NetPrice { get => netPrice; set => netPrice = value; }
        public double TaxPercent { get => taxPercent; set => taxPercent = value; }
        public int StockAmount { get => stockAmount; set => stockAmount = value; }
        #endregion

        #region CONSTRUCTORS
        public Product(int id, string name, double netPrice, double taxPercent, int stockAmount)
        {
            Id = id;
            Name = name;
            NetPrice = netPrice;
            TaxPercent = taxPercent;
            StockAmount = stockAmount;
        }
        #endregion

        #region METHODS
        public double GetGrossPrice()
        {
            return NetPrice * (TaxPercent / 100 + 1);
        }

        public void DoAllocateProduct(int num)
        {
            if (StockAmount < num)
            {
                throw new ProductException("Nincs elegendő mennyiség raktáron!");
            }
            
            if (num < 0)
            {
                throw new ProductException("A foglalni kívánt mennyiség nem lehet negatív!");
            }

            if (num > int.MaxValue)
            {
                throw new ProductException("Túl nagy számot adott meg!");
            }

            StockAmount -= num;
        }

        #endregion

    }
}
