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
    class MySQLKina
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT k.Idkino, k.Naziv, k.ADRESA_IdAdresa 
                FROM kino k
                WHERE k.Naziv LIKE @str
                INNER JOIN `ADRESA` a ON a.IdAdresa=k.ADRESA_IdAdresa";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT k.Idkino, k.Naziv, k.ADRESA_IdAdresa 
                FROM kino k
                INNER JOIN `ADRESA` a ON a.IdAdresa=k.ADRESA_IdAdresa";

        private static readonly string SELECT_BY_ID =
            @"SELECT k.Idkino, k.Naziv, k.ADRESA_IdAdresa 
                FROM kino k
                WHERE k.IdKino=@str";

        public static List<Kino> GetKina(string filter)
        {
            List<Kino> result = new List<Kino>();
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
                    result.Add(new Kino()
                    {
                        IdKino = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Adresa = new Adresa()
                        {
                            IdAdresa = reader.GetInt32(2),
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKina", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Kino GetKinaById(string filter)
        {
            Kino result = null;
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
                    result = (new Kino()
                    {
                        IdKino = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Adresa = new Adresa()
                        {
                            IdAdresa = reader.GetInt32(2),
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKinaById", ex);
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
