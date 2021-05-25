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
    class MySQLFilmZanr
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string INSERT =
            @"INSERT INTO film_zanr(ZANR_IdZanr, FILM_IdFilm)
                VALUES (@ZANR_IdZanr, @FILM_IdFilm)";

        public static void InsertFilmZanr(FilmZanr fz)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@ZANR_IdZanr", fz.ZANR_IdZanr);
                cmd.Parameters.AddWithValue("@FILM_IdFilm", fz.FILM_IdFilm);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertFilmZanr", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
