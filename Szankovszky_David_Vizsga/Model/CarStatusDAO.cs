using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga.Model
{
    public class CarStatusDAO
    {
        public List<CarStatus> GetStatusFromDatabase()
        {
            Database database = new Database();
            database.ConnectToDatabase();

            List<CarStatus> vatCategories = new List<CarStatus>();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT * FROM exam_cars.car_status;";
                MySqlDataReader mysqlDataReader = Database.mySqlCommand.ExecuteReader();
                while (mysqlDataReader.Read())
                {


                    vatCategories.Add(new CarStatus(
                        mysqlDataReader.GetInt32("id"),
                        mysqlDataReader.GetString("name"),
                        mysqlDataReader.GetInt32("value")
                     ));
                }
                mysqlDataReader.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hiba a lekérdezés során..." + ex.Message);
            }
            finally
            {
                database.CloseDatabaseConnection();
            }
            return vatCategories;
        }
    }
}
