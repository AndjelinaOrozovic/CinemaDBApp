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
    class MySQLAngazman
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string INSERT =
            @"INSERT INTO angazman(LICE_IdLica, VRSTA_ANGAZMANA_IdVrstaAngazmana, FILM_IdFilm)
                VALUES (@LICE_IdLica, @VRSTA_ANGAZMANA_IdVrstaAngazmana, @FILM_IdFilm)";

        public static void InsertAngazman(Angazman ag)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@LICE_IdLica", ag.LICE_IdLica);
                cmd.Parameters.AddWithValue("@VRSTA_ANGAZMANA_IdVrstaAngazmana", ag.VRSTA_ANGAZMANA_IdVrstaAngazmana);
                cmd.Parameters.AddWithValue("@FILM_IdFilm", ag.FILM_IdFilm);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertAngazman", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
