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


   
    public class clsEntityTypes
    {

        static public short AddNewEntityTypes(short TableName)
        {
            short RowEffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("sp_AuditLogs_Insert", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TableName", TableName);
                        connection.Open();

                        RowEffected=(short)command.ExecuteNonQuery();

                        return RowEffected;
                    }

                }
            }
            catch (Exception ex) { }
            return RowEffected;
            }
    }
}

