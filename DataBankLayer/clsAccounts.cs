using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedClass;
using static SharedClass.clsShared;
namespace DataBankLayer
{

    

    
    public class clsAccounts
    {
      static  public AccountsDTO GetByID(int AccountID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_Accounts_GetAccountByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AccountID", AccountID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToDTO(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
            }
            return null;
        }

      static  public List<AccountsDTO> GetAll()
        {
            List<AccountsDTO> accounts = new List<AccountsDTO>();

            using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_Accounts_GetAllAccounts", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accounts.Add(MapReaderToDTO(reader));
                    }
                }
            }

            return accounts;
        }

      static  public int OpenAccount(AccountsDTO account)
        {
            int row = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_Accounts_OpenAccount", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CustomerID", account.CustomerID);
                        cmd.Parameters.AddWithValue("@BranchID", account.BranchID);
                        cmd.Parameters.AddWithValue("@AccountNumber", account.AccountNumber);
                        cmd.Parameters.AddWithValue("@AccountType", account.AccountType);
                        cmd.Parameters.AddWithValue("@CurrencyCode", account.CurrencyCode);
                        cmd.Parameters.AddWithValue("@Status", account.Status);
                        cmd.Parameters.AddWithValue("@IsDeleted", account.IsDeleted);

                        conn.Open();

                        // Get newly created ID
                        row= Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) 
            { 
            
            }
            return row;
        }


        static public bool UpdateStatus(AccountsDTO ADTO)
        {
            bool result = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Commad = new SqlCommand("sp_Accounts_UpdateStatus", connection))
                    {
                        Commad.CommandType = CommandType.StoredProcedure;

                        Commad.Parameters.AddWithValue("@AccountID", ADTO.AccountID);                        
                        Commad.Parameters.AddWithValue("@Status", ADTO.Status);                       
                        Commad.Parameters.AddWithValue("@Row_Version", ADTO.Row_Version);

                        connection.Open();
                        Commad.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return false;
            }
            return result;
        }

        //static  public bool Update(AccountsDTO ADTO)
        //  {
        //      bool result = false;
        //      try
        //      {
        //          using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
        //          {
        //              using (SqlCommand Commad = new SqlCommand("sp_Accounts_UpdateStatus", connection))
        //              {
        //                  Commad.CommandType = CommandType.StoredProcedure;

        //                  Commad.Parameters.AddWithValue("@AccountID", ADTO.AccountID);
        //                  Commad.Parameters.AddWithValue("@CustomerID", ADTO.CustomerID);
        //                  Commad.Parameters.AddWithValue("@BranchID", ADTO.BranchID);
        //                  Commad.Parameters.AddWithValue("@AccountNumber", ADTO.AccountNumber);
        //                  Commad.Parameters.AddWithValue("@AccountType", ADTO.AccountType);
        //                  Commad.Parameters.AddWithValue("@CurrencyCode", ADTO.CurrencyCode);
        //                  Commad.Parameters.AddWithValue("@Status", ADTO.Status);
        //                  Commad.Parameters.AddWithValue("@IsDeleted", ADTO.IsDeleted);
        //                  Commad.Parameters.AddWithValue("@Row_Version", ADTO.Row_Version);

        //                  connection.Open();
        //                  Commad.ExecuteNonQuery();
        //                  result=true;
        //              }
        //          }
        //      }
        //      catch (Exception ex)
        //      {
        //          // Handle exception (e.g., log it)
        //          return false;
        //      }
        //      return result;
        //  }

        //static public bool Delete(int AccountID)
        //{
        //    int row = -1;
        //    using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
        //    {
        //        using (SqlCommand Commad = new SqlCommand("sp_DeleteAccount", connection))
        //        {
        //            Commad.CommandType = CommandType.StoredProcedure;
        //            Commad.Parameters.AddWithValue("@AccountID", AccountID);

        //            connection.Open();
        //            row= Commad.ExecuteNonQuery();
        //        }
        //    }
        //    return row > -1;
        //}

        private static AccountsDTO MapReaderToDTO(SqlDataReader reader)
        {
            return new AccountsDTO(
                (int)reader["AccountID"],
                (int)reader["CustomerID"],
                (int)reader["BranchID"],
                reader["AccountNumber"].ToString(), 
                (byte)reader["AccountType"],
                reader["CurrencyCode"].ToString(),
                (byte)reader["Status"],
                (bool)reader["IsDeleted"], (DateTime)reader["CreatedAt"],
                (byte[])reader["Row_Version"]
            );
           
        }
    }


}

