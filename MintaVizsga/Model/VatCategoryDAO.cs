using MintaVizsga._utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaVizsga.Model
{
    internal class VatCategoryDAO
    {
        public List<VatCategory> GetAllVatCategories()
        {
            Database databaseObj = new Database();
            databaseObj.Connect();

            List<VatCategory> vatCategories = new List<VatCategory>();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT * FROM vat_category;";
                MySqlDataReader mysqlDataReaderObj = Database.mySqlCommand.ExecuteReader();
                while (mysqlDataReaderObj.Read())
                {


                    vatCategories.Add(new VatCategory(
                        mysqlDataReaderObj.GetInt32("id"),
                        mysqlDataReaderObj.GetString("name"),
                        mysqlDataReaderObj.GetInt32("value")
                     ));
                }
                mysqlDataReaderObj.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a lekérdezés során..." + ex.Message);
            }
            //finally
            //{
            //    databaseObj.CloseConnection();
            //}
            return vatCategories;
        }
    }
}
