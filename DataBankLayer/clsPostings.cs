using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using static SharedClass.clsShared;
namespace DataBankLayer
{

   
    public class clsPostings
    {

        static public PostingsDTO FindByID(int PostingID)
        {
            PostingsDTO postingsDTO = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Postings_FindByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PostingID", PostingID);
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        if (reader.Read())
                        {
                            postingsDTO = new PostingsDTO(

                                Convert.ToInt32(reader["PostingID"]),
                                Convert.ToInt32(reader["GroupID"]),
                                Convert.ToInt32(reader["AccountID"]),
                                Convert.ToByte(reader["TransactionType"]),
                                Convert.ToDecimal(reader["Amount"]),
                                reader["Reference"].ToString(),
                                reader["Reversal_Of_PostingID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Reversal_Of_PostingID"]),
                                Convert.ToDateTime(reader["CreatedAt"]),
                                (byte[])reader["Row_Version"]
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }


            return postingsDTO;

        }

        static public List<PostingsDTO> GetPostingsByGroupID(int GroupID)
        {
            List<PostingsDTO> postingsList = new List<PostingsDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Postings_GetByGroupID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@GroupID", GroupID);
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        if (reader.Read())
                        {
                            PostingsDTO posting = new PostingsDTO(
                                Convert.ToInt32(reader["PostingID"]),
                                Convert.ToInt32(reader["GroupID"]),
                                Convert.ToInt32(reader["AccountID"]),
                                Convert.ToByte(reader["TransactionType"]),
                                Convert.ToDecimal(reader["Amount"]),
                                reader["Reference"].ToString(),
                                reader["Reversal_Of_PostingID"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["Reversal_Of_PostingID"]),
                                Convert.ToDateTime(reader["CreatedAt"]),
                                (byte[])reader["Row_Version"]
                            );
                            postingsList.Add(posting);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return postingsList;





        }


        static public int AddPosting(PostingsDTO posting)
        {
            int newPostingID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Postings_AddPosting", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@GroupID", posting.GroupID);
                        Command.Parameters.AddWithValue("@AccountID", posting.AccountID);
                        Command.Parameters.AddWithValue("@TransactionType", posting.TransactionType);
                        Command.Parameters.AddWithValue("@Amount", posting.Amount);
                        if (string.IsNullOrEmpty(posting.Reference))
                            Command.Parameters.AddWithValue("@Reference",DBNull.Value);
                        else
                            Command.Parameters.AddWithValue("@Reference", posting.Reference);
                        if (posting.Reversal_Of_PostingID.HasValue)                       
                            Command.Parameters.AddWithValue("@Reversal_Of_PostingID", posting.Reversal_Of_PostingID);
                        else
                            Command.Parameters.AddWithValue("@Reversal_Of_PostingID", DBNull.Value);
                        connection.Open();
                        newPostingID = Convert.ToInt32(Command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return newPostingID;
        }
    }
}
