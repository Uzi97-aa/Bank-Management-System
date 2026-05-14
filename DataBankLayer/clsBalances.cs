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

 
    public class clsBalances
    {


        static public List<BalanceDTO> GetBalances()
        {
            List<BalanceDTO> balances = new List<BalanceDTO>();

            try
            {
                using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
                {
                    conn.Open();
                    string query = @"SELECT [AccountID]
                                  ,[AccountNumber]
                                  ,[CurrencyCode]
                                  ,[balance]
                              FROM [dbo].[account_balances]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int accountId = reader.GetInt32(reader.GetOrdinal("AccountID"));
                                string accountNumber = reader.GetString(reader.GetOrdinal("AccountNumber"));
                                string currencyCode = reader.GetString(reader.GetOrdinal("CurrencyCode"));
                                decimal balance = reader.GetDecimal(reader.GetOrdinal("balance"));
                                balances.Add(new BalanceDTO(accountId, accountNumber, currencyCode, balance));
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
              //  Console.WriteLine("Error fetching balances: " + ex.Message);
            }
            return  balances;
        }


    }
}
