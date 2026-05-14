using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static SharedClass.clsShared;
namespace DataBankLayer
{

    
    public class clsEmployee
    {
        static public string ConnectionString = "Server=.,Database=BankSystem,Username=sa,Password=sa123456";


        static public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> employees = new List<EmployeeDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Employees_GetAll", connection))
                    {

                        Command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                int? BranchIDValue = reader.IsDBNull(reader.GetOrdinal("BranchID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("BranchID"));

                                EmployeeDTO employee = new EmployeeDTO(
                                        reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                        BranchIDValue,
                                        reader["FirstName"].ToString(),
                                        reader["LastName"].ToString(),
                                        reader["JobTitle"].ToString(),
                                        reader["Email"].ToString(),
                                        reader["Phone"].ToString(),
                                        Convert.ToDateTime(reader["HireDate"]),
                                        Convert.ToInt16(reader["Status"]),
                                        Convert.ToBoolean(reader["IsDeleted"]),
                                        Convert.ToDateTime(reader["CreatedAt"]),
                                        (byte[])reader["Row_Version"]
                                    );
                                employees.Add(employee);
                            }
                            return employees;
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
                return employees; // Return an empty list in case of error
            }


        }


        static public EmployeeDTO GetEmployeeByID(int employeeID)
        {
            EmployeeDTO employee = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Employees_GetByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        connection.Open();
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employee = new EmployeeDTO(
                                    reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                    Convert.ToInt32(reader["BranchID"]),
                                    reader["FirstName"].ToString(),
                                    reader["LastName"].ToString(),
                                    reader["JobTitle"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Phone"].ToString(),
                                    Convert.ToDateTime(reader["HireDate"]),
                                    Convert.ToInt16(reader["Status"]),
                                    Convert.ToBoolean(reader["IsDeleted"]),
                                    Convert.ToDateTime(reader["CreatedAt"]),
                                    (byte[])reader["Row_Version"]

                                );
                            }
                            return employee;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log it)
                // Console.WriteLine("An error occurred: " + ex.Message);
                return employee; // Return null in case of error
            }
        }




        static public int AddNewEmployee(EmployeeDTO EDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Employees_Create", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@BranchID", EDTO.BranchID);
                        Comand.Parameters.AddWithValue("@FirstName", EDTO.FirstName);
                        Comand.Parameters.AddWithValue("@LastName", EDTO.LastName);
                        Comand.Parameters.AddWithValue("@JobTitle", EDTO.JobTitle);
                        Comand.Parameters.AddWithValue("@Email", EDTO.Email);
                        Comand.Parameters.AddWithValue("@Phone", EDTO.Phone);
                        Comand.Parameters.AddWithValue("@HireDate", EDTO.HireDate);
                        var outputIdParam = new SqlParameter("@EmployeeID", SqlDbType.Int)
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



        static public bool UpdateEmployee(EmployeeDTO EDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Employees_Update", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@EmployeeID", EDTO.EmployeeID);
                        Comand.Parameters.AddWithValue("@JobTitle", EDTO.JobTitle);
                        Comand.Parameters.AddWithValue("@Status", EDTO.Status);
                        Comand.Parameters.AddWithValue("@IsDeleted", EDTO.IsDeleted);
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


        static public bool DeleteEmployee(EmployeeDTO EDTO)
        {
            int RowEffect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Employees_Delete", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@EmployeeID", EDTO.EmployeeID);
                        Comand.Parameters.AddWithValue("@RowVersion", EDTO.Row_Version);
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
