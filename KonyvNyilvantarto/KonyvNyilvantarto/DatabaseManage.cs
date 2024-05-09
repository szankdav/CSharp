using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace KonyvNyilvantarto
{
    internal static class DatabaseManage
    {
        static SqlConnection conn = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static string connectionString = "Data Source=DESKTOP-0HFV1GE\\SQLEXPRESS;Initial Catalog=Books;Integrated Security=True";

        static public void ConnectionOpen()
        {
            try
            {
                conn.ConnectionString = connectionString;
                conn.Open();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("A kapcsolódás sikeres!", ex.Message);
            }
        }

        static public void ConnectionClose()
        {
            try
            {
                conn.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("A kapcsolódás sikertelen!", ex.Message);
            }
        }

        static public List<Konyv> AllBooks()
        {
            List<Konyv> books = new List<Konyv>();

            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM [BooksData]";
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                }
                reader.Close();
                return books;
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Sikertelen lekérdezés!", ex.Message);
            }
        }

        static public Konyv OneBook(int sorszam)
        {
            Konyv book = null;
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Sorszám] = @sorszám";
                cmd.Parameters.Add(new SqlParameter("@sorszám", sorszam));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    book = new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]);
                }
                reader.Close();
                return book;
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Sikertelen lekérdezés!", ex.Message);
            }
        }

        static public void AddBook(Konyv newBook) 
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO [BooksData] ([Cím], [Szerző], [Műfaj]) OUTPUT INSERTED.Sorszám VALUES (@cím, @szerző, @műfaj)";
                cmd.Parameters.Add(new SqlParameter("@cím", newBook.Cim));
                cmd.Parameters.Add(new SqlParameter("@szerző", newBook.Szerzo));
                cmd.Parameters.Add(new SqlParameter("@műfaj", newBook.Mufaj.ToString()));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Könyv hozzáadása sikertelen!", ex.Message);
            }
        }

        static public void ModifyBook(Konyv modBook)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE [BooksData] SET [Cím] = @cím, [Szerző] = @szerző, [Műfaj] = @műfaj WHERE [Sorszám] = @sorszám";
                cmd.Parameters.Add(new SqlParameter("@cím", modBook.Cim));
                cmd.Parameters.Add(new SqlParameter("@szerző", modBook.Szerzo));
                cmd.Parameters.Add(new SqlParameter("@műfaj", modBook.Mufaj.ToString()));
                cmd.Parameters.Add(new SqlParameter("@sorszám", modBook.Sorszam));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Könyv módosítása sikertelen!", ex.Message);
            }
        }

        static public void DeleteBook(int sorszam)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "DELETE FROM [BooksData] WHERE [Sorszám] = @sorszám";
                cmd.Parameters.Add(new SqlParameter("@sorszám", sorszam));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Könyv törlése sikertelen!", ex.Message);
            }
        }

        static public List<Konyv> FilterBooks(Kategoriak mufaj, string cim, string szerzo)
        {
            List<Konyv> filteredBooks = new List<Konyv>();
            try
            {
                if (mufaj != Kategoriak.Válasszon)
                {
                    if (!(string.IsNullOrEmpty(cim)) && string.IsNullOrEmpty(szerzo))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Cím] LIKE @cím AND [Műfaj] = @műfaj";
                        cmd.Parameters.Add(new SqlParameter("@cím", $"%{cim}%"));
                        cmd.Parameters.Add(new SqlParameter("@műfaj", mufaj.ToString()));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                    else if (string.IsNullOrEmpty(cim) && !(string.IsNullOrEmpty(szerzo)))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Szerző] LIKE @szerző AND [Műfaj] = @műfaj";
                        cmd.Parameters.Add(new SqlParameter("@szerző", $"%{szerzo}%"));
                        cmd.Parameters.Add(new SqlParameter("@műfaj", mufaj.ToString()));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                    else if (string.IsNullOrEmpty(cim) && string.IsNullOrEmpty(szerzo))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Műfaj] = @műfaj";
                        cmd.Parameters.Add(new SqlParameter("@műfaj", mufaj.ToString()));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                    else if (!(string.IsNullOrEmpty(cim)) && !(string.IsNullOrEmpty(szerzo)))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Cím] LIKE @cím AND [Szerző] LIKE @szerző AND [Műfaj] = @műfaj";
                        cmd.Parameters.Add(new SqlParameter("@cím", $"%{cim}%"));
                        cmd.Parameters.Add(new SqlParameter("@szerző", $"%{szerzo}%"));
                        cmd.Parameters.Add(new SqlParameter("@műfaj", mufaj.ToString()));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                }
                else
                {
                    if (!(string.IsNullOrEmpty(cim)) && string.IsNullOrEmpty(szerzo))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Cím] LIKE @cím";
                        cmd.Parameters.Add(new SqlParameter("@cím", $"%{cim}%"));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                    else if (string.IsNullOrEmpty(cim) && !(string.IsNullOrEmpty(szerzo)))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Szerző] LIKE @szerző";
                        cmd.Parameters.Add(new SqlParameter("@szerző", $"%{szerzo}%"));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                    else if (!(string.IsNullOrEmpty(cim)) && !(string.IsNullOrEmpty(szerzo)))
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "SELECT * FROM [BooksData] WHERE [Cím] LIKE @cím AND [Szerző] LIKE @szerző";
                        cmd.Parameters.Add(new SqlParameter("@cím", $"%{cim}%"));
                        cmd.Parameters.Add(new SqlParameter("@szerző", $"%{szerzo}%"));
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            filteredBooks.Add(new Konyv(reader["Cím"].ToString(), reader["Szerző"].ToString(), (Kategoriak)Enum.Parse(typeof(Kategoriak), reader["Műfaj"].ToString()), (int)reader["Sorszám"]));
                        }
                        reader.Close();
                    }
                }
                return filteredBooks;
            }
            catch (Exception ex)
            {
                throw new DatabaseExceptionManage("Könyv szűrése sikertelen!", ex.Message);
            }
        }
    }
}
