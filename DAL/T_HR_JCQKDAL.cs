using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class T_HR_JCQKDAL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///DAL方法：向数据库中增加一条新的T_HR_JCQK对象数据------>请传入对象,返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_JCQK model)
        {
            object b = SqlHelper.ExecuteScalar("insert into T_HR_JCQK (JCQK_ID,RID,JCQK,JCDJ,JCDW,JCSJ,GXRID,GXRXM,GXLX,GXYY,GXSJ) output inserted.JCQK_ID values(@JCQK_ID,@RID,@JCQK,@JCDJ,@JCDW,@JCSJ,@GXRID,@GXRXM,@GXLX,@GXYY,@GXSJ)",new SqlParameter("JCQK_ID",model.JCQK_ID),new SqlParameter("RID",model.RID),new SqlParameter("JCQK",model.JCQK),new SqlParameter("JCDJ",model.JCDJ),new SqlParameter("JCDW",model.JCDW),new SqlParameter("JCSJ",model.JCSJ),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ));
            return b;
        }
        #endregion

        #region 删除数据库中的一条数据
        /// <summary>
        ///DAL方法：删除数据库中的一条数据------>根据传入的参数删除数据,请传入数据库的列名以及删除对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Delete(string strDBColumnName,string strDelId)
        {
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_JCQK where " + strDBColumnName + " = @strDelId",new SqlParameter("@strDelId",strDelId));
            return e;
        }
        #endregion

        #region 删除数据库中的多条数据
        /// <summary>
        ///DAL方法：删除数据库中的多条数据------>根据传入的参数删除数据,请传入数据库的列名以及删除的具体依据[例如："delete from XXX where strDBColumnName in (params strDBValue)"],返回影响条数
        /// </summary>
        /// <returns></returns>
        public int DeleteMultiterm(string strDBColumnName, params string[] strDBValues)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in strDBValues)
            {
                sb.Append("'" + value + "'" + ",");
            }
            string str = sb.ToString().Substring(0, sb.ToString().Length - 1);
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_JCQK where " + strDBColumnName + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///DAL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_JCQK model,string strDBColumnName,string strUpdateId)
        {
            int e = SqlHelper.ExecuteNonQuery("update T_HR_JCQK set JCQK_ID=@JCQK_ID,RID=@RID,JCQK=@JCQK,JCDJ=@JCDJ,JCDW=@JCDW,JCSJ=@JCSJ,GXRID=@GXRID,GXRXM=@GXRXM,GXLX=@GXLX,GXYY=@GXYY,GXSJ=@GXSJ where " + strDBColumnName + " = @Id",new SqlParameter("JCQK_ID",model.JCQK_ID),new SqlParameter("RID",model.RID),new SqlParameter("JCQK",model.JCQK),new SqlParameter("JCDJ",model.JCDJ),new SqlParameter("JCDW",model.JCDW),new SqlParameter("JCSJ",model.JCSJ),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ),new SqlParameter("Id", strUpdateId));
            return e;
        }
        #endregion

        #region 更新数据库中的多条数据
        /// <summary>
        ///DAL方法：更新数据库中的多条数据[可用于做多选软删除]------>根据传入的参数更新数据,请传入数据库的列名以及更新的具体依据[例如："update XXX set updateDBColumnName=updateDBColumnValue  where strAccord in (params strDBValue)"],返回影响条数
        /// </summary>
        /// <returns></returns>
        public int UpdateMultiterm(string updateDBColumnName, string updateDBColumnValue, string strAccord, params string[] strDBValues)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var value in strDBValues)
            {
                sb.Append("'" + value + "'" + ",");
            }
            string str = sb.ToString().Substring(0, sb.ToString().Length - 1);
            int e = SqlHelper.ExecuteNonQuery("update T_HR_JCQK set " + updateDBColumnName + " = " + updateDBColumnValue + " where " + strAccord + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_JCQK对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_JCQK SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_JCQK where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        T_HR_JCQK model = new T_HR_JCQK();
                        model.JCQK_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                        model.JCQK = reader.IsDBNull(2) ? null : reader.GetString(2);
                        model.JCDJ = reader.IsDBNull(3) ? null : reader.GetString(3);
                        model.JCDW = reader.IsDBNull(4) ? null : reader.GetString(4);
                        model.JCSJ = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                        model.GXRID = reader.IsDBNull(6) ? null : reader.GetString(6);
                        model.GXRXM = reader.IsDBNull(7) ? null : reader.GetString(7);
                        model.GXLX = reader.IsDBNull(8) ? null : reader.GetString(8);
                        model.GXYY = reader.IsDBNull(9) ? null : reader.GetString(9);
                        return model;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_JCQK对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_JCQK SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_JCQK where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId));
            if(dt.Rows.Count<=0)
            {
                return null;
            }
            else if(dt.Rows.Count==1)
            {
                T_HR_JCQK model = new T_HR_JCQK();
                DataRow dr = dt.Rows[0];
                model.JCQK_ID = (dr["JCQK_ID"] == DBNull.Value) ? null : (string)dr["JCQK_ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.JCQK = (dr["JCQK"] == DBNull.Value) ? null : (string)dr["JCQK"];
                model.JCDJ = (dr["JCDJ"] == DBNull.Value) ? null : (string)dr["JCDJ"];
                model.JCDW = (dr["JCDW"] == DBNull.Value) ? null : (string)dr["JCDW"];
                model.JCSJ = (dr["JCSJ"] == DBNull.Value) ? null : (DateTime?)dr["JCSJ"];
                model.GXRID = (dr["GXRID"] == DBNull.Value) ? null : (string)dr["GXRID"];
                model.GXRXM = (dr["GXRXM"] == DBNull.Value) ? null : (string)dr["GXRXM"];
                model.GXLX = (dr["GXLX"] == DBNull.Value) ? null : (string)dr["GXLX"];
                model.GXYY = (dr["GXYY"] == DBNull.Value) ? null : (string)dr["GXYY"];
                model.GXSJ = (object)dr["GXSJ"];
                return model;
            }
            else
            {
                throw new Exception("出现多条数据!");
            }
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectAllByReader()
        {
            List<T_HR_JCQK> list = new List<T_HR_JCQK>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_JCQK"))
            {
                while (reader.Read())
                {
                T_HR_JCQK model = new T_HR_JCQK();
                    model.JCQK_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.JCQK = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JCDJ = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.JCDW = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.JCSJ = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                    model.GXRID = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXRXM = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXLX = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXYY = reader.IsDBNull(9) ? null : reader.GetString(9);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectAllByAdapter()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_JCQK");
            return DataTableToList(dt);
        }
        #endregion

        #region 查找数据库中的数据条数
        /// <summary>
        ///DAL方法：查找数据库中的数据条数([例如：select Count(*) from... where "XXX"="YYY"],查询整体数据条数Count(*)请传入"1","1"-->sql语句拼接"where 1=1")------>请传入数据库的列名，数据库的值，返回首行首列
        /// </summary>
        /// <returns></returns>
        public int GetCount(string strDBColumnName,string strSelValue)
        {
            object count = SqlHelper.ExecuteScalar("select Count(*) from T_HR_JCQK where " + strDBColumnName + " = @SelValue",new SqlParameter("SelValue",strSelValue));
            return Convert.ToInt32(count);
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> FuzzyQueryByReader(bool JCQK_IDIsChecked,string JCQK_ID,bool RIDIsChecked,string RID,bool JCQKIsChecked,string JCQK,bool JCDJIsChecked,string JCDJ,bool JCDWIsChecked,string JCDW,bool JCSJIsChecked,string JCSJ,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_JCQK");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(JCQK_IDIsChecked)
            {
               list.Add("JCQK_ID like @JCQK_ID");
               listParameter.Add(new SqlParameter("JCQK_ID", "%" +JCQK_ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(JCQKIsChecked)
            {
               list.Add("JCQK like @JCQK");
               listParameter.Add(new SqlParameter("JCQK", "%" +JCQK+ "%"));
            }
            if(JCDJIsChecked)
            {
               list.Add("JCDJ like @JCDJ");
               listParameter.Add(new SqlParameter("JCDJ", "%" +JCDJ+ "%"));
            }
            if(JCDWIsChecked)
            {
               list.Add("JCDW like @JCDW");
               listParameter.Add(new SqlParameter("JCDW", "%" +JCDW+ "%"));
            }
            if(JCSJIsChecked)
            {
               list.Add("JCSJ like @JCSJ");
               listParameter.Add(new SqlParameter("JCSJ", "%" +JCSJ+ "%"));
            }
            if(GXRIDIsChecked)
            {
               list.Add("GXRID like @GXRID");
               listParameter.Add(new SqlParameter("GXRID", "%" +GXRID+ "%"));
            }
            if(GXRXMIsChecked)
            {
               list.Add("GXRXM like @GXRXM");
               listParameter.Add(new SqlParameter("GXRXM", "%" +GXRXM+ "%"));
            }
            if(GXLXIsChecked)
            {
               list.Add("GXLX like @GXLX");
               listParameter.Add(new SqlParameter("GXLX", "%" +GXLX+ "%"));
            }
            if(GXYYIsChecked)
            {
               list.Add("GXYY like @GXYY");
               listParameter.Add(new SqlParameter("GXYY", "%" +GXYY+ "%"));
            }
            if(GXSJIsChecked)
            {
               list.Add("GXSJ like @GXSJ");
               listParameter.Add(new SqlParameter("GXSJ", "%" +GXSJ+ "%"));
            }
            if (list.Count > 0)
            {
               sb.Append(" where ");
               string sql = string.Join(" and ", list.ToArray());
               sb.Append(sql);
            }
            List<T_HR_JCQK> listT_HR_JCQK = new List<T_HR_JCQK>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader(sb.ToString(), listParameter.ToArray()))
            {
                while (reader.Read())
                {
                    T_HR_JCQK model = new T_HR_JCQK();
                    model.JCQK_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.JCQK = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JCDJ = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.JCDW = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.JCSJ = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                    model.GXRID = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXRXM = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXLX = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXYY = reader.IsDBNull(9) ? null : reader.GetString(9);
                    listT_HR_JCQK.Add(model);
                }
            }
            return listT_HR_JCQK;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> FuzzyQueryByAdapter(bool JCQK_IDIsChecked,string JCQK_ID,bool RIDIsChecked,string RID,bool JCQKIsChecked,string JCQK,bool JCDJIsChecked,string JCDJ,bool JCDWIsChecked,string JCDW,bool JCSJIsChecked,string JCSJ,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_JCQK");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(JCQK_IDIsChecked)
            {
               list.Add("JCQK_ID like @JCQK_ID");
               listParameter.Add(new SqlParameter("JCQK_ID", "%" +JCQK_ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(JCQKIsChecked)
            {
               list.Add("JCQK like @JCQK");
               listParameter.Add(new SqlParameter("JCQK", "%" +JCQK+ "%"));
            }
            if(JCDJIsChecked)
            {
               list.Add("JCDJ like @JCDJ");
               listParameter.Add(new SqlParameter("JCDJ", "%" +JCDJ+ "%"));
            }
            if(JCDWIsChecked)
            {
               list.Add("JCDW like @JCDW");
               listParameter.Add(new SqlParameter("JCDW", "%" +JCDW+ "%"));
            }
            if(JCSJIsChecked)
            {
               list.Add("JCSJ like @JCSJ");
               listParameter.Add(new SqlParameter("JCSJ", "%" +JCSJ+ "%"));
            }
            if(GXRIDIsChecked)
            {
               list.Add("GXRID like @GXRID");
               listParameter.Add(new SqlParameter("GXRID", "%" +GXRID+ "%"));
            }
            if(GXRXMIsChecked)
            {
               list.Add("GXRXM like @GXRXM");
               listParameter.Add(new SqlParameter("GXRXM", "%" +GXRXM+ "%"));
            }
            if(GXLXIsChecked)
            {
               list.Add("GXLX like @GXLX");
               listParameter.Add(new SqlParameter("GXLX", "%" +GXLX+ "%"));
            }
            if(GXYYIsChecked)
            {
               list.Add("GXYY like @GXYY");
               listParameter.Add(new SqlParameter("GXYY", "%" +GXYY+ "%"));
            }
            if(GXSJIsChecked)
            {
               list.Add("GXSJ like @GXSJ");
               listParameter.Add(new SqlParameter("GXSJ", "%" +GXSJ+ "%"));
            }
            if (list.Count > 0)
            {
               sb.Append(" where ");
               string sql = string.Join(" and ", list.ToArray());
               sb.Append(sql);
            }
            DataTable dt = SqlHelper.ExecuteDataTable(sb.ToString(), listParameter.ToArray());
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectT_HR_JCQKByPageUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_JCQK> list = new List<T_HR_JCQK>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select top " + pageSize + " * from T_HR_JCQK  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_JCQK order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + ""))
            {
                while (reader.Read())
                {
                    T_HR_JCQK model = new T_HR_JCQK();
                    model.JCQK_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.JCQK = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JCDJ = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.JCDW = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.JCSJ = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                    model.GXRID = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXRXM = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXLX = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXYY = reader.IsDBNull(9) ? null : reader.GetString(9);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectT_HR_JCQKByPageUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select top " + pageSize + " * from T_HR_JCQK  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_JCQK order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectT_HR_JCQKByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_JCQK> list = new List<T_HR_JCQK>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_JCQK )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + ""))
            {
                while (reader.Read())
                {
                    T_HR_JCQK model = new T_HR_JCQK();
                    //开窗函数会多出一列，第一列为rownum，所以传入索引1开始
                    model.JCQK_ID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.RID = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JCQK = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.JCDJ = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.JCDW = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.JCSJ = reader.IsDBNull(6) ? null : (DateTime?)reader.GetDateTime(6);
                    model.GXRID = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXRXM = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXLX = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GXYY = reader.IsDBNull(10) ? null : reader.GetString(10);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JCQK&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectT_HR_JCQKByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_JCQK )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///DAL方法：判断根据条件的查找结果是否存在------>请传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_JCQKIsExist(string strDBColumnName,string strDBColumnValue)
        {
            object b = SqlHelper.ExecuteScalar("select * from T_HR_JCQK where " + strDBColumnName + " = @strDBColumnValue",new SqlParameter("@strDBColumnValue",strDBColumnValue));
            if(b != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 将DataTable整体插入数据库
        /// <summary>
        ///DAL方法：将DataTable整体插入数据库------>请传入DataTable类型数据(DataTable需要跟数据库的列保持一致)，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool AddDataTableToDB(DataTable table)
        {
            bool b = SqlHelper.DataBulkCopy("T_HR_JCQK",table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JCQK> SelectT_HR_JCQKByPage_Proc(int pageIndex, int pageSize,out object totalCount)
        {
            DataTable dt = new DataTable();
            SqlParameter totalParameter = new SqlParameter("@total", SqlDbType.Int);
            totalParameter.Direction = ParameterDirection.Output;
            dt = SqlHelper.ExecuteDataTable_Proc("T_HR_JCQK_Proc_LoadPageData", out totalCount, new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize), totalParameter);
            return DataTableToList(dt);
        }
        #endregion

        #region DataTable到List的转换
        /// <summary>
        ///DAL方法：DataTable到IEnumerable<T_HR_JCQK> 的转换------>请传入DataTable类型数据，返回IEnumerable<T_HR_JCQK>类型对象
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T_HR_JCQK> DataTableToList(DataTable dt)
        {
            List<T_HR_JCQK> list = new List<T_HR_JCQK>();
            foreach (DataRow dr in dt.Rows)
            {
                T_HR_JCQK model = new T_HR_JCQK();
                model.JCQK_ID = (dr["JCQK_ID"] == DBNull.Value) ? null : (string)dr["JCQK_ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.JCQK = (dr["JCQK"] == DBNull.Value) ? null : (string)dr["JCQK"];
                model.JCDJ = (dr["JCDJ"] == DBNull.Value) ? null : (string)dr["JCDJ"];
                model.JCDW = (dr["JCDW"] == DBNull.Value) ? null : (string)dr["JCDW"];
                model.JCSJ = (dr["JCSJ"] == DBNull.Value) ? null : (DateTime?)dr["JCSJ"];
                model.GXRID = (dr["GXRID"] == DBNull.Value) ? null : (string)dr["GXRID"];
                model.GXRXM = (dr["GXRXM"] == DBNull.Value) ? null : (string)dr["GXRXM"];
                model.GXLX = (dr["GXLX"] == DBNull.Value) ? null : (string)dr["GXLX"];
                model.GXYY = (dr["GXYY"] == DBNull.Value) ? null : (string)dr["GXYY"];
                model.GXSJ = (object)dr["GXSJ"];
                list.Add(model);
            }
            return list;
        }
        #endregion
    }
}