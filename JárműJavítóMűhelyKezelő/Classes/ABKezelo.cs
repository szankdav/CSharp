using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http.Headers;

namespace JárműJavítóMűhelyKezelő.Classes
{
    internal static class ABKezelo
    {
        #region PRIVATE FIELDS
        static SqlConnection conn = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        #endregion

        #region CONNECTION MANAGE
        public static void OpenConnection()
        {
            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["JárműJavítóMűhelyKezelő.Properties.Settings.JarmuJavitoMuhelyConnectionString"].ConnectionString;
                conn.Open();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new ABKivetelKezelo("Hiba a kapcsolat letrehozasaban!", ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new ABKivetelKezelo("Hiba a kapcsolat lezarasaban!", ex.Message);
            }
        }
        #endregion

        #region CRUD
        #region CREATE
        public static void MuhelyLetrehozas(Muhely muhely)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = "INSERT INTO [Muhely] OUTPUT INSERTED.[Id] VALUES (@iranyitoszam, @helyseg, @utcanev, @hazszam, @javithatojarmuvekszama, @vasarnapnyitva)";
                cmd.Parameters.AddWithValue("@iranyitoszam", muhely.MuhelyCim.IranyitoSzam);
                cmd.Parameters.AddWithValue("@helyseg", muhely.MuhelyCim.Helyseg);
                cmd.Parameters.AddWithValue("@utcanev", muhely.MuhelyCim.UtcaNev);
                cmd.Parameters.AddWithValue("@hazszam", muhely.MuhelyCim.HazSzam);
                cmd.Parameters.AddWithValue("@javithatojarmuvekszama", muhely.JavithatoJarmuvekSzama);
                cmd.Parameters.AddWithValue("@vasarnapnyitva", muhely.VasarnapNyitva);
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetelKezelo("Hiba a tranzakcio lezarasaban!", innerEx.Message);
                }
                throw new ABKivetelKezelo("Muhely letrehozasa sikertelen!", ex.Message);
            }
        }

        public static void JarmuLetrehozas(Jarmu jarmu)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = "INSERT INTO [Jarmu] VALUES (@id, @jarmuazonosito, @rendszam, @gyartasiev, @marka, @szarmazasihely, @hasznalt, @javitasara)";
                cmd.Parameters.AddWithValue("@id", jarmu.MuhelyId);
                cmd.Parameters.AddWithValue("@jarmuazonosito", jarmu.AzonositoSzam);
                cmd.Parameters.AddWithValue("@rendszam", jarmu.Rendszam);
                cmd.Parameters.AddWithValue("@gyartasiev", jarmu.GyartasEve);
                cmd.Parameters.AddWithValue("@marka", jarmu.Marka);
                cmd.Parameters.AddWithValue("@szarmazasihely", jarmu.SzarmazasiOrszag);
                cmd.Parameters.AddWithValue("@hasznalt", jarmu.Hasznalt);
                cmd.Parameters.AddWithValue("@javitasara", jarmu.JavitasAra);
                int id = -1;
                id = (int)cmd.ExecuteScalar();
                if (id != -1)
                {
                    cmd.Parameters.Clear();
                    if (jarmu is Szemelyauto szemelyauto)
                    {
                        cmd.CommandText = "INSERT INTO [Szemelyauto] OUTPUT INSERTED.[Azonosito] VALUES (@id, @kialakitas, @muszakimiattijavitas)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@kialakitas", szemelyauto.Kialakitas);
                        cmd.Parameters.AddWithValue("@muszakimiattijavitas", szemelyauto.MuszakiMiattiJavitas);
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                    }
                    else if (jarmu is Teherauto teherauto)
                    {
                        cmd.CommandText = "INSERT INTO [Teherauto] OUTPUT INSERTED.[Azonosito] VALUES (@id, @kialakitas, @utanfutos)";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@kialakitas", teherauto.Kialakitas);
                        cmd.Parameters.AddWithValue("@utanfutos", teherauto.Utanfutos);
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                    }
                }
                else
                {
                    cmd.Transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetelKezelo("Hiba a tranzakcio lezarasaban!", innerEx.Message);
                }
                throw new ABKivetelKezelo("Jarmu letrehozasa sikertelen!", ex.Message);
            }
        }
        #endregion
        #region READ
        public static List<Muhely> TeljesLekerdezes()
        {
            try
            {
                List<Muhely> muhelyLista = new List<Muhely>();
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = "SELECT * FROM [Muhely]";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    muhelyLista.Add(new Muhely((byte)reader["JavithatoJarmuvekSzama"], (bool)reader["VasarnapNyitva"], new MuhelyCim(reader["Iranyitoszam"].ToString(), reader["Helyseg"].ToString(), reader["Utcanev"].ToString(), (int)reader["Hazszam"]), (int)reader["Id"]));
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM [Jarmu] INNER JOIN [Szemelyauto] ON [Jarmu].[Id] = [Szemelyauto].[Id]";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Muhely muhely in muhelyLista)
                    {
                        if ((int)reader["Id"] == muhely.MuhelyId)
                        {
                            muhely.UjJarmu(new Szemelyauto(reader["Kialakitas"].ToString(), (bool)reader["MuszakiMiattiJavitas"], (int)reader["Id"], reader["JarmuAzonosito"].ToString(), reader["Rendszam"].ToString(), (DateTime)reader["GyartasiEv"], reader["Marka"].ToString(), reader["SzarmazasiHely"].ToString(), (bool)reader["Hasznalt"], (int)reader["JavitasAra"]));
                        }
                    }
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM [Jarmu] INNER JOIN [Teherauto] ON [Jarmu].[Id] = [Teherauto].[Id]";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (Muhely muhely in muhelyLista)
                    {
                        if ((int)reader["Id"] == muhely.MuhelyId)
                        {
                            muhely.UjJarmu(new Teherauto(reader["Kialakitas"].ToString(), (bool)reader["Utanfutos"], (int)reader["Id"], reader["JarmuAzonosito"].ToString(), reader["Rendszam"].ToString(), (DateTime)reader["GyartasiEv"], reader["Marka"].ToString(), reader["SzarmazasiHely"].ToString(), (bool)reader["Hasznalt"], (int)reader["JavitasAra"]));
                        }
                    }
                }
                reader.Close();
                cmd.Transaction.Commit();
                return muhelyLista;
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetelKezelo("Hiba a tranzakcio lezarasaban!", innerEx.Message);
                }
                throw new ABKivetelKezelo("A muhelylista lekerdezese sikertelen!", ex.Message);
            }
        }
        #endregion
        #region UPDATE
        public static void Muhelymodositas(Muhely muhely)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Transaction = conn.BeginTransaction();
                cmd.CommandText = "UPDATE [Muhely] SET []";
            }
            catch (Exception ex)
            {
                try
                {
                    if (cmd.Transaction != null)
                    {
                        cmd.Transaction.Rollback();
                    }
                }
                catch (Exception innerEx)
                {
                    throw new ABKivetelKezelo("Hiba a tranzakcio lezarasaban!", innerEx.Message);
                }
                throw new ABKivetelKezelo("A muhely modositasa sikertelen!", ex.Message);
            }
        }
        #endregion
        #region DELETE
        #endregion
        #endregion
    }
}
