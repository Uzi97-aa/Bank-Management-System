using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static SharedClass.clsShared;
namespace DataBankLayer
{
 


    public class clsCurrencies 
    {


        static public CurrenciesDTO Find(string CurrencyCode)
        {
           CurrenciesDTO currency = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_Currencies_GetByCode", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string symbol = reader["Symbol"].ToString();
                                bool isActive = Convert.ToBoolean(reader["IsActive"]);
                                currency = new CurrenciesDTO(CurrencyCode, name, symbol, isActive);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }
            return currency;
        }


        static public string AddCurrency(CurrenciesDTO CDTO)
        {
            int rowsAffected=0;

            string RowsAffected = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_Currencies_Add", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CurrencyCode", CDTO.CurrencyCode);
                        command.Parameters.AddWithValue("@Name", CDTO.Name);
                        command.Parameters.AddWithValue("@Symbol", CDTO.Symbol);
                        command.Parameters.AddWithValue("@IsActive", CDTO.IsActive);
                        rowsAffected = command.ExecuteNonQuery();
                        RowsAffected = rowsAffected.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }

            return RowsAffected;
        }


        public static bool UpdateCurrency(CurrenciesDTO CDTO)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_Currencies_Update", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CurrencyCode", CDTO.CurrencyCode);
                        command.Parameters.AddWithValue("@Name", CDTO.Name);
                        command.Parameters.AddWithValue("@Symbol", CDTO.Symbol);
                        command.Parameters.AddWithValue("@IsActive", CDTO.IsActive);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }
            return rowsAffected > 0;
        }

        static public List<CurrenciesDTO> GetAllCurrencies()
        {
            List<CurrenciesDTO> currencies = new List<CurrenciesDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Currencies_GetAll", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string currencyCode = reader["CurrencyCode"].ToString();
                                string name = reader["Name"].ToString();
                                string symbol = reader["Symbol"].ToString();
                                bool isActive = Convert.ToBoolean(reader["IsActive"]);
                                CurrenciesDTO currency = new CurrenciesDTO(currencyCode, name, symbol, isActive);
                                currencies.Add(currency);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }
            return currencies;
        }


        //static public CurrenciesDTO GetCurrencyByCode(string currencyCode)
        //{
        //    CurrenciesDTO currency = null;
        //    using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
        //    {
        //        connection.Open();
               
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;
        //            command.Parameters.AddWithValue("@CurrencyCode", currencyCode);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    string name = reader["Name"].ToString();
        //                    string symbol = reader["Symbol"].ToString();
        //                    bool isActive = Convert.ToBoolean(reader["IsActive"]);
        //                    currency = new CurrenciesDTO(currencyCode, name, symbol, isActive);
        //                }
        //            }
        //        }
        //    }
        //    return currency;


        //}

        static public bool DeactivateCurrency(string currencyCode)
        {
            int rowsAffected=0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Currencies_Delete", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                         rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                throw;
            }

           
        }
    }
}
