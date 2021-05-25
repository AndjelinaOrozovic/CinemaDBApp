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
    class MySQLVrstaAngazmana
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT va.IdVrstaAngazmana, va.Naziv 
                FROM vrsta_angazmana va
                WHERE va.Naziv LIKE @str
                ORDER BY va.Naziv";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT va.IdVrstaAngazmana, va.Naziv 
                FROM vrsta_angazmana va
                ORDER BY va.Naziv";

        private static readonly string INSERT =
            @"INSERT INTO vrsta_angazmana(Naziv)
                VALUES (@Naziv)";

        private static readonly string UPDATE =
            @"UPDATE vrsta_angazmana SET Naziv=@Naziv
                WHERE IdVrstaAngazmana=@IdVrstaAngazmana";

        private static readonly string DELETE =
            "DELETE FROM vrsta_angazmana WHERE IdVrstaAngazmana=@IdVrstaAngazmana";

        public static List<VrstaAngazmana> GetVrstaAngazmana(string filter)
        {
            List<VrstaAngazmana> result = new List<VrstaAngazmana>();
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
                    result.Add(new VrstaAngazmana()
                    {
                        IdVrstaAngazmana = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetVrstaAngazmana", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertVrstaAngazmana(VrstaAngazmana va)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", va.Naziv);
                cmd.ExecuteNonQuery();
                va.IdVrstaAngazmana = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertVrstaAngazmana", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateVrstaAngazmana(VrstaAngazmana va)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdVrstaAngazmana", va.IdVrstaAngazmana);
                cmd.Parameters.AddWithValue("@Naziv", va.Naziv);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateVrstaAngazmana", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteVrstaAngazmanaById(int IdVrstaAngazmana)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdVrstaAngazmana", IdVrstaAngazmana);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteVrsaAngazmanaById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
