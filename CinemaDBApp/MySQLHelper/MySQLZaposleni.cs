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
    class MySQLZaposleni
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT z.IdZaposleni, z.JMB, z.Ime, z.Prezime, z.Email, z.Plata, z.KINO_Idkino, z.ADRESA_IdAdresa
                FROM `ZAPOSLENI` z
                INNER JOIN `KINO` k ON k.Idkino=z.KINO_IDkino
                INNER JOIN `ADRESA` a ON a.IdAdresa=z.ADRESA_IdAdresa
                WHERE Ime LIKE @str OR Prezime LIKE @str OR Email LIKE @str OR Plata LIKE @str OR JMB LIKE @str
                ORDER BY Prezime, Ime";

        private static string SELECT_BY_ID =
            @"SELECT z.IdZaposleni, z.JMB, z.Ime, z.Prezime, z.Email, z.Plata, z.KINO_Idkino, z.ADRESA_IdAdresa
                FROM `ZAPOSLENI` z
                INNER JOIN `KINO` k ON k.Idkino=z.KINO_IDkino
                INNER JOIN `ADRESA` a ON a.IdAdresa=z.ADRESA_IdAdresa
                WHERE IdZaposleni=@str
                ORDER BY Prezime, Ime";

        private static readonly string SELECT_JMB =
            @"SELECT JMB FROM `ZAPOSLENI`";


        private static readonly string INSERT =
            @"INSERT INTO zaposleni(JMB, Ime, Prezime, Email, Plata, KINO_Idkino, ADRESA_IdAdresa)
                VALUES (@JMB, @Ime, @Prezime, @Email, @Plata, @KINO_Idkino, @ADRESA_IdAdresa)";

        private static readonly string UPDATE =
            @"UPDATE `zaposleni` SET JMB=@JMB, Ime=@Ime, Prezime=@Prezime, Email=@Email, Plata=@Plata, KINO_Idkino = @KINO_IdKino, ADRESA_IdAdresa = @ADRESA_IdAdresa
                WHERE IdZaposleni=@IdZaposleni";

        private static readonly string DELETE =
            "DELETE FROM zaposleni WHERE IdZaposleni=@IdZaposleni";



        public static List<Zaposleni> GetZaposlene(string filter)
        {
            List<Zaposleni> result = new List<Zaposleni>();
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
                     result.Add(new Zaposleni()
                     {
                         IdZaposleni = reader.GetInt32(0),
                         Jmb = reader.GetString(1),
                         Ime = reader.GetString(2),
                         Prezime = reader.GetString(3),
                         Email = reader.GetString(4),
                         Plata = reader.GetInt32(5),
                         Kino = new Kino()
                         {
                             IdKino = reader.GetInt32(6),
                         },
                         Adresa = new Adresa()
                         {
                             IdAdresa = reader.GetInt32(7)
                         }
                     });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetZaposlene", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static Zaposleni GetZaposlenogById(string filter)
        {
            Zaposleni result = new Zaposleni();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_BY_ID;
                cmd.Parameters.AddWithValue("@str", filter);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new Zaposleni()
                    {
                        IdZaposleni = reader.GetInt32(0),
                        Jmb = reader.GetString(1),
                        Ime = reader.GetString(2),
                        Prezime = reader.GetString(3),
                        Email = reader.GetString(4),
                        Plata = reader.GetInt32(5),
                        Kino = new Kino()
                        {
                            IdKino = reader.GetInt32(6),
                        },
                        Adresa = new Adresa()
                        {
                            IdAdresa = reader.GetInt32(7)
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetZaposlenogById", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static List<Zaposleni> GetJmb()
        {
            List<Zaposleni> result = new List<Zaposleni>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_JMB;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Zaposleni()
                    {
                        Jmb = reader.GetString(0),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetJmb", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertZaposleni(Zaposleni zaposleni)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@JMB", zaposleni.Jmb);
                cmd.Parameters.AddWithValue("@Ime", zaposleni.Ime);
                cmd.Parameters.AddWithValue("@Prezime", zaposleni.Prezime);
                cmd.Parameters.AddWithValue("@Email", zaposleni.Email);
                cmd.Parameters.AddWithValue("@Plata", zaposleni.Plata);
                cmd.Parameters.AddWithValue("@KINO_Idkino", zaposleni.Kino.IdKino);
                cmd.Parameters.AddWithValue("@ADRESA_IdAdresa", zaposleni.Adresa.IdAdresa);
                cmd.ExecuteNonQuery();
                zaposleni.IdZaposleni = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertZaposleni", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateZaposleni(Zaposleni zaposleni)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdZaposleni", zaposleni.IdZaposleni);
                cmd.Parameters.AddWithValue("@JMB", zaposleni.Jmb);
                cmd.Parameters.AddWithValue("@Ime", zaposleni.Ime);
                cmd.Parameters.AddWithValue("@Prezime", zaposleni.Prezime);
                cmd.Parameters.AddWithValue("@Email", zaposleni.Email);
                cmd.Parameters.AddWithValue("@Plata", zaposleni.Plata);
                cmd.Parameters.AddWithValue("@KINO_Idkino", zaposleni.Kino.IdKino);
                cmd.Parameters.AddWithValue("@ADRESA_IdAdresa", zaposleni.Adresa.IdAdresa);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateZaposleni", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteZaposleniById(int IdZaposleni)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdZaposleni", IdZaposleni);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteZaposleniById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static int MaxIdZaposlenog() //poziv procedure!
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
                cmd.CommandText = "maxID_Zaposlenog";
                cmd.Parameters.AddWithValue("pMaxId", MySqlDbType.Int32);
                cmd.Parameters["@pMaxId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@pMaxId"].Value);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MaxIdZaposlenog", ex);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}
