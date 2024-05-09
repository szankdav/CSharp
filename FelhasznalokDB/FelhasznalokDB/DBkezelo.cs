using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznalokDB
{
    internal static class DBkezelo // DAL osztaly - Data Access Layer
    {
        #region VARIABLES
        static SqlConnection conn = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static SqlTransaction transaction;
        static string connStr = "Data Source=.\\SQLEXPRESS;Initial Catalog=Felhasznalok;Integrated Security=True";
        #endregion

        #region Connection Manage
        // Open
        public static void ConnectionOpen()
        {
            try
            {
                conn.ConnectionString = connStr;
                conn.Open();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen csatlakozas az adatbazishoz!", ex.Message);
            }
        }
        // Close
        public static void ConnectionClose()
        {
            try
            {
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen kapcsolatbontas! A kapcsolat mar nem el!", ex.Message);
            }
        }
        #endregion

        #region User Data Manage
        // Lekerdezes
        public static List<Felhasznalo> AllUsers()
        {
            List<Felhasznalo> result = new List<Felhasznalo>();

            try
            {
                cmd.Parameters.Clear(); //Mindig ki kell torolni a parametertablat az eddigi lekerdezesek miatt!

                cmd.CommandText = "SELECT * FROM [FelhasznaloAdatok]";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Felhasznalo(reader["Felhasznalonev"].ToString(), reader["Jelszo"].ToString(), (DateTime)reader["RegisztraciosIdo"], (int)reader["Uid"]));
                }
                reader.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen lekerdezes!", ex.Message);
            }
        }

        public static Felhasznalo OneUser(int uId)
        {
            Felhasznalo beolvasottFelhasznalo = null;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM [FelhasznaloAdatok] WHERE [Uid] = @uid";
                cmd.Parameters.Add(new SqlParameter("@uid", uId));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    beolvasottFelhasznalo = new Felhasznalo(reader["Felhasznalonev"].ToString(), reader["Jelszo"].ToString(), (DateTime)reader["RegisztraciosIdo"], (int)reader["Uid"]);
                }
                reader.Close();
                return beolvasottFelhasznalo;
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen lekerdezes!", ex.Message);
            }
        }
        // Uj letrehozas
        public static void UserCreate(Felhasznalo newUser)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [FelhasznaloAdatok] ([Felhasznalonev], [Jelszo], [RegisztraciosIdo]) OUTPUT INSERTED.Uid VALUES (@felhasznalonev, @jelszo, @regisztraciosIdo)";
                cmd.Parameters.Add(new SqlParameter("@felhasznalonev", newUser.Felhasznalonev));
                cmd.Parameters.Add(new SqlParameter("@jelszo", newUser.Jelszo));
                cmd.Parameters.Add(new SqlParameter("@regisztraciosIdo", newUser.RegisztraciosIdo));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen beszuras!", ex.Message);
            }
        }
        // Modositas
        public static void UserModify(Felhasznalo modUser)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [FelhasznaloAdatok] SET [Felhasznalonev] = @felhasznalonev, [Jelszo] = @jelszo, [RegisztraciosIdo] = @regisztraciosIdo WHERE [Uid] = @uid";
                cmd.Parameters.Add(new SqlParameter("@felhasznalonev", modUser.Felhasznalonev));
                cmd.Parameters.Add(new SqlParameter("@jelszo", modUser.Jelszo));
                cmd.Parameters.Add(new SqlParameter("@regisztraciosIdo", modUser.RegisztraciosIdo));
                cmd.Parameters.Add(new SqlParameter("@uid", modUser.Uid));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen modositas!", ex.Message);
            }
        }
        //UPDATE INTO [FelhasznaloAdatok] SET [Felhasznalonev] = @felhasznalonev, [Jelszo] = @jelszo, [RegisztraciosIdo] = @regisztraciosIdo WHERE [Uid] = @uid

        // Torles
        public static void UserDelete(int userID)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [FelhasznaloAdatok] WHERE [Uid] = @uid";
                cmd.Parameters.Add(new SqlParameter("@uid", userID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DBKivetel("Sikertelen torles!", ex.Message);
            }
        }
        #endregion
    }
}
