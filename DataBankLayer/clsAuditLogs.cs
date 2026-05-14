using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SharedClass;
using static SharedClass.clsShared;
namespace DataBankLayer
{

   


    public class clsAuditLogs
    {

        static public string ConnectionString = "Server=.,Database=BankSystem,Username=sa,Password=sa123456";

        static public int CreateAuditLog(AuditLogDTO ALDTO)
        {
            int RowEffected = 0;
            try
            {
                using (SqlConnection connection=new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command=new SqlCommand("sp_AuditLogs_Insert", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", ALDTO.UserID);
                        command.Parameters.AddWithValue("@ActionType", ALDTO.ActionType);
                        command.Parameters.AddWithValue("@EntityTypeID", ALDTO.EntityTypeID);
                        command.Parameters.AddWithValue("@EntityID", ALDTO.EntityID);
                        command.Parameters.AddWithValue("@OldValue", ALDTO.OldValue);
                        command.Parameters.AddWithValue("@NewValue", ALDTO.NewValue);
                        command.Parameters.AddWithValue("@IPAddress", ALDTO.IPAddress);



                        var outputIdParam = new SqlParameter("@LogID", SqlDbType.BigInt)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);

                        connection.Open();

                        RowEffected = command.ExecuteNonQuery();

                        return RowEffected;
                    }
                }


            }
            catch 
            { 

            }
            return RowEffected;

        }


    }
}
