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
    public class MySQLKarta
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT =
            @"SELECT k.IdKarta, k.DatumIVrijemeIzdavanja, k.RECEPCIONER_ZAPOSLENI_IdZaposleni, k.PROJEKCIJA_SALA_IdSala, k.PROJEKCIJA_FILM_IdFilm, k.PROJEKCIJA_DatumIVrijemePrikazivanja, k.SJEDISTE_BrojSjedista, k.SJEDISTE_RED_IdRed, p.Cijena
                FROM `KARTA` k
                INNER JOIN `PROJEKCIJA` p ON p.SALA_IdSala=k.PROJEKCIJA_SALA_IdSala AND p.DatumIVrijemePrikazivanja=k.PROJEKCIJA_DatumIVrijemePrikazivanja AND p.FILM_IdFilm=k.PROJEKCIJA_FILM_IdFilm
                WHERE k.DatumIVrijemeIzdavanja LIKE @str
                ORDER BY k.DatumIVrijemeIzdavanja DESC";

        private static readonly string SELECT_NO_FILTER =
            @"SELECT k.IdKarta, k.DatumIVrijemeIzdavanja, k.RECEPCIONER_ZAPOSLENI_IdZaposleni, k.PROJEKCIJA_SALA_IdSala, k.PROJEKCIJA_FILM_IdFilm, k.PROJEKCIJA_DatumIVrijemePrikazivanja, k.SJEDISTE_BrojSjedista, k.SJEDISTE_RED_IdRed, p.Cijena
                FROM `KARTA` k
                INNER JOIN `PROJEKCIJA` p ON p.SALA_IdSala=k.PROJEKCIJA_SALA_IdSala AND p.DatumIVrijemePrikazivanja=k.PROJEKCIJA_DatumIVrijemePrikazivanja AND p.FILM_IdFilm=k.PROJEKCIJA_FILM_IdFilm";

 
        private static readonly string INSERT =
            @"INSERT INTO KARTA(DatumIVrijemeIzdavanja, RECEPCIONER_ZAPOSLENI_IdZaposleni, PROJEKCIJA_SALA_IdSala, PROJEKCIJA_FILM_IdFilm, PROJEKCIJA_DatumIVrijemePrikazivanja, SJEDISTE_BrojSjedista, SJEDISTE_RED_IdRed)
                VALUES (@DatumIVrijemeIzdavanja, @RECEPCIONER_ZAPOSLENI_IdZaposleni, @PROJEKCIJA_SALA_IdSala, @PROJEKCIJA_FILM_IdFilm, @PROJEKCIJA_DatumIVrijemePrikazivanja, @SJEDISTE_BrojSjedista, @SJEDISTE_RED_IdRed)";

      
        private static readonly string DELETE =
            "DELETE FROM karta WHERE IdKarta=@IdKarta";


        public static List<Karta> GetKarte(string filter)
        {
            List<Karta> result = new List<Karta>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                if (filter != "")
                {
                    cmd.CommandText = SELECT;
                    cmd.Parameters.AddWithValue("@str", "%" + filter + "%");
                }
                else
                {
                    cmd.CommandText = SELECT_NO_FILTER;
                }
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Karta()
                    {
                        IdKarta = reader.GetInt32(0),
                        DatumIVrijemeIzdavanja = reader.GetDateTime(1),
                        RECEPCIONER_ZAPOSLENI_IdZaposleni = reader.GetInt32(2),
                        PROJEKCIJA_SALA_IdSala = reader.GetInt32(3),
                        PROJEKCIJA_FILM_IdFilm = reader.GetInt32(4),
                        PROJEKCIJA_DatumIVrijemePrikazivanja = reader.GetDateTime(5),
                        SJEDISTE_BrojeSjedista = reader.GetInt32(6),
                        SJEDISTE_RED_IdRed = reader.GetInt32(7),
                        Cijena = reader.GetDecimal(8)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetKarte", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }


        public static void InsertKarta(Karta karta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@DatumIVrijemeIzdavanja", karta.DatumIVrijemeIzdavanja);
                cmd.Parameters.AddWithValue("@RECEPCIONER_ZAPOSLENI_IdZaposleni", karta.RECEPCIONER_ZAPOSLENI_IdZaposleni);
                cmd.Parameters.AddWithValue("@PROJEKCIJA_SALA_IdSala", karta.PROJEKCIJA_SALA_IdSala);
                cmd.Parameters.AddWithValue("@PROJEKCIJA_FILM_IdFilm", karta.PROJEKCIJA_FILM_IdFilm);
                cmd.Parameters.AddWithValue("@PROJEKCIJA_DatumIVrijemePrikazivanja", karta.PROJEKCIJA_DatumIVrijemePrikazivanja);
                cmd.Parameters.AddWithValue("@SJEDISTE_BrojSjedista", karta.SJEDISTE_BrojeSjedista);
                cmd.Parameters.AddWithValue("@SJEDISTE_RED_IdRed", karta.SJEDISTE_RED_IdRed);

                cmd.ExecuteNonQuery();
                karta.IdKarta = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertKarte", ex);
            }
            finally
            {
                conn.Close();
            }
        }
  

        public static void DeleteKartaById(int IdKarta)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdKarta", IdKarta);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteKarteById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static string[] Izvjestaj()
        {
            string[] result = new string[] { "", ""};
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "izvjestaj";
                cmd.Parameters.AddWithValue("pBrojKarata", MySqlDbType.Int32);
                cmd.Parameters["pBrojKarata"].Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("pUkupnaCijena", MySqlDbType.Decimal);
                cmd.Parameters["pUkupnaCijena"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result[0] = cmd.Parameters["pBrojKarata"].Value.ToString(); 
                result[1] = cmd.Parameters["pUkupnaCijena"].Value.ToString();
            }
            catch(Exception ex)
            {
                throw new DataAccessException("Exception in Izvjestaj!");
            }
            finally
            {
                conn.Close();
            }

            return result;

        }

        public static int Izdata(Karta k)
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
                cmd.CommandText = "izdata";
                cmd.Parameters.AddWithValue("pSala", k.PROJEKCIJA_SALA_IdSala);
                cmd.Parameters["pSala"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("pFilm", k.PROJEKCIJA_FILM_IdFilm);
                cmd.Parameters["pFilm"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("pDatumPrikazivanja", k.PROJEKCIJA_DatumIVrijemePrikazivanja);
                cmd.Parameters["pDatumPrikazivanja"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("pSjediste", k.SJEDISTE_BrojeSjedista);
                cmd.Parameters["pSjediste"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("pRed", k.SJEDISTE_RED_IdRed);
                cmd.Parameters["pRed"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("pIzdata", MySqlDbType.Int32);
                cmd.Parameters["pIzdata"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = (int)(cmd.Parameters["pIzdata"].Value);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in Izvjestaj!");
            }
            finally
            {
                conn.Close();
            }

            return result;

        }


    }
}
