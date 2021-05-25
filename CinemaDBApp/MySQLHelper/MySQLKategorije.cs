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
    class MySQLKategorije
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT k.IdKategorija, k.Naziv 
                FROM kategorija k
                WHERE k.Naziv LIKE @str";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT k.IdKategorija, k.Naziv 
                FROM kategorija k";

        private static readonly string SELECT_BY_ID =
            @"SELECT k.IdKategorija, k.Naziv
                FROM kategorija k
                WHERE k.IdKategorija=@str";

        public static List<Kategorija> GetKategorija(string filter)
        {
            List<Kategorija> result = new List<Kategorija>();
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
                    result.Add(new Kategorija()
                    {
                        IdKategorija = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKategorija", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Kategorija GetKategorijaById(string filter)
        {
            Kategorija result = null;
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
                    result = (new Kategorija()
                    {
                        IdKategorija = reader.GetInt32(0),
                        Naziv = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKategorijaById", ex);
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
