using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;

namespace DataBankLayer
{

   

    public class clsUsers
    {

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
                {
                    conn.Open();
                    
                    using (SqlCommand cmd = new SqlCommand("sp_Users_GetAllUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                // Console.WriteLine("Error fetching balances: " + ex.Message);
            }
            return dt;
        }
        static public List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("sp_Users_GetAllUser", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int? customerID = reader.IsDBNull(reader.GetOrdinal("CustomerID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CustomerID"));
                                int? employeeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("EmployeeID"));

                                UserDTO user = new UserDTO(
                                       reader.GetInt32(reader.GetOrdinal("UserID")),
                                        Convert.ToInt32(reader["CustomerID"]),
                                        reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                        reader["UserName"].ToString(),
                                        reader["PasswordHash"].ToString(),
                                        reader.GetByte(reader.GetOrdinal("Role")),
                                        reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                        reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                        reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
                                        (byte[])reader["Row_Version"]

                                    );
                                users.Add(user);
                            }
                            return users;
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
                return users; // Return an empty list in case of error
            }


        }


        static public UserDTO GetUserByID(int UserID)
        {
            UserDTO User = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Users_GetByUserID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                  return MapReaderToDTO(reader);
                            }
                            return null;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
                return User; // Return null in case of error
            }
        }



        static public UserDTO GetUserByUserName(string UserName)
        {
            UserDTO User = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Users_GetByUserName", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@UserName", UserName);
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                return MapReaderToDTO(reader);
                            }
                            return null;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
                return User; // Return null in case of error
            }
        }





        // GetUserByUserNameAndPassword
        static public UserDTO GetUserByUserNameAndPassword(string UserName, string Password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_Users_GetByUserNameAndPassword", connection))
                {
                    connection.Open();
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password", Password);

                    SqlDataReader reader = Command.ExecuteReader();
                    {
                        if (reader.Read())
                        {
                            return MapReaderToDTO(reader);
                        }
                            
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                // log and rethrow or return null according to your policy
                return null;
            }
        }




        static public int AddNewUser(UserDTO UDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Users_Create", connection))
                    {
                        connection.Open();


                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@CustomerID", UDTO.CustomerID ?? (object)DBNull.Value);
                        Comand.Parameters.AddWithValue("@EmployeeID", UDTO.EmployeeID ?? (object)DBNull.Value);
                        Comand.Parameters.AddWithValue("@UserName", UDTO.UserName);
                        Comand.Parameters.AddWithValue("@PasswordHash", UDTO.PasswordHash);
                        Comand.Parameters.AddWithValue("@Role", UDTO.Role);
                        var outputIdParam = new SqlParameter("@UserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Comand.Parameters.Add(outputIdParam);

                       

                        RowEffect = Comand.ExecuteNonQuery();

                        return RowEffect;

                    }
                }
            }

            catch (Exception ex)
            {


            }
            return RowEffect;

        }



        static public bool UpdateUser(UserDTO UDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Users_Update", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@UserID", UDTO.UserID);
                        Comand.Parameters.AddWithValue("@PasswordHash", UDTO.PasswordHash);
                        Comand.Parameters.AddWithValue("@RowVersion", UDTO.Row_Version);
                        connection.Open();
                        RowEffect = Comand.ExecuteNonQuery();


                    }
                }
            }
            
            catch (SqlException ex)
            {
                // Handle exception (e.g., log it)
                 Console.WriteLine("An error occurred: " + ex.Errors.ToString());
            }
            return RowEffect > 0;
        }


        static public bool DeleteUser(UserDTO UDTO)
        {
            int RowEffect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Users_Disable", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@UserID", UDTO.UserID);
                        connection.Open();
                        RowEffect = Comand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
            }
            return RowEffect > 0;


        }


        // MapReaderToDTO with null checks
        private static UserDTO MapReaderToDTO(SqlDataReader reader)
        {
            int userId = reader.GetInt32(reader.GetOrdinal("UserID"));
            int? customerId = reader.IsDBNull(reader.GetOrdinal("CustomerID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CustomerID"));
            int? employeeId = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("EmployeeID"));
            string userName = reader["UserName"]?.ToString();
            string pwdHash = reader["PasswordHash"]?.ToString();
            byte role = reader.GetByte(reader.GetOrdinal("Role"));
            bool isDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted"));
            bool isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
            DateTime createdAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"));
            byte[] rowVersion = reader.IsDBNull(reader.GetOrdinal("Row_Version")) ? null : (byte[])reader["Row_Version"];

            return new UserDTO(userId, customerId, employeeId, userName, pwdHash, role, isDeleted, isActive, createdAt, rowVersion);
        }
    }


}

