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
    class MySQLLice
    {

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CinemaDBApp"].ConnectionString;

        private static readonly string SELECT_INFO_LICE =
            @"SELECT IdLice, Ime, Prezime, Vrsta_angazmana
                FROM lice_info
                WHERE Ime LIKE @str";

        private static readonly string INSERT =
            @"INSERT INTO lice(Ime, Prezime)
                VALUES (@Ime, @Prezime)";

        private static readonly string DELETE =
            "DELETE FROM lice WHERE IdLice=@IdLice";

        private static readonly string UPDATE =
            @"UPDATE lice SET Ime=@Ime, Prezime=@Prezime
                WHERE IdLice=@IdLice";



        public static List<LiceInfo> GetLiceInfo(string filter)
        {
            List<LiceInfo> result = new List<LiceInfo>();
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_INFO_LICE;
                cmd.Parameters.AddWithValue("@str", filter + "%");
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new LiceInfo()
                    {
                        IdLice = reader.GetInt32(0),
                        Ime = reader.GetString(1),
                        Prezime = reader.GetString(2),
                        VrstaAngazmana = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in GetLiceInfo", ex);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return result;
        }

        public static void InsertLica(Lice lice)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Ime", lice.Ime);
                cmd.Parameters.AddWithValue("@Prezime", lice.Prezime);
                cmd.ExecuteNonQuery();
                lice.IdLice = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in InsertLica", ex);
            }
            finally
            {
                conn.Close();
            }
        }


        public static int MaxIdLica() //poziv procedure!
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
                cmd.CommandText = "maxID_Lica";
                cmd.Parameters.AddWithValue("pMaxId", MySqlDbType.Int32);
                cmd.Parameters["@pMaxId"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                result = Convert.ToInt32(cmd.Parameters["@pMaxId"].Value);
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MaxIdLica", ex);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public static void UpdateLice(Lice lice)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@IdLice", lice.IdLice);
                cmd.Parameters.AddWithValue("@Ime", lice.Ime);
                cmd.Parameters.AddWithValue("@Prezime", lice.Prezime);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in UpdateLice", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteLiceById(int IdLice)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@IdLice", IdLice);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in DeleteLiceById", ex);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
