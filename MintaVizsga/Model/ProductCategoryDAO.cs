using MintaVizsga._utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaVizsga.Model
{
    public class ProductCategoryDAO
    {
        public List<ProductCategory> GetCategoryDataFromDatabase()
        {
            Database database = new Database();
            database.Connect();

            List<ProductCategory> productCategories = new List<ProductCategory>();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT * FROM exam_demo_product.product_category";
                MySqlDataReader mySqlDataReader = Database.mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    productCategories.Add(
                    new ProductCategory(
                        mySqlDataReader.GetInt32("id"),
                        mySqlDataReader.GetString("name")
                        )
                    );
                }
                mySqlDataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a lekérdezés során: {ex.Message}");
            }
            //finally
            //{
            //    database.CloseConnection();
            //}
            return productCategories;
        }
    }
}
