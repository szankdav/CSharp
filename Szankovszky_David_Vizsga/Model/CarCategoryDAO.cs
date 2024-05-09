using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga.Model
{
    public class CarCategoryDAO
    {
        public List<CarCategory> GetCarCategoryDataFromDatabase()
        {
            Database database = new Database();
            database.ConnectToDatabase();

            List<CarCategory> carCategories = new List<CarCategory>();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT * FROM exam_cars.car_category";
                MySqlDataReader mySqlDataReader = Database.mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    carCategories.Add(
                    new CarCategory(
                        mySqlDataReader.GetInt32("id"),
                        mySqlDataReader.GetString("category_name")
                        )
                    );
                }
                mySqlDataReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a lekérdezés során: {ex.Message}");
            }
            finally
            {
                database.CloseDatabaseConnection();
            }
            return carCategories;
        }
    }
}
