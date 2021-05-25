using CinemaDBApp.Exceptions;
using CinemaDBApp.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDBApp.MySQLHelper
{
    class MySQLFilm
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT_FILM_BYID =
            @"SELECT f.IdFilm, f.Naziv, f.KratakOpis, f.Trajanje
                FROM film f
                WHERE f.IdFilm=@str";

        private static readonly string SELECT_INFO_FILM =
            @"SELECT IdFilm, Naziv, KratakOpis, Trajanje, ZanrFilma
                FROM film_info
                WHERE Naziv LIKE @str";

        private static readonly string INSERT =
            @"INSERT INTO film(Naziv, KratakOpis, Trajanje)
                VALUES (@Naziv, @KratakOpis, @Trajanje)";

        private static readonly string DELETE =
            "DELETE FROM film WHERE IdFilm=@IdFilm";

        private static readonly string UPDATE =
            @"UPDATE `film` SET Naziv=@Naziv, KratakOpis=@KratakOpis, Trajanje=@Trajanje
                WHERE IdFilm=@IdFilm";



        public static List<FilmInfo> GetFilmInfo(string filter)
        {
            List<FilmInfo> result = new List<FilmInfo>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_INFO_FILM;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new FilmInfo()
                    {
                        IdFilm = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        KratakOpis = reader.GetString(2),
                        Trajanje = reader.GetInt32(3),
                        Zanr = reader.GetString(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetFilmInfo", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static List<Film> GetFilm(string filter)
        {
            List<Film> result = new List<Film>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_INFO_FILM;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Film()
                    {
                        IdFilm = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        KratakOpis = reader.GetString(2),
                        Trajanje = reader.GetInt32(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetFilm", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Film GetFilmoveById(string filter)
        {
            Film result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_FILM_BYID;
                cmd.Parameters.AddWithValue("@str", filter);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (new Film()
                    {
                        IdFilm = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        KratakOpis = reader.GetString(2),
                        Trajanje = reader.GetInt32(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetFilmById", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertFilmove(Film film)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", film.Naziv);
                cmd.Parameters.AddWithValue("@KratakOpis", film.KratakOpis);
                cmd.Parameters.AddWithValue("@Trajanje", film.Trajanje);
                cmd.ExecuteNonQuery();
                film.IdFilm = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertFilmove", ex);
            }
            finally
            {
                conn.Close();
            }
        }


        public static int MaxIdFilma() //poziv procedure!
        {
            int result = 0;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "maxID_Filma";
                cmd.Parameters.AddWithValue("pMaxId", MySqlDbType.Int32);
                cmd.Parameters["@pMaxId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@pMaxId"].Value);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MaxIdFilma", ex);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static void UpdateFilm(Film film)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdFilm", film.IdFilm);
                cmd.Parameters.AddWithValue("@Naziv", film.Naziv);
                cmd.Parameters.AddWithValue("@KratakOpis", film.KratakOpis);
                cmd.Parameters.AddWithValue("@Trajanje", film.Trajanje);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateFilm", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteFilmById(int IdFilm)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdFilm", IdFilm);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteFilmById", ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
