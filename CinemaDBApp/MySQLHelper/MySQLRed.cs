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
    class MySQLRed
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT r.BrojReda, r.SALA_IdSala, s.Naziv
                FROM red r
                INNER JOIN `sala` s ON s.IdSala=r.SALA_IdSala
                WHERE s.Naziv=@str";

        public static List<Red> GetRedove(string filter)
        {
            List<Red> result = new List<Red>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@str", filter);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Red()
                    {
                        BrojReda = reader.GetInt32(0),
                        Sala = new Sala()
                        {
                            IdSala = reader.GetInt32(1),
                            Naziv = reader.GetString(2)
                            
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
    }
}
