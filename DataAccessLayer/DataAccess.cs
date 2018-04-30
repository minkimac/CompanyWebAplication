using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess: GlobalConnection
    {
        public int ExecuteNonQuery(string spName,int IsTimeOutRequired,CommandType cmdtype, params SqlParameter[] sqlParameters)
        { int noOfRowsAffected=0;

            using (SqlConnection connection = new SqlConnection(getConnectionString))
            {
                SqlTransaction _transaction=null;
                try
                {
                    _transaction = connection.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(spName, connection, _transaction);
                    cmd.CommandType = cmdtype;
                    cmd.CommandText = spName;
                    if (sqlParameters != null)
                    {
                        foreach (SqlParameter para in sqlParameters)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    connection.Open();
                    noOfRowsAffected = cmd.ExecuteNonQuery();
                    _transaction.Commit();

                }

                catch (Exception e)
                {
                    _transaction.Rollback();
                    throw;
                }
            }
            return noOfRowsAffected;
        }

        public DataSet ExecuteReader()
        {
        }
    }
}
