using MintaVizsga._utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaVizsga.Model
{
    public class ProductDAO
    {
        // Data Access Object - to handle the database

        #region GET PRODUCTS FROM DATABASE
        public List<Product> GetAllProducts() 
        {
            List<Product> products = new List<Product>();
            Database database = new Database();
            database.Connect();
            
            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT product.id, product.name, product.net_price, product.vat_id, product.manufacturer, product.model, product.category_id, product.created_At, product_category.name AS productName, vat_category.name AS vatCategory FROM exam_demo_product.product INNER JOIN exam_demo_product.product_category ON product.category_id = product_category.id INNER JOIN exam_demo_product.vat_category ON product.vat_id = vat_category.id";
                MySqlDataReader mySqlDataReader = Database.mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    // Check if the created_at column in our databased is null
                    string createdDateTemp;
                    if (!mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("created_at")))
                    {
                        createdDateTemp = mySqlDataReader.GetDateTime(mySqlDataReader.GetOrdinal("created_at")).ToString();
                    }
                    else
                    {
                        createdDateTemp = "";
                    }

                    products.Add(
                        new Product(
                            mySqlDataReader.GetString("name"),
                            mySqlDataReader.GetInt32("net_price"),
                            mySqlDataReader.GetInt32("vat_id"),
                            mySqlDataReader.GetString("manufacturer"),
                            mySqlDataReader.GetString("model"),
                            mySqlDataReader.GetInt32("category_id"),
                            createdDateTemp,
                            mySqlDataReader.GetString("productName"),
                            mySqlDataReader.GetString("vatCategory"),
                            mySqlDataReader.GetInt32("id")
                            ));
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
            return products;
        }

        public void CreateNewProduct(Product newProduct)
        {
            Database database = new Database();
            database.Connect();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "INSERT INTO exam_demo_product.product (`name`, `net_price`, `vat_id`, `manufacturer`, `model`, `category_id`, `created_at`) VALUES (@name, @net_price, @vat_id, @manufacturer, @model, @category_id, @created_at)";
                Database.mySqlCommand.Parameters.AddWithValue("@name", newProduct.Name);
                Database.mySqlCommand.Parameters.AddWithValue("@net_price", newProduct.NetPrice);
                Database.mySqlCommand.Parameters.AddWithValue("@vat_id", newProduct.VatId);
                Database.mySqlCommand.Parameters.AddWithValue("@manufacturer", newProduct.Manufacturer);
                Database.mySqlCommand.Parameters.AddWithValue("@model", newProduct.Model);
                Database.mySqlCommand.Parameters.AddWithValue("@category_id", newProduct.CategoryId);
                Database.mySqlCommand.Parameters.AddWithValue("@created_at", newProduct.CreatedAt);
                Database.mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a termék létrehozása során: {ex.Message}");
            }
            //finally
            //{
            //    database.CloseConnection();
            //}
        }
        #endregion
    }
}
