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
    class MySQLMenadzer
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT ZAPOSLENI_IdZaposleni FROM `MENADZER`
                WHERE ZAPOSLENI_IdZaposleni LIKE @str";

        public static Menadzer GetMenadzer(string filter)
        {
            Menadzer result = new Menadzer();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Menadzer()
                    {
                        Zaposleni = new Zaposleni()
                        {
                            IdZaposleni = reader.GetInt32(0)
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetMenadzere", ex);
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
