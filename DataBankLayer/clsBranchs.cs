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

  



    public class clsBranchs
    {

        static public BranchsDTO FindByID(int BranchID)
        {
            BranchsDTO branchsDTO = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Branches_FindByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BranchID", BranchID);
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        if (reader.Read())
                        {
                            branchsDTO = new BranchsDTO(
                                Convert.ToInt32(reader["BranchID"]),
                                reader["BranchName"].ToString(),
                                reader["Address"].ToString(),
                                reader["City"].ToString(),
                                reader["Country"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Handle exceptions (e.g., log the error)
                //Console.WriteLine("An error occurred: " + ex.Message);
            }
            return branchsDTO;
        }

        static public List<BranchsDTO> GetAllBranches()
        {
            List<BranchsDTO> branches = new List<BranchsDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Branches_GetAll", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                        while (reader.Read())
                        {
                            BranchsDTO branchsDTO = new BranchsDTO(
                                Convert.ToInt32(reader["BranchID"]),
                                reader["BranchName"].ToString(),
                                reader["Address"].ToString(),
                                reader["City"].ToString(),
                                reader["Country"].ToString()
                            );
                            branches.Add(branchsDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //// Handle exceptions (e.g., log the error)
                //Console.WriteLine("An error occurred: " + ex.Message);
            }
            return branches;


        }

        static public int AddBranch(BranchsDTO BDTO)
        {
            int newBranchID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Branches_Create", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BranchName", BDTO.BranchName);
                        Command.Parameters.AddWithValue("@Address", BDTO.Address);
                        Command.Parameters.AddWithValue("@City", BDTO.City);
                        Command.Parameters.AddWithValue("@Country", BDTO.Country);
                        connection.Open();
                        newBranchID = (int)Command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                //Console.WriteLine("An error occurred: " + ex.Message);
            }
            return newBranchID;

        }


        static public bool UpdateBranch(BranchsDTO BDTO)
        {
            bool isUpdated = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Branches_Update", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BranchID", BDTO.BranchID);
                        Command.Parameters.AddWithValue("@BranchName", BDTO.BranchName);
                        Command.Parameters.AddWithValue("@Address", BDTO.Address);
                        Command.Parameters.AddWithValue("@City", BDTO.City);
                        Command.Parameters.AddWithValue("@Country", BDTO.Country);
                        connection.Open();
                        int rowsAffected = Command.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
               // Console.WriteLine("An error occurred: " + ex.Message);
            }
            return isUpdated;

        }
        static public bool DeleteBranch(int BranchID)
        {
            bool isDeleted = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Branches_Delete", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@BranchID", BranchID);
                        connection.Open();
                        int rowsAffected = Command.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
              // Console.WriteLine("An error occurred: " + ex.Message);
            }
            return isDeleted;
        }

    }
}
