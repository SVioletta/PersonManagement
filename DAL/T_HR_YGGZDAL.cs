using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class T_HR_YGGZDAL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///DAL方法：向数据库中增加一条新的T_HR_YGGZ对象数据------>请传入对象,返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_YGGZ model)
        {
            object b = SqlHelper.ExecuteScalar("insert into T_HR_YGGZ (GZ_ID,RID,JBGZ,ZWGZ,YXBS,GXRID,GXRXM,GXLX,GXYY,GXSJ) output inserted.GZ_ID values(@GZ_ID,@RID,@JBGZ,@ZWGZ,@YXBS,@GXRID,@GXRXM,@GXLX,@GXYY,@GXSJ)",new SqlParameter("GZ_ID",model.GZ_ID),new SqlParameter("RID",model.RID),new SqlParameter("JBGZ",model.JBGZ),new SqlParameter("ZWGZ",model.ZWGZ),new SqlParameter("YXBS",model.YXBS));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_YGGZ where " + strDBColumnName + " = @strDelId",new SqlParameter("@strDelId",strDelId));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_YGGZ where " + strDBColumnName + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///DAL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_YGGZ model,string strDBColumnName,string strUpdateId)
        {
            int e = SqlHelper.ExecuteNonQuery("update T_HR_YGGZ set GZ_ID=@GZ_ID,RID=@RID,JBGZ=@JBGZ,ZWGZ=@ZWGZ,YXBS=@YXBS,GXRID=@GXRID,GXRXM=@GXRXM,GXLX=@GXLX,GXYY=@GXYY,GXSJ=@GXSJ where " + strDBColumnName + " = @Id",new SqlParameter("GZ_ID",model.GZ_ID),new SqlParameter("RID",model.RID),new SqlParameter("JBGZ",model.JBGZ),new SqlParameter("ZWGZ",model.ZWGZ),new SqlParameter("YXBS",model.YXBS),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ),new SqlParameter("Id", strUpdateId));
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
            int e = SqlHelper.ExecuteNonQuery("update T_HR_YGGZ set " + updateDBColumnName + " = " + updateDBColumnValue + " where " + strAccord + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGGZ对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGGZ SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_YGGZ where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        T_HR_YGGZ model = new T_HR_YGGZ();
                        model.GZ_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                        model.YXBS = reader.IsDBNull(4) ? null : reader.GetString(4);
                        model.GXRID = reader.IsDBNull(5) ? null : reader.GetString(5);
                        model.GXRXM = reader.IsDBNull(6) ? null : reader.GetString(6);
                        model.GXLX = reader.IsDBNull(7) ? null : reader.GetString(7);
                        model.GXYY = reader.IsDBNull(8) ? null : reader.GetString(8);
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
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGGZ对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGGZ SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_YGGZ where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId));
            if(dt.Rows.Count<=0)
            {
                return null;
            }
            else if(dt.Rows.Count==1)
            {
                T_HR_YGGZ model = new T_HR_YGGZ();
                DataRow dr = dt.Rows[0];
                model.GZ_ID = (dr["GZ_ID"] == DBNull.Value) ? null : (string)dr["GZ_ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.JBGZ = (object)dr["JBGZ"];
                model.ZWGZ = (object)dr["ZWGZ"];
                model.YXBS = (dr["YXBS"] == DBNull.Value) ? null : (string)dr["YXBS"];
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
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectAllByReader()
        {
            List<T_HR_YGGZ> list = new List<T_HR_YGGZ>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_YGGZ"))
            {
                while (reader.Read())
                {
                T_HR_YGGZ model = new T_HR_YGGZ();
                    model.GZ_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.YXBS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.GXRID = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.GXRXM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXLX = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXYY = reader.IsDBNull(8) ? null : reader.GetString(8);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectAllByAdapter()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_YGGZ");
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
            object count = SqlHelper.ExecuteScalar("select Count(*) from T_HR_YGGZ where " + strDBColumnName + " = @SelValue",new SqlParameter("SelValue",strSelValue));
            return Convert.ToInt32(count);
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> FuzzyQueryByReader(bool GZ_IDIsChecked,string GZ_ID,bool RIDIsChecked,string RID,bool JBGZIsChecked,string JBGZ,bool ZWGZIsChecked,string ZWGZ,bool YXBSIsChecked,string YXBS,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_YGGZ");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(GZ_IDIsChecked)
            {
               list.Add("GZ_ID like @GZ_ID");
               listParameter.Add(new SqlParameter("GZ_ID", "%" +GZ_ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(JBGZIsChecked)
            {
               list.Add("JBGZ like @JBGZ");
               listParameter.Add(new SqlParameter("JBGZ", "%" +JBGZ+ "%"));
            }
            if(ZWGZIsChecked)
            {
               list.Add("ZWGZ like @ZWGZ");
               listParameter.Add(new SqlParameter("ZWGZ", "%" +ZWGZ+ "%"));
            }
            if(YXBSIsChecked)
            {
               list.Add("YXBS like @YXBS");
               listParameter.Add(new SqlParameter("YXBS", "%" +YXBS+ "%"));
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
            List<T_HR_YGGZ> listT_HR_YGGZ = new List<T_HR_YGGZ>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader(sb.ToString(), listParameter.ToArray()))
            {
                while (reader.Read())
                {
                    T_HR_YGGZ model = new T_HR_YGGZ();
                    model.GZ_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.YXBS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.GXRID = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.GXRXM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXLX = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXYY = reader.IsDBNull(8) ? null : reader.GetString(8);
                    listT_HR_YGGZ.Add(model);
                }
            }
            return listT_HR_YGGZ;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> FuzzyQueryByAdapter(bool GZ_IDIsChecked,string GZ_ID,bool RIDIsChecked,string RID,bool JBGZIsChecked,string JBGZ,bool ZWGZIsChecked,string ZWGZ,bool YXBSIsChecked,string YXBS,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_YGGZ");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(GZ_IDIsChecked)
            {
               list.Add("GZ_ID like @GZ_ID");
               listParameter.Add(new SqlParameter("GZ_ID", "%" +GZ_ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(JBGZIsChecked)
            {
               list.Add("JBGZ like @JBGZ");
               listParameter.Add(new SqlParameter("JBGZ", "%" +JBGZ+ "%"));
            }
            if(ZWGZIsChecked)
            {
               list.Add("ZWGZ like @ZWGZ");
               listParameter.Add(new SqlParameter("ZWGZ", "%" +ZWGZ+ "%"));
            }
            if(YXBSIsChecked)
            {
               list.Add("YXBS like @YXBS");
               listParameter.Add(new SqlParameter("YXBS", "%" +YXBS+ "%"));
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
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectT_HR_YGGZByPageUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_YGGZ> list = new List<T_HR_YGGZ>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select top " + pageSize + " * from T_HR_YGGZ  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_YGGZ order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + ""))
            {
                while (reader.Read())
                {
                    T_HR_YGGZ model = new T_HR_YGGZ();
                    model.GZ_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.YXBS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.GXRID = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.GXRXM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXLX = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXYY = reader.IsDBNull(8) ? null : reader.GetString(8);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectT_HR_YGGZByPageUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select top " + pageSize + " * from T_HR_YGGZ  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_YGGZ order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectT_HR_YGGZByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_YGGZ> list = new List<T_HR_YGGZ>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_YGGZ )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + ""))
            {
                while (reader.Read())
                {
                    T_HR_YGGZ model = new T_HR_YGGZ();
                    //开窗函数会多出一列，第一列为rownum，所以传入索引1开始
                    model.GZ_ID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.RID = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.YXBS = reader.IsDBNull(5) ? null : reader.GetString(5);
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

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGGZ&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectT_HR_YGGZByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_YGGZ )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///DAL方法：判断根据条件的查找结果是否存在------>请传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_YGGZIsExist(string strDBColumnName,string strDBColumnValue)
        {
            object b = SqlHelper.ExecuteScalar("select * from T_HR_YGGZ where " + strDBColumnName + " = @strDBColumnValue",new SqlParameter("@strDBColumnValue",strDBColumnValue));
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
            bool b = SqlHelper.DataBulkCopy("T_HR_YGGZ",table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGGZ> SelectT_HR_YGGZByPage_Proc(int pageIndex, int pageSize,out object totalCount)
        {
            DataTable dt = new DataTable();
            SqlParameter totalParameter = new SqlParameter("@total", SqlDbType.Int);
            totalParameter.Direction = ParameterDirection.Output;
            dt = SqlHelper.ExecuteDataTable_Proc("T_HR_YGGZ_Proc_LoadPageData", out totalCount, new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize), totalParameter);
            return DataTableToList(dt);
        }
        #endregion

        #region DataTable到List的转换
        /// <summary>
        ///DAL方法：DataTable到IEnumerable<T_HR_YGGZ> 的转换------>请传入DataTable类型数据，返回IEnumerable<T_HR_YGGZ>类型对象
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T_HR_YGGZ> DataTableToList(DataTable dt)
        {
            List<T_HR_YGGZ> list = new List<T_HR_YGGZ>();
            foreach (DataRow dr in dt.Rows)
            {
                T_HR_YGGZ model = new T_HR_YGGZ();
                model.GZ_ID = (dr["GZ_ID"] == DBNull.Value) ? null : (string)dr["GZ_ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.JBGZ = (object)dr["JBGZ"];
                model.ZWGZ = (object)dr["ZWGZ"];
                model.YXBS = (dr["YXBS"] == DBNull.Value) ? null : (string)dr["YXBS"];
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