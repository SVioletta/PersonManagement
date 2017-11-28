using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlHelper
    {
        //从配置中读取数据库连接字符串
        private static string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        #region 执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数，默认使用sql语句操作
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] args)
        {
            return ExecuteNonQuery(cmdText, CommandType.Text, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数，CommandType可指定使用存储过程
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, CommandType type, params SqlParameter[] args)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    if (args != null)
                    {
                        foreach (SqlParameter parameter in args)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    cmd.CommandType = type;
                    try
                    {
                        con.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        con.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数，默认使用sql语句操作，需指定CommandTimeout超时时间
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, int time, params SqlParameter[] args)
        {
            return ExecuteNonQuery(cmdText, CommandType.Text, time, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数，CommandType可指定使用存储过程，time可指定等待命令执行的超时时间（以秒为单位 / 默认值为 30 秒）
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string cmdText, CommandType type, int time, params SqlParameter[] args)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    if (args != null)
                    {
                        foreach (SqlParameter parameter in args)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    cmd.CommandType = type;
                    try
                    {
                        con.Open();
                        //CommandTimeout设置值 0 指没有限制 (尝试执行命令将无限期等待)。
                        cmd.CommandTimeout = time;
                        return cmd.ExecuteNonQuery();
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        con.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回操作影响的记录条数，格式复杂的文章，有特殊符号，可以通过这个方式添加。例：insert into T_Table (字段名) values (@content)
        /// </summary>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlString, string content)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                var cmd = new SqlCommand(sqlString, con);
                var parameter = new SqlParameter("@content", SqlDbType.NText) {Value = content};
                cmd.Parameters.Add(parameter);
                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (SqlException e)
                {
                    throw e;
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }
        }

        #endregion

        #region 执行SQL语句对数据库的记录进行操作，返回首行首列

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回首行首列，默认使用sql语句操作
        /// </summary>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, params SqlParameter[] args)
        {
            return ExecuteScalar(cmdText, CommandType.Text, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回首行首列，CommandType可指定使用存储过程
        /// </summary>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, CommandType type, params SqlParameter[] args)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    if (args != null)
                    {
                        foreach (SqlParameter parameter in args)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    cmd.CommandType = type;
                    try
                    {
                        con.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        con.Close();
                        throw e;
                    }
                }
            }
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回首行首列，默认使用sql语句操作，需指定CommandTimeout超时时间
        /// </summary>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText,int time ,params SqlParameter[] args)
        {
            return ExecuteScalar(cmdText, CommandType.Text, time, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回首行首列，CommandType可指定使用存储过程，，time可指定等待命令执行的超时时间（以秒为单位 / 默认值为 30 秒）
        /// </summary>
        /// <returns></returns>
        public static object ExecuteScalar(string cmdText, CommandType type, int time, params SqlParameter[] args)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = cmdText;
                    if (args != null)
                    {
                        foreach (SqlParameter parameter in args)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    cmd.CommandType = type;
                    try
                    {
                        con.Open();
                        //CommandTimeout设置值 0 指没有限制 (尝试执行命令将无限期等待)。
                        cmd.CommandTimeout = time;
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        con.Close();
                        throw e;
                    }
                }
            }
        }

        #endregion

        #region 执行SQL语句对数据库的记录进行操作，返回SqlDataReader

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回SqlDataReader，默认使用sql语句操作
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader ExcuteReader(string cmdText, params SqlParameter[] args)
        {
            return ExcuteReader(cmdText, CommandType.Text, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回SqlDataReader，CommandType可指定使用存储过程
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader ExcuteReader(string cmdText, CommandType type, params SqlParameter[] args)
        {
            SqlConnection con = new SqlConnection(connection);
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = cmdText;
                if (args != null)
                {
                        foreach (SqlParameter parameter in args)
                        {
                            if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                            {
                                parameter.Value = DBNull.Value;
                            }
                            cmd.Parameters.Add(parameter);
                        }
                }
                cmd.CommandType = type;
                try
                {
                    con.Open();
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception)
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }

        #endregion

        #region 执行SQL语句对数据库的记录进行操作，返回内存中的DataTable数据表

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回内存中的DataTable数据表，使用sql语句操作
        /// </summary>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string cmdText, params SqlParameter[] args)
        {
            object outputValue;
            return ExecuteDataTable(cmdText, CommandType.Text, out outputValue, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回内存中的DataTable数据表，使用存储过程操作
        /// </summary>
        /// <returns></returns>
        public static DataTable ExecuteDataTable_Proc(string cmdText, out object outputValue,params SqlParameter[] args)
        {
            return ExecuteDataTable(cmdText, CommandType.StoredProcedure, out outputValue, args);
        }

        /// <summary>
        ///执行SQL语句对数据库的记录进行操作，返回内存中的DataTable数据表，CommandType可指定使用存储过程
        /// </summary>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string cmdText, CommandType cmdType, out object outputValue, SqlParameter[] args)
        {
            outputValue = null;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmdText, con))
                    {
                        sda.SelectCommand.CommandType = cmdType;
                        if (args != null)
                        {
                            foreach (SqlParameter parameter in args)
                            {
                                if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                                {
                                    parameter.Value = DBNull.Value;
                                }
                                sda.SelectCommand.Parameters.Add(parameter);
                            }
                        }
                        sda.Fill(dt);
                    }
                    foreach (var parameter in args)
                    {
                        if (parameter.Direction == ParameterDirection.Output)
                        {
                            outputValue = parameter.Value;
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return dt;
        }

        #endregion

        #region 一次把DataTable中的数据插入数据库

        /// <summary>
        ///一次性把DataTable中的数据插入数据库,SqlBulkCopy提供明显的性能优势
        /// </summary>
        /// <returns></returns>
        public static bool DataBulkCopy(string dbTableName,DataTable table)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();
                    using (SqlBulkCopy copy = new SqlBulkCopy(con))
                    {
                        copy.DestinationTableName = dbTableName;
                        copy.WriteToServer(table);
                        return true;
                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        #endregion

        #region 执行事务SQL语句对数据库的记录进行操作，无返回值

        /// <summary>
        ///执行事务SQL语句对数据库的记录进行操作，无返回值
        /// </summary>
        /// <returns></returns>
        public static void ExecuteNonQueryTran(List<TranSqlParameter> list)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    con.Open();
                    using (SqlTransaction trans = con.BeginTransaction())
                    {
                        cmd.Transaction = trans;
                        try
                        {
                            foreach (TranSqlParameter sqlObject in list)
                            {
                                cmd.CommandText = sqlObject.Sql;
                                if (sqlObject.Parameters != null)
                                {
                                    foreach (SqlParameter parameter in sqlObject.Parameters)
                                    {
                                        if ((parameter.Direction == ParameterDirection.InputOutput ||
                                 parameter.Direction == ParameterDirection.Input) && (parameter.Value == null) ||
                                parameter.Direction == ParameterDirection.Input && (string.IsNullOrEmpty(parameter.Value.ToString())))
                                        {
                                            parameter.Value = DBNull.Value;
                                        }
                                        cmd.Parameters.Add(parameter);
                                }
                                cmd.CommandType = sqlObject.CmdType;
                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();
                            }
                            trans.Commit();
                            }
                        }
                        catch (Exception)
                        {
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
        }

        #endregion
    }

    //执行事务SQL语句实体类
    public class TranSqlParameter
    {
        public string Sql
        {
            get;
            set;
        }

        public SqlParameter[] Parameters
        {
            get;
            set;
        }

        public CommandType CmdType
        {
            get;
            set;
        }
    }
}