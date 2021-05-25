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
    class MySQLKinoInfo
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT Idkino, Naziv, Telefon, Adresa FROM `KINO_INFO`
                ORDER BY Telefon";

        public static List<KinoInfo> GetKinoInfo()
        {
            List<KinoInfo> result = new List<KinoInfo>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new KinoInfo()
                    {
                        Idkino = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Telefon = reader.GetString(2),
                        Adresa = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKinoInfo", ex);
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
