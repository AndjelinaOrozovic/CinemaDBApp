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
    class MySQLSale
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT s.IdSala, s.Naziv, s.Tip, s.KINO_Idkino 
                FROM sala s
                WHERE s.Naziv LIKE @str
                INNER JOIN `kino` k ON s.KINO_Idkino=k.Idkino";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT s.IdSala, s.Naziv, s.Tip, s.KINO_Idkino 
                FROM sala s
                INNER JOIN `kino` k ON s.KINO_Idkino=k.Idkino";

        private static readonly string SELECT_BY_ID =
            @"SELECT s.IdSala, s.Naziv, s.Tip, s.KINO_Idkino 
                FROM sala s
                WHERE s.IdSala=@str";

        public static List<Sala> GetSale(string filter)
        {
            List<Sala> result = new List<Sala>();
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
                    result.Add(new Sala()
                    {
                        IdSala = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Tip = reader.GetString(2),
                        Kino = new Kino()
                        {
                            IdKino = reader.GetInt32(3),
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetSale", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Sala GetSaleById(string filter)
        {
            Sala result = null;
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
                    result = (new Sala()
                    {
                        IdSala = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Tip = reader.GetString(2),
                        Kino = new Kino()
                        {
                            IdKino = reader.GetInt32(3),
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetSalaById", ex);
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
