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
    class MySQLZanr
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT z.IdZanr, z.Naziv 
                FROM zanr z
                WHERE z.Naziv LIKE @str
                ORDER BY z.Naziv";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT z.IdZanr, z.Naziv 
                FROM zanr z
                ORDER BY z.Naziv";

        private static readonly string INSERT =
            @"INSERT INTO zanr(Naziv)
                VALUES (@Naziv)";

        private static readonly string UPDATE =
            @"UPDATE `zanr` SET Naziv=@Naziv
                WHERE IdZanr=@IdZanr";

        private static readonly string DELETE =
            "DELETE FROM zanr WHERE IdZanr=@IdZanr";

        public static List<Zanr> GetZanr(string filter)
        {
            List<Zanr> result = new List<Zanr>();
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
                    result.Add(new Zanr()
                    {
                        IdZanr = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetZanr", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertZanrove(Zanr zanr)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);
                cmd.ExecuteNonQuery();
                zanr.IdZanr = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertZanr", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateZanrove(Zanr zanr)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdZanr", zanr.IdZanr);
                cmd.Parameters.AddWithValue("@Naziv", zanr.Naziv);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateZanr", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteZanrById(int IdZanr)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdZanr", IdZanr);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteZanrById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
