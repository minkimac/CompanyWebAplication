using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataAccess : GlobalConnection
    {
        private const int TIMEOUTINTERVAL = 580;

        public static int ExecuteNonQuery(CommandType cmdType, string CommandText)
        {
            int noOfRowsAffected = -1;
            using (SqlConnection connection = new SqlConnection(getConnectionString))
            {
                SqlTransaction _transaction = null;
                try
                {
                    _transaction = connection.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(CommandText, connection, _transaction);
                    cmd.CommandType = cmdType;
                    cmd.CommandText = CommandText;

                    connection.Open();
                    noOfRowsAffected = cmd.ExecuteNonQuery();
                    _transaction.Commit();

                }

                catch (Exception)
                {
                    _transaction.Rollback();
                    throw;
                }
            }
            return noOfRowsAffected;
        }

        public static int ExecuteNonQuery(CommandType cmdType, string commandText, params SqlParameter[] sqlParameters)
        {
            int noOfRowsAffected = -1;
            using (SqlConnection connection = new SqlConnection(getConnectionString))
            {
                SqlTransaction _transaction = null;
                try
                {
                    _transaction = connection.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(commandText, connection, _transaction);
                    cmd.CommandType = cmdType;
                    cmd.CommandText = commandText;
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

                catch (Exception)
                {
                    _transaction.Rollback();
                    throw;
                }
            }
            return noOfRowsAffected;
        }
        public static DataTable ExecuteDataTable( string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con = new SqlConnection(getConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                SqlDataAdapter sqlDataAdapter = null;
                con.Open();
                sqlCommand = new SqlCommand(commandText, con);
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandTimeout = TIMEOUTINTERVAL;
                //Add SQL Parameters
                foreach (SqlParameter para in sqlParameters)
                {
                    sqlCommand.Parameters.Add(para);
                }
                //Initialize DataAdapter using SQL command
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //Fill DataSet
                sqlDataAdapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataSet ExecuteDataSet( string commandText, CommandType commandType, bool isTimeOutRequired, params SqlParameter[] sqlParameters)
        {
            DataSet resultdataSet = new DataSet();
            if (isTimeOutRequired)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(getConnectionString))
                    {
                        SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
                        sqlCommand.CommandType = commandType;
                        sqlCommand.CommandTimeout = TIMEOUTINTERVAL;
                        foreach (SqlParameter para in sqlParameters)
                        {
                            sqlCommand.Parameters.Add(para);
                        }
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.Fill(resultdataSet);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                resultdataSet = ExecuteDataSet( commandText, commandType, sqlParameters);
            }
            return resultdataSet;
        }

        
        public static DataSet ExecuteDataSet(string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataSet resultdataSet = new DataSet();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(getConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
                    sqlCommand.CommandType = commandType;
                    sqlCommand.CommandTimeout = TIMEOUTINTERVAL;
                    foreach (SqlParameter para in sqlParameters)
                    {
                        sqlCommand.Parameters.Add(para);
                    }
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.Fill(resultdataSet);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return resultdataSet;
        }

        
        public static object ExecuteScalar(string spName, CommandType cmdType, params SqlParameter[] sqlParameters)
        {
            object obj = null;
            using (SqlConnection connection = new SqlConnection(getConnectionString))
            {
                SqlTransaction _transaction = null;
                try
                {
                    _transaction = connection.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(spName, connection, _transaction);
                    cmd.CommandType = cmdType;
                    cmd.CommandText = spName;
                    if (sqlParameters != null)
                    {
                        foreach (SqlParameter para in sqlParameters)
                        {
                            cmd.Parameters.Add(para);
                        }
                    }
                    connection.Open();
                    obj = cmd.ExecuteScalar();
                    _transaction.Commit();
                }
                catch (Exception)
                {
                    _transaction.Rollback();
                    throw;
                }
            }
            return obj;
        }

        public static int ExecuteNonQuery(string spName, int IsTimeOutRequired, CommandType cmdtype, params SqlParameter[] sqlParameters)
        {
            int noOfRowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(getConnectionString))
            {
                SqlTransaction _transaction = null;
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

                catch (Exception)
                {
                    _transaction.Rollback();
                    throw;
                }
            }
            return noOfRowsAffected;
        }

        

    }
}
