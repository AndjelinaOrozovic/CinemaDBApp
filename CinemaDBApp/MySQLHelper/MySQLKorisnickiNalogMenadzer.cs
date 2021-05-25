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
    class MySQLKorisnickiNalogMenadzer
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT_MENADZER_LOGIN =
            @"SELECT k.IdKorisnickiNalog, k.KorisnickoIme, k.Lozinka, z.IdZaposleni
                FROM korisnicki_nalog k
                INNER JOIN `ZAPOSLENI` z ON z.IdZaposleni=k.ZAPOSLENI_IdZaposleni
                INNER JOIN `MENADZER` m ON m.ZAPOSLENI_IdZaposleni=z.IdZaposleni
                WHERE k.KorisnickoIme LIKE @str";

        private static readonly string SELECT_MENADZER_USERNAME =
            @"SELECT k.IdKorisnickiNalog, k.KorisnickoIme, k.Lozinka, z.IdZaposleni
                FROM korisnicki_nalog k
                INNER JOIN `ZAPOSLENI` z ON z.IdZaposleni=k.ZAPOSLENI_IdZaposleni
                INNER JOIN `MENADZER` m ON m.ZAPOSLENI_IdZaposleni=z.IdZaposleni
                WHERE k.KorisnickoIme LIKE @str";

     
        public static List<KorisnickiNalog> GetKorisnickeNaloge(string filter)
        {
            List<KorisnickiNalog> result = new List<KorisnickiNalog>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_MENADZER_LOGIN;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new KorisnickiNalog()
                    {
                        IdKorisnickiNalog = reader.GetInt32(0),
                        KorisnickoIme = reader.GetString(1),
                        Lozinka = reader.GetString(2),
                        Zaposleni = new Zaposleni()
                        {
                            IdZaposleni = reader.GetInt32(3),
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKorisnickeNaloge", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static KorisnickiNalog GetKorisnickiNalogByUsername(string filter)
        {
            KorisnickiNalog result = new KorisnickiNalog();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_MENADZER_USERNAME;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = new KorisnickiNalog()
                    {
                        IdKorisnickiNalog = reader.GetInt32(0),
                        KorisnickoIme = reader.GetString(1),
                        Lozinka = reader.GetString(2),
                        Zaposleni = new Zaposleni()
                        {
                            IdZaposleni = reader.GetInt32(3),
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKorisnickiNalogByUsername", ex);
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
