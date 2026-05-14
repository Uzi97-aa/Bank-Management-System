using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace DataBankLayer
{
   

    public class clsExchangeRates
    {

        public static List<ExchangeRateDTO> GetLatest(string fromCurrencyCode, string toCurrencyCode)
        {
            List<ExchangeRateDTO> list = new List<ExchangeRateDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_GetLatest", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FromCurrencyCode", fromCurrencyCode);
                        command.Parameters.AddWithValue("@ToCurrencyCode", toCurrencyCode);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            list.Add(new ExchangeRateDTO(
                                reader.GetInt32(reader.GetOrdinal("RateID")),
                                reader.GetString(reader.GetOrdinal("FromCurrencyCode")),
                                reader.GetString(reader.GetOrdinal("ToCurrencyCode")),
                                reader.GetDouble(reader.GetOrdinal("Rate")),
                                reader.GetDateTime(reader.GetOrdinal("EffectiveDate")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return list;
        }



        public static List<ExchangeRateDTO> GetByPair(string fromCurrencyCode, string toCurrencyCode)
        {
            List<ExchangeRateDTO> list = new List<ExchangeRateDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_GetByPair", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FromCurrencyCode", fromCurrencyCode);
                        command.Parameters.AddWithValue("@ToCurrencyCode", toCurrencyCode);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            list.Add(new ExchangeRateDTO(
                                reader.GetInt32(reader.GetOrdinal("RateID")),
                                reader.GetString(reader.GetOrdinal("FromCurrencyCode")),
                                reader.GetString(reader.GetOrdinal("ToCurrencyCode")),
                                reader.GetDouble(reader.GetOrdinal("Rate")),
                                reader.GetDateTime(reader.GetOrdinal("EffectiveDate")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return list;
        }



        // 🔹 Get All
        public static List<ExchangeRateDTO> GetAll()
        {
            List<ExchangeRateDTO> list = new List<ExchangeRateDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_GetAll", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            list.Add(new ExchangeRateDTO(
                                reader.GetInt32(reader.GetOrdinal("RateID")),
                                reader.GetString(reader.GetOrdinal("FromCurrencyCode")),
                                reader.GetString(reader.GetOrdinal("ToCurrencyCode")),
                                reader.GetDouble(reader.GetOrdinal("Rate")),
                                reader.GetDateTime(reader.GetOrdinal("EffectiveDate")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return list;
        }

        // 🔹 Get By ID
        public static ExchangeRateDTO GetByID(int rateID)
        {
            ExchangeRateDTO item = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_GetByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@RateID", rateID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            item = new ExchangeRateDTO(
                                reader.GetInt32(reader.GetOrdinal("RateID")),
                                reader.GetString(reader.GetOrdinal("FromCurrencyCode")),
                                reader.GetString(reader.GetOrdinal("ToCurrencyCode")),
                                reader.GetDouble(reader.GetOrdinal("Rate")),
                                reader.GetDateTime(reader.GetOrdinal("EffectiveDate")),
                                reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return item;
        }

        // 🔹 Add
        public static int Add(ExchangeRateDTO EDTO)
        {
            int rows = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_Create", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var newIDParam = new SqlParameter("@RateID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        command.Parameters.Add(newIDParam);

                        command.Parameters.AddWithValue("@FromCurrencyCode", EDTO.FromCurrencyCode);
                        command.Parameters.AddWithValue("@ToCurrencyCode", EDTO.ToCurrencyCode);
                        command.Parameters.AddWithValue("@Rate", EDTO.Rate);
                        command.Parameters.AddWithValue("@EffectiveDate", EDTO.EffectiveDate);

                        connection.Open();
                        rows = command.ExecuteNonQuery();
                       
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return rows;
        }

        // 🔹 Update
        public static bool Update(ExchangeRateDTO EDTO)
        {
            int rows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_Update", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RateID", EDTO.RateID);
                        command.Parameters.AddWithValue("@Rate", EDTO.Rate);
                        command.Parameters.AddWithValue("@EffectiveDate", EDTO.EffectiveDate);
                        

                        connection.Open();
                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return rows > 0;
        }

        // 🔹 Delete
        public static bool Delete(int rateID)
        {
            int rows = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_ExchangeRates_Delete", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RateID", rateID);
                        

                        connection.Open();
                        rows = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return rows > 0;
        }
    }
}
