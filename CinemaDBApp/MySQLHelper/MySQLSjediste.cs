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
    class MySQLSjediste
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT sj.BrojSjedista, sj.RED_IdRed, sj.RED_SALA_IdSala 
                FROM sjediste sj
                INNER JOIN `red` r ON r.BrojReda=sj.RED_IdRed
                INNER JOIN `sala` s ON s.IdSala=sj.RED_SALA_IdSala
                WHERE R.BrojReda=@str";

        public static List<Sjediste> GetSjedista(string filter)
        {
            List<Sjediste> result = new List<Sjediste>();
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
                    result.Add(new Sjediste()
                    {
                        BrojSjedista = reader.GetInt32(0),
                        Red = new Red()
                        {
                            BrojReda = reader.GetInt32(1)
                        },
                        Sala = new Sala()
                        {
                            IdSala = reader.GetInt32(2)
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
