using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szankovszky_David_Vizsga
{
    public class Database
    {
        static MySqlConnection mySqlConnection = new MySqlConnection();
        public static MySqlCommand mySqlCommand = new MySqlCommand();
        static string connectionString = "server=localhost;database=exam_cars;port=3306;user=root;password=''";

        #region CONNECT TO DATABASE
        public void ConnectToDatabase()
        {
            try
            {
                mySqlConnection.ConnectionString = connectionString;
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba az adatbázishoz történő kapcsolódáskor: {ex.Message}"); ;
            }
        }
        #endregion

        #region CLOSE DATABASE CONNECTION
        public void CloseDatabaseConnection()
        {
            try
            {
                mySqlConnection.Close();
                //mySqlConnection.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a kapcsolat lezárásakor: {ex.Message}");
            }
        }
        #endregion
    }
}
