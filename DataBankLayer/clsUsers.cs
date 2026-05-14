using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace DataBankLayer
{

   

    public class clsUsers
    {
        static public string ConnectionString = "Server=.,Database=BankSystem,Username=sa,Password=sa123456";

        static public List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Users_GetAllUser", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int? customerID = reader.IsDBNull(reader.GetOrdinal("CustomerID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("CustomerID"));
                                int? employeeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("EmployeeID"));

                                UserDTO user = new UserDTO(
                                        reader.GetInt32(reader.GetOrdinal("UserID")),
                                        customerID,
                                        employeeID,
                                        reader["UserName"].ToString(),
                                        reader["PasswordHash"].ToString(),
                                        reader.GetByte(reader.GetOrdinal("Role")),
                                        reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                        reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                                        
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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                                User = new UserDTO(
                                    reader.GetInt32(reader.GetOrdinal("UserID")),
                                        Convert.ToInt32(reader["CustomerID"]),
                                        reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                        reader["UserName"].ToString(),
                                        reader["PasswordHash"].ToString(),
                                        reader.GetByte(reader.GetOrdinal("Role")),
                                        reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                                        reader.GetDateTime(reader.GetOrdinal("CreatedAt"))

                                );
                            }
                            return User;
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




        static public int AddNewUser(UserDTO UDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Employees_Create", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@CustomerID", UDTO.CustomerID);
                        Comand.Parameters.AddWithValue("@EmployeeID", UDTO.EmployeeID);
                        Comand.Parameters.AddWithValue("@UserName", UDTO.UserName);
                        Comand.Parameters.AddWithValue("@PasswordHash", UDTO.PasswordHash);
                        Comand.Parameters.AddWithValue("@Role", UDTO.Role);
                        var outputIdParam = new SqlParameter("@UserID", SqlDbType.BigInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Comand.Parameters.Add(outputIdParam);

                        connection.Open();

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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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


    }
}
