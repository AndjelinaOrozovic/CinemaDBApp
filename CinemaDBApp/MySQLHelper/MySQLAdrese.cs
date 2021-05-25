using CinemaDBApp.Exceptions;
using CinemaDBApp.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.MySQLHelper
{
    class MySQLAdrese
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT IdAdresa, Drzava, Grad, PostanskiBroj, Ulica, Broj FROM `ADRESA`
                WHERE Drzava LIKE @str OR Grad LIKE @str OR PostanskiBroj LIKE @str OR Ulica LIKE @str
                ORDER BY Drzava, Grad";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT IdAdresa, Drzava, Grad, PostanskiBroj, Ulica, Broj FROM `ADRESA`
                ORDER BY Drzava, Grad";

        private static readonly string SELECT_BY_ID =
            @"SELECT IdAdresa, Drzava, Grad, PostanskiBroj, Ulica, Broj 
                FROM adresa a
                WHERE a.IdAdresa=@str";

        private static readonly string SELECT_BY_MAX_ID =
            @"SELECT MAX(IdAdresa), Drzava, Grad, PostanskiBroj, Ulica, Broj
                FROM adresa a";

        private static readonly string INSERT =
            @"INSERT INTO adresa(Drzava, Grad, PostanskiBroj, Ulica, Broj)
                VALUES (@Drzava, @Grad, @PostanskiBroj, @Ulica, @Broj)";

        private static readonly string UPDATE =
            @"UPDATE `adresa` SET Drzava=@Drzava, Grad=@Grad, PostanskiBroj=@PostanskiBroj, Ulica=@Ulica, Broj=@Broj
                WHERE IdAdresa=@IdAdresa";

        private static readonly string DELETE =
            "DELETE FROM adresa WHERE IdAdresa=@IdAdresa";

        public static List<Adresa> GetAdrese(string filter)
        {
            List<Adresa> result = new List<Adresa>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                if (filter != "")
                {
                    cmd.CommandText = SELECT;
                    cmd.Parameters.AddWithValue("@str", filter + "%");
                }
                else
                {
                    cmd.CommandText = SELECT_NO_FILTER;
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Adresa()
                    {
                        IdAdresa = reader.GetInt32(0),
                        Drzava = reader.GetString(1),
                        Grad = reader.GetString(2),
                        PostanskiBroj = reader.GetString(3),
                        Ulica = reader.GetString(4),
                        Broj = reader.GetString(5)
                    }); 
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetAdrese", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertAdresa(Adresa adresa)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Drzava", adresa.Drzava);
                cmd.Parameters.AddWithValue("@Grad", adresa.Grad);
                cmd.Parameters.AddWithValue("@PostanskiBroj", adresa.PostanskiBroj);
                cmd.Parameters.AddWithValue("@Ulica", adresa.Ulica);
                cmd.Parameters.AddWithValue("@Broj", adresa.Broj);
                cmd.ExecuteNonQuery();
                adresa.IdAdresa = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertAdrese", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateAdresa(Adresa adresa)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdAdresa", adresa.IdAdresa);
                cmd.Parameters.AddWithValue("@Drzava", adresa.Drzava);
                cmd.Parameters.AddWithValue("@Grad", adresa.Grad);
                cmd.Parameters.AddWithValue("@PostanskiBroj", adresa.PostanskiBroj);
                cmd.Parameters.AddWithValue("@Ulica", adresa.Ulica);
                cmd.Parameters.AddWithValue("@Broj", adresa.Broj);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateAdresa", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteAdresaById(int IdAdresa)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdAdresa", IdAdresa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteAdreseById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static Adresa GetAdreseById(string filter)
        {
            Adresa result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@str", filter);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (new Adresa()
                    {
                        IdAdresa = reader.GetInt32(0),
                        Drzava = reader.GetString(1),
                        Grad = reader.GetString(2),
                        PostanskiBroj = reader.GetString(3),
                        Ulica = reader.GetString(4),
                        Broj = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetAdreseById", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Adresa GetAdreseByMaxId()
        {
            Adresa result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_MAX_ID;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (new Adresa()
                    {
                        IdAdresa = reader.GetInt32(0),
                        Drzava = reader.GetString(1),
                        Grad = reader.GetString(2),
                        PostanskiBroj = reader.GetString(3),
                        Ulica = reader.GetString(4),
                        Broj = reader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetAdreseByMaxId", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }
    }
}
