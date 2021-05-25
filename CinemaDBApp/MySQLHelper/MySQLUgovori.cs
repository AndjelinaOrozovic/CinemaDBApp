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
    class MySQLUgovori
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT u.IdUgovor, u.PocetakRadnogOdnosa, u.PrekidUgovora, u.MENADZER_ZAPOSLENI_IdZaposleni, u.ZAPOSLENI_IdZaposleni
                FROM `UGOVOR` u
                INNER JOIN `ZAPOSLENI` z ON z.IdZaposleni=u.ZAPOSLENI_IdZaposleni
                INNER JOIN `MENADZER` m ON m.ZAPOSLENI_IdZaposleni=u.MENADZER_ZAPOSLENI_IdZaposleni
                WHERE PocetakRadnogOdnosa LIKE @str OR PrekidUgovora LIKE @str";

        private static readonly string SELECT_BY_MAX_ID =
            @"SELECT MAX(IdUgovor), PocetakRadnogOdnosa, PrekidUgovora, MENADZER_ZAPOSLENI_IdZaposleni, ZAPOSLENI_IdZaposleni
                FROM ugovor";

        private static readonly string INSERT =
            @"INSERT INTO ugovor(PocetakRadnogOdnosa, PrekidUgovora, MENADZER_ZAPOSLENI_IdZaposleni, ZAPOSLENI_IdZaposleni)
                VALUES (@PocetakRadnogOdnosa, @PrekidUgovora, @MENADZER_ZAPOSLENI_IdZaposleni, @ZAPOSLENI_IdZaposleni)";

        private static readonly string UPDATE =
            @"UPDATE `ugovor` SET PocetakRadnogOdnosa=@PocetakRadnogOdnosa, PrekidUgovora=@PrekidUgovora, MENADZER_ZAPOSLENI_IdZaposleni=@MENADZER_ZAPOSLENI_IdZaposleni, ZAPOSLENI_IdZaposleni=@ZAPOSLENI_IdZaposleni
                WHERE IdUgovor=@IdUgovor";

        private static readonly string DELETE =
            "DELETE FROM ugovor WHERE IdUgovor=@IdUgovor";


        public static List<Ugovor> GetUgovore(string filter)
        {
            List<Ugovor> result = new List<Ugovor>();
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
                    result.Add(new Ugovor()
                    {
                        IdUgovor = reader.GetInt32(0),
                        PocetakRadnogOdnosa = reader.GetDateTime(1),
                        PrekidUgovora = reader.GetDateTime(2),
                        Menadzer = new Menadzer()
                        {
                            Zaposleni = new Zaposleni()
                            {
                                IdZaposleni = reader.GetInt32(3),
                            }
                        },
                        Zaposleni = new Zaposleni()
                        {
                            IdZaposleni = reader.GetInt32(4)
                        }
                    }) ;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetUgovore", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertUgovore(Ugovor ugovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@PocetakRadnogOdnosa", ugovor.PocetakRadnogOdnosa);
                cmd.Parameters.AddWithValue("@PrekidUgovora", ugovor.PrekidUgovora);
                cmd.Parameters.AddWithValue("@MENADZER_ZAPOSLENI_IdZaposleni", ugovor.Menadzer.Zaposleni.IdZaposleni);
                cmd.Parameters.AddWithValue("@ZAPOSLENI_IdZaposleni", ugovor.Zaposleni.IdZaposleni);
                cmd.ExecuteNonQuery();
                ugovor.IdUgovor = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertUgovor", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateUgovor(Ugovor ugovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdUgovor", ugovor.IdUgovor);
                cmd.Parameters.AddWithValue("@PocetakRadnogOdnosa", ugovor.PocetakRadnogOdnosa);
                cmd.Parameters.AddWithValue("@PrekidUgovora", ugovor.PrekidUgovora);
                cmd.Parameters.AddWithValue("@MENADZER_ZAPOSLENI_IdZaposleni", ugovor.Menadzer.Zaposleni.IdZaposleni);
                cmd.Parameters.AddWithValue("@ZAPOSLENI_IdZaposleni", ugovor.Zaposleni.IdZaposleni);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateUgovor", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteUgovorById(int IdUgovor)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdUgovor", IdUgovor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteUgovorById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static Ugovor GetUgovorByMaxId()
        {
            Ugovor result = null;
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_MAX_ID;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = (new Ugovor()
                    {
                        IdUgovor = reader.GetInt32(0),
                        PocetakRadnogOdnosa = reader.GetDateTime(1),
                        PrekidUgovora = reader.GetDateTime(2),
                        Menadzer = new Menadzer()
                        {
                            Zaposleni = new Zaposleni()
                            {
                                IdZaposleni = reader.GetInt32(3),
                            }
                        },
                        Zaposleni = new Zaposleni()
                        {
                            IdZaposleni = reader.GetInt32(4)
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetZaposleniByMaxId", ex);
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
