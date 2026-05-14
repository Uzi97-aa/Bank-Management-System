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
   

    public class clsTransactionGroups
    {

        static public TransactionGroupsDTO FindByID(int GroupID)
        {

            try
            {
                using (SqlConnection Connection=new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command=new SqlCommand("sp_TransactionGroups_FindByID", Connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@GroupID", GroupID);
                        Connection.Open();
                        SqlDataReader Reader=Command.ExecuteReader();
                        if (Reader.Read())
                        
                            return MapReaderToADTO(Reader);
                        



                    }
                }
            }
            catch (Exception ex)
            {

            }

            return null;
        }

        public static int OpenTransactionGroup(TransactionGroupsDTO TGDTO)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_TransactionGroups_OpenTransactionGroup", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@Description", TGDTO.Description);
                        Command.Parameters.AddWithValue("@ExchangeRateID", TGDTO.ExchangeRateID);
                        Command.Parameters.AddWithValue("@CreatedByUserID", TGDTO.CreatedByUserID);
                        Command.Parameters.AddWithValue("@BranchID", TGDTO.BranchID);
                        Connection.Open();
                       return (int)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return -1;
            }
        }

        //public static bool CloseTransactionGroup(int GroupID, byte[] Row_Version)
        //{
        //    try
        //    {
        //        using (SqlConnection Connection = new SqlConnection(clsConnection.ConnectionString))
        //        {
        //            using (SqlCommand Command = new SqlCommand("sp_TransactionGroups_CloseTransactionGroup", Connection))
        //            {
        //                Command.CommandType = CommandType.StoredProcedure;
        //                Command.Parameters.AddWithValue("@GroupID", GroupID);
        //                Command.Parameters.AddWithValue("@Row_Version", Row_Version);
        //                Connection.Open();
        //                int rowsAffected = Command.ExecuteNonQuery();
        //                return rowsAffected > 0; // Return true if the update was successful
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exception (e.g., log it)
        //        return false;
        //    }
        //}

        static public bool PostTransactionGroup(int GroupID, byte[] Row_Version)
        {
            try
            {
                using (SqlConnection Connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_TransactionGroups_PostTransactionGroup", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@GroupID", GroupID);
                        Command.Parameters.AddWithValue("@Row_Version", Row_Version);
                        Connection.Open();
                        int rowsAffected = Command.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if the update was successful
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                return false;
            }
        }

        private static TransactionGroupsDTO MapReaderToADTO(SqlDataReader reader)
        {

            return new TransactionGroupsDTO
                (
                (int)reader["GroupID"],
                reader["Description"].ToString(),
                (byte)reader["Status"],
                (int)reader["ExchangeRateID"],
                (DateTime)reader["CreatedAt"],
                (int)reader["CreatedByUserID"],
                (int)reader["BranchID"],
                (byte[])reader["Row_Version"]
                );
        }

    }
}
