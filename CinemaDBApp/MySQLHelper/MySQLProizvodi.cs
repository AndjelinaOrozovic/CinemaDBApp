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
    class MySQLProizvodi
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT p.IdProizvod, p.Naziv, p.Cijena, k.IdKategorija, k.Naziv
                FROM `PROIZVOD` p
                INNER JOIN `KATEGORIJA` k ON k.IdKategorija=p.KATEGORIJA_IdKategorija
                WHERE p.Naziv LIKE @str
                ORDER BY p.Naziv";

        private static readonly string INSERT =
            @"INSERT INTO proizvod(Naziv, Cijena, KATEGORIJA_IdKategorija)
                VALUES (@Naziv, @Cijena, @KATEGORIJA_IdKategorija)";

        private static readonly string UPDATE =
            @"UPDATE `proizvod` SET Naziv=@Naziv, Cijena=@Cijena, KATEGORIJA_IdKategorija=@KATEGORIJA_IdKategorija
                WHERE IdProizvod=@IdProizvod";

        private static readonly string DELETE =
            "DELETE FROM proizvod WHERE IdProizvod=@IdProizvod";



        public static List<Proizvod> GetProizvode(string filter)
        {
            List<Proizvod> result = new List<Proizvod>();
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
                    result.Add(new Proizvod()
                    {
                        IdProizvod = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Cijena = Convert.ToDecimal(reader.GetString(2)),
                        Kategorija = new Kategorija()
                        {
                            IdKategorija = reader.GetInt32(3),
                            Naziv = reader.GetString(4)
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetProizvod", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertProizvod(Proizvod proizvod)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Naziv", proizvod.Naziv);
                cmd.Parameters.AddWithValue("@Cijena", proizvod.Cijena);
                cmd.Parameters.AddWithValue("@KATEGORIJA_IdKategorija", proizvod.Kategorija.IdKategorija);
                cmd.ExecuteNonQuery();
                proizvod.IdProizvod = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertProizvod", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateProizvod(Proizvod proizvod)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("IdProizvod", proizvod.IdProizvod);
                cmd.Parameters.AddWithValue("@Naziv", proizvod.Naziv);
                cmd.Parameters.AddWithValue("@Cijena", proizvod.Cijena);
                cmd.Parameters.AddWithValue("@KATEGORIJA_IdKategorija", proizvod.Kategorija.IdKategorija);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateProizvod", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteProizvodById(int IdProizvod)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdProizvod", IdProizvod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteProizvodById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
