using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static SharedClass.clsShared;
namespace DataBankLayer
{

   


    public class clsCustomers
    {

        static public string ConnectionString = "Server=.,Database=BankSystem,Username=sa,Password=sa123456";

        static public List<CustomerDTO> GetAllCustomers()
        {
            List<CustomerDTO> customers = new List<CustomerDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand("sp_Customers_GetAll", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = Command.ExecuteReader();
                       
                        while (reader.Read())
                        {
                            string thirdName = reader["ThirdName"] == DBNull.Value ? "" : reader.GetString(reader.GetOrdinal("ThirdName"));

                            customers.Add(new CustomerDTO(reader.GetInt32(reader.GetOrdinal("CustomerID"))
                                , reader.GetString(reader.GetOrdinal("FirstName"))
                                , reader.GetString(reader.GetOrdinal("SecondName"))
                                , thirdName
                                , reader.GetString(reader.GetOrdinal("LastName"))
                                , reader.GetInt16(reader.GetOrdinal("Gender"))
                                , reader.GetDateTime(reader.GetOrdinal("DateOfBirth"))
                                , reader.GetString(reader.GetOrdinal("NationalID"))
                                , reader.GetString(reader.GetOrdinal("Email"))
                                , reader.GetString(reader.GetOrdinal("Phone"))
                                , reader.GetString(reader.GetOrdinal("Address"))
                                , reader.GetBoolean(reader.GetOrdinal("IsDeleted"))
                                , reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                                , (byte[])reader["Row_Version"]));
                        }

                        return customers;
                    }
                }
            }

            catch (Exception ex)
            {

            }
            return customers;

        }


        static public CustomerDTO GetCustomerByID(long CustomerID)
        {
            CustomerDTO customer = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_Customers_GetByID", connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                        connection.Open();
                        SqlDataReader reader = Command.ExecuteReader();
                       
                        if (reader.Read())
                        {
                            customer = new CustomerDTO(reader.GetInt32(reader.GetOrdinal("CustomerID"))
                                , reader.GetString(reader.GetOrdinal("FirstName"))
                                , reader.GetString(reader.GetOrdinal("SecondName"))
                                , reader.GetString(reader.GetOrdinal("ThirdName"))
                                , reader.GetString(reader.GetOrdinal("LastName"))
                                , reader.GetInt16(reader.GetOrdinal("Gender"))
                                , reader.GetDateTime(reader.GetOrdinal("DateOfBirth"))
                                , reader.GetString(reader.GetOrdinal("NationalID"))
                                , reader.GetString(reader.GetOrdinal("Email"))
                                , reader.GetString(reader.GetOrdinal("Phone"))
                                , reader.GetString(reader.GetOrdinal("Address"))
                                , reader.GetBoolean(reader.GetOrdinal("IsDeleted"))
                                , reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                                , (byte[])reader["Row_Version"]);

                        }
                    }
                }
            }

            catch (Exception ex)
            {
            }
            return customer;
        }


        static public int AddNewCustomer(CustomerDTO CTDO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Customers_Create", connection))
                    {
                        connection.Open();
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@FirstName", CTDO.FirstName);
                        Comand.Parameters.AddWithValue("@SecondName", CTDO.SecondName);
                        Comand.Parameters.AddWithValue("@ThirdName", CTDO.ThirdName);
                        Comand.Parameters.AddWithValue("@LastName", CTDO.LastName);
                        Comand.Parameters.AddWithValue("@Gender", CTDO.Gender);
                        Comand.Parameters.AddWithValue("@DateOfBirth", CTDO.DateOfBirth);
                        Comand.Parameters.AddWithValue("@NationalID", CTDO.NationalID);
                        Comand.Parameters.AddWithValue("@Phone", CTDO.Phone);
                        Comand.Parameters.AddWithValue("@Address", CTDO.Address);
                        Comand.Parameters.AddWithValue("@Email", CTDO.Email);

                        var outputIdParam = new SqlParameter("@CustomerID", SqlDbType.BigInt)
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

        static public bool UpdateCustomer(CustomerDTO CDTO)
        {
            int RowEffect = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Customers_Update", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@CustomerID", CDTO.CustomerID);
                        Comand.Parameters.AddWithValue("@Email", CDTO.Email);
                        Comand.Parameters.AddWithValue("@Phone", CDTO.Phone);
                        Comand.Parameters.AddWithValue("@Address", CDTO.Address);
                        Comand.Parameters.AddWithValue("@RowVersion", CDTO.Row_Version);

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


        static public bool DeleteCustomer(CustomerDTO CTDO)
        {
            int RowEffect = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand Comand = new SqlCommand("sp_Customers_Delete", connection))
                    {
                        Comand.CommandType = CommandType.StoredProcedure;
                        Comand.Parameters.AddWithValue("@CustomerID", CTDO.CustomerID);
                        Comand.Parameters.AddWithValue("@RowVersion", CTDO.Row_Version);
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

