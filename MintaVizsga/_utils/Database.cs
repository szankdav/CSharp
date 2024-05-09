using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaVizsga._utils
{
    public class Database
    {
        static MySqlConnection mySqlConnection = new MySqlConnection();
        public static MySqlCommand mySqlCommand = new MySqlCommand();
        static string connectionString = "server=localhost;database=exam_demo_product;port=3306;user=root;password='';convert zero datetime=True";
        
        //using (MySqlConnection mySqlConnection = new MySqlConnection())
        //{
        //    mySqlConnection.ConnectionString = connectionString;
        //    mySqlConnection.Open();
        //    mySqlCommand.Connection = mySqlConnection;
        //    System.Windows.Forms.MessageBox.Show("Test");
        //}



        #region CONNECT
        public void Connect()
        {
            try
            {
                mySqlConnection.ConnectionString = connectionString;
                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception($"Hiba a kapcsolódáskor... {ex.Message}");
            }
        }
        #endregion

        #region CLOSE CONNECTION
        public void CloseConnection()
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
