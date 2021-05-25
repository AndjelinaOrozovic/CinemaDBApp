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
    class MySQLRecepcioner
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT ZAPOSLENI_IdZaposleni FROM `RECEPCIONER`
                WHERE ZAPOSLENI_IdZaposleni LIKE @str";

        public static Recepcioner GetRecepcioner(string filter)
        {
            Recepcioner result = new Recepcioner();
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
                    result = new Recepcioner()
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
