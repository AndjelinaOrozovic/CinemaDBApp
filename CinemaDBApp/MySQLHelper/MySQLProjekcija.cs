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
    class MySQLProjekcija
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT p.SALA_IdSala, s.Naziv, p.DatumIVrijemePrikazivanja, p.FILM_IdFilm, f.Naziv, p.Cijena
                FROM `PROJEKCIJA` p
                INNER JOIN `SALA` s ON s.IdSala=p.SALA_IdSala
                INNER JOIN `FILM` f ON f.IdFilm=p.FILM_IdFilm
                WHERE p.DatumIVrijemePrikazivanja > sysDate()
                ORDER BY p.DatumIVrijemePrikazivanja DESC";

        private static readonly string SELECT_FUTURE =
            @"SELECT * FROM projekcija
            WHERE projekcija.DatumIVrijemePrikazivanja > sysdate()";

        private static readonly string INSERT =
            @"INSERT INTO projekcija(SALA_IdSala, DatumIVrijemePrikazivanja, FILM_IdFilm, Cijena)
                VALUES (@SALA_IdSala, @DatumIVrijemePrikazivanja, @FILM_IdFilm, @Cijena)";

        private static readonly string UPDATE =
            @"UPDATE `projekcija` SET Cijena=@Cijena
                WHERE SALA_IdSala=@SALA_IdSala AND DatumIVrijemePrikazivanja=@DatumIVrijemePrikazivanja AND FILM_IdFilm = @FILM_IdFilm ";

        private static readonly string DELETE =
            "DELETE FROM projekcija WHERE SALA_IdSala=@SALA_IdSala AND FILM_IdFilm = @FILM_IdFilm AND DatumIVrijemePrikazivanja=@DatumIVrijemePrikazivanja";



        public static List<Projekcija> GetProjekcija(string filter)
        {
            List<Projekcija> result = new List<Projekcija>();
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
                    result.Add(new Projekcija()
                    {
                        Sala = new Sala()
                        {
                            IdSala = reader.GetInt32(0),
                            Naziv = reader.GetString(1)
                        },
                        DatumIVrijemePrikazivanja = reader.GetDateTime(2),
                        Film = new Film()
                        {
                            IdFilm = reader.GetInt32(3),
                            Naziv = reader.GetString(4)
                        },
                        Cijena = reader.GetDecimal(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetProjekcije", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static List<Projekcija> GetProjekcijaFuture()
        {
            List<Projekcija> result = new List<Projekcija>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_FUTURE;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Projekcija()
                    {
                        Sala = new Sala()
                        {
                            IdSala = reader.GetInt32(0)
                        },
                        DatumIVrijemePrikazivanja = reader.GetDateTime(1),
                        Film = new Film()
                        {
                            IdFilm = reader.GetInt32(2),
                        },
                        Cijena = reader.GetDecimal(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetProjekcije", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertProjekcija(Projekcija projekcija)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@SALA_IdSala", projekcija.Sala.IdSala);
                cmd.Parameters.AddWithValue("@DatumIVrijemePrikazivanja", projekcija.DatumIVrijemePrikazivanja);
                cmd.Parameters.AddWithValue("@FILM_IdFilm", projekcija.Film.IdFilm);
                cmd.Parameters.AddWithValue("@Cijena", projekcija.Cijena);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertProjekcija", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateProjekcija(Projekcija projekcija)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@SALA_IdSala", projekcija.Sala.IdSala);
                cmd.Parameters.AddWithValue("@DatumIVrijemePrikazivanja", projekcija.DatumIVrijemePrikazivanja);
                cmd.Parameters.AddWithValue("@FILM_IdFilm", projekcija.Film.IdFilm);
                cmd.Parameters.AddWithValue("@Cijena", projekcija.Cijena);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateProjekcija", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteProjekcija(Projekcija projekcija)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@SALA_IdSala", projekcija.Sala.IdSala);
                cmd.Parameters.AddWithValue("@DatumIVrijemePrikazivanja", projekcija.DatumIVrijemePrikazivanja);
                cmd.Parameters.AddWithValue("@FILM_IdFilm", projekcija.Film.IdFilm);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteProjekcija", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
