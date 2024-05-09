using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga
{
    public class CarDAO
    {
        #region GET CAR FROM DATABASE
        public List<Car> GetAllCars() 
        {
            List<Car> cars = new List<Car>();
            Database database = new Database();
            database.ConnectToDatabase();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "SELECT cars.id, cars.licence_plate_number, cars.net_price, cars.manufacturer, cars.model, cars.category_id, car_category.category_name AS category_name, cars.km_amount, cars.status_id, car_status.name AS carStatus FROM exam_cars.cars INNER JOIN exam_cars.car_category ON cars.category_id = car_category.id INNER JOIN exam_cars.car_status ON cars.status_id = car_status.id";
                MySqlDataReader mySqlDataReader = Database.mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    string incomingModel;
                    int incomingKm;
                    if (!mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("model")))
                    {
                        incomingModel = mySqlDataReader.GetString("model");
                    }
                    else
                    {
                        incomingModel = "";
                    }

                    if (!mySqlDataReader.IsDBNull(mySqlDataReader.GetOrdinal("km_amount")))
                    {
                        incomingKm = mySqlDataReader.GetInt32("km_amount");
                    }
                    else
                    {
                        incomingKm = 0;
                    }

                    cars.Add(new Car(
                            mySqlDataReader.GetString("licence_plate_number"),
                            mySqlDataReader.GetInt32("net_price"),
                            mySqlDataReader.GetString("manufacturer"),
                            mySqlDataReader.GetInt32("category_id"),
                            mySqlDataReader.GetInt32("status_id"),
                            incomingModel,
                            incomingKm,
                            mySqlDataReader.GetString("carStatus"),
                            mySqlDataReader.GetInt32("id"),
                            mySqlDataReader.GetString("category_name")
                        ));
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
            return cars;
        }

        public void CreateNewCar(Car newCar)
        {
            Database database = new Database();
            database.ConnectToDatabase();

            try
            {
                Database.mySqlCommand.Parameters.Clear();
                Database.mySqlCommand.CommandText = "INSERT INTO exam_cars.cars (`licence_plate_number`, `net_price`, `manufacturer`, `model`, `category_id`, `km_amount`, `status_id`) VALUES (@licence_plate_number, @net_price, @manufacturer, @model, @category_id, @km_amount, @status)";
                Database.mySqlCommand.Parameters.AddWithValue("@licence_plate_number", newCar.Licent_plate_number);
                Database.mySqlCommand.Parameters.AddWithValue("@net_price", newCar.Net_price);
                Database.mySqlCommand.Parameters.AddWithValue("@manufacturer", newCar.Manufacturer);
                Database.mySqlCommand.Parameters.AddWithValue("@model", newCar.Model);
                Database.mySqlCommand.Parameters.AddWithValue("@category_id", newCar.Category_id);
                Database.mySqlCommand.Parameters.AddWithValue("@km_amount", newCar.Km_amount);
                Database.mySqlCommand.Parameters.AddWithValue("@status", newCar.Status_Id);
                Database.mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a jármű létrehozása során: {ex.Message}");
            }
            finally
            {
                database.CloseDatabaseConnection();
            }
        }

        public int GetAverageNetPrice()
        {
            int sum = 0;
            List<Car> cars = GetAllCars();
            foreach (var car in cars)
            {
                sum += car.Net_price;
            }
            return sum / cars.Count;
        }
        public Car GetMostExpensivePersonalCar()
        {
            List<Car> cars = GetAllCars();
            int mostExpensive = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Category_id == 1 && cars[i].Net_price > cars[mostExpensive].Net_price)
                {
                    mostExpensive = i;
                }
            }
            return cars[mostExpensive];
        }
        #endregion
    }
}
