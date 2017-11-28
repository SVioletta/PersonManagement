using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class T_HR_BMXXDAL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///DAL方法：向数据库中增加一条新的T_HR_BMXX对象数据------>请传入对象,返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_BMXX model)
        {
            object b = SqlHelper.ExecuteScalar("insert into T_HR_BMXX (BM_ID,BMBM,BMMC,CJRQ,ZZMS,FZR,LXR,GXRID,GXRXM,GXLX,GXYY,GXSJ) output inserted.BM_ID values(@BM_ID,@BMBM,@BMMC,@CJRQ,@ZZMS,@FZR,@LXR,@GXRID,@GXRXM,@GXLX,@GXYY,@GXSJ)",new SqlParameter("BM_ID",model.BM_ID),new SqlParameter("BMBM",model.BMBM),new SqlParameter("BMMC",model.BMMC),new SqlParameter("CJRQ",model.CJRQ),new SqlParameter("ZZMS",model.ZZMS),new SqlParameter("FZR",model.FZR),new SqlParameter("LXR",model.LXR),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_BMXX where " + strDBColumnName + " = @strDelId",new SqlParameter("@strDelId",strDelId));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_BMXX where " + strDBColumnName + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///DAL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_BMXX model,string strDBColumnName,string strUpdateId)
        {
            int e = SqlHelper.ExecuteNonQuery("update T_HR_BMXX set BM_ID=@BM_ID,BMBM=@BMBM,BMMC=@BMMC,CJRQ=@CJRQ,ZZMS=@ZZMS,FZR=@FZR,LXR=@LXR,GXRID=@GXRID,GXRXM=@GXRXM,GXLX=@GXLX,GXYY=@GXYY,GXSJ=@GXSJ where " + strDBColumnName + " = @Id",new SqlParameter("BM_ID",model.BM_ID),new SqlParameter("BMBM",model.BMBM),new SqlParameter("BMMC",model.BMMC),new SqlParameter("CJRQ",model.CJRQ),new SqlParameter("ZZMS",model.ZZMS),new SqlParameter("FZR",model.FZR),new SqlParameter("LXR",model.LXR),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ),new SqlParameter("Id", strUpdateId));
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
            int e = SqlHelper.ExecuteNonQuery("update T_HR_BMXX set " + updateDBColumnName + " = " + updateDBColumnValue + " where " + strAccord + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_BMXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_BMXX SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_BMXX where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        T_HR_BMXX model = new T_HR_BMXX();
                        model.BM_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        model.BMBM = reader.IsDBNull(1) ? null : reader.GetString(1);
                        model.BMMC = reader.IsDBNull(2) ? null : reader.GetString(2);
                        model.CJRQ = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3);
                        model.ZZMS = reader.IsDBNull(4) ? null : reader.GetString(4);
                        model.FZR = reader.IsDBNull(5) ? null : reader.GetString(5);
                        model.LXR = reader.IsDBNull(6) ? null : reader.GetString(6);
                        model.GXRID = reader.IsDBNull(7) ? null : reader.GetString(7);
                        model.GXRXM = reader.IsDBNull(8) ? null : reader.GetString(8);
                        model.GXLX = reader.IsDBNull(9) ? null : reader.GetString(9);
                        model.GXYY = reader.IsDBNull(10) ? null : reader.GetString(10);
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
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_BMXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_BMXX SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_BMXX where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId));
            if(dt.Rows.Count<=0)
            {
                return null;
            }
            else if(dt.Rows.Count==1)
            {
                T_HR_BMXX model = new T_HR_BMXX();
                DataRow dr = dt.Rows[0];
                model.BM_ID = (dr["BM_ID"] == DBNull.Value) ? null : (string)dr["BM_ID"];
                model.BMBM = (dr["BMBM"] == DBNull.Value) ? null : (string)dr["BMBM"];
                model.BMMC = (dr["BMMC"] == DBNull.Value) ? null : (string)dr["BMMC"];
                model.CJRQ = (dr["CJRQ"] == DBNull.Value) ? null : (DateTime?)dr["CJRQ"];
                model.ZZMS = (dr["ZZMS"] == DBNull.Value) ? null : (string)dr["ZZMS"];
                model.FZR = (dr["FZR"] == DBNull.Value) ? null : (string)dr["FZR"];
                model.LXR = (dr["LXR"] == DBNull.Value) ? null : (string)dr["LXR"];
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
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectAllByReader()
        {
            List<T_HR_BMXX> list = new List<T_HR_BMXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_BMXX"))
            {
                while (reader.Read())
                {
                T_HR_BMXX model = new T_HR_BMXX();
                    model.BM_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.BMBM = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.BMMC = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CJRQ = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3);
                    model.ZZMS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.FZR = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.LXR = reader.IsDBNull(6) ? null : reader.GetString(6);
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

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectAllByAdapter()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_BMXX");
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
            object count = SqlHelper.ExecuteScalar("select Count(*) from T_HR_BMXX where " + strDBColumnName + " = @SelValue",new SqlParameter("SelValue",strSelValue));
            return Convert.ToInt32(count);
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> FuzzyQueryByReader(bool BM_IDIsChecked,string BM_ID,bool BMBMIsChecked,string BMBM,bool BMMCIsChecked,string BMMC,bool CJRQIsChecked,string CJRQ,bool ZZMSIsChecked,string ZZMS,bool FZRIsChecked,string FZR,bool LXRIsChecked,string LXR,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_BMXX");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(BM_IDIsChecked)
            {
               list.Add("BM_ID like @BM_ID");
               listParameter.Add(new SqlParameter("BM_ID", "%" +BM_ID+ "%"));
            }
            if(BMBMIsChecked)
            {
               list.Add("BMBM like @BMBM");
               listParameter.Add(new SqlParameter("BMBM", "%" +BMBM+ "%"));
            }
            if(BMMCIsChecked)
            {
               list.Add("BMMC like @BMMC");
               listParameter.Add(new SqlParameter("BMMC", "%" +BMMC+ "%"));
            }
            if(CJRQIsChecked)
            {
               list.Add("CJRQ like @CJRQ");
               listParameter.Add(new SqlParameter("CJRQ", "%" +CJRQ+ "%"));
            }
            if(ZZMSIsChecked)
            {
               list.Add("ZZMS like @ZZMS");
               listParameter.Add(new SqlParameter("ZZMS", "%" +ZZMS+ "%"));
            }
            if(FZRIsChecked)
            {
               list.Add("FZR like @FZR");
               listParameter.Add(new SqlParameter("FZR", "%" +FZR+ "%"));
            }
            if(LXRIsChecked)
            {
               list.Add("LXR like @LXR");
               listParameter.Add(new SqlParameter("LXR", "%" +LXR+ "%"));
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
            List<T_HR_BMXX> listT_HR_BMXX = new List<T_HR_BMXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader(sb.ToString(), listParameter.ToArray()))
            {
                while (reader.Read())
                {
                    T_HR_BMXX model = new T_HR_BMXX();
                    model.BM_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.BMBM = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.BMMC = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CJRQ = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3);
                    model.ZZMS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.FZR = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.LXR = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.GXRID = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXRXM = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXLX = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GXYY = reader.IsDBNull(10) ? null : reader.GetString(10);
                    listT_HR_BMXX.Add(model);
                }
            }
            return listT_HR_BMXX;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> FuzzyQueryByAdapter(bool BM_IDIsChecked,string BM_ID,bool BMBMIsChecked,string BMBM,bool BMMCIsChecked,string BMMC,bool CJRQIsChecked,string CJRQ,bool ZZMSIsChecked,string ZZMS,bool FZRIsChecked,string FZR,bool LXRIsChecked,string LXR,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_BMXX");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(BM_IDIsChecked)
            {
               list.Add("BM_ID like @BM_ID");
               listParameter.Add(new SqlParameter("BM_ID", "%" +BM_ID+ "%"));
            }
            if(BMBMIsChecked)
            {
               list.Add("BMBM like @BMBM");
               listParameter.Add(new SqlParameter("BMBM", "%" +BMBM+ "%"));
            }
            if(BMMCIsChecked)
            {
               list.Add("BMMC like @BMMC");
               listParameter.Add(new SqlParameter("BMMC", "%" +BMMC+ "%"));
            }
            if(CJRQIsChecked)
            {
               list.Add("CJRQ like @CJRQ");
               listParameter.Add(new SqlParameter("CJRQ", "%" +CJRQ+ "%"));
            }
            if(ZZMSIsChecked)
            {
               list.Add("ZZMS like @ZZMS");
               listParameter.Add(new SqlParameter("ZZMS", "%" +ZZMS+ "%"));
            }
            if(FZRIsChecked)
            {
               list.Add("FZR like @FZR");
               listParameter.Add(new SqlParameter("FZR", "%" +FZR+ "%"));
            }
            if(LXRIsChecked)
            {
               list.Add("LXR like @LXR");
               listParameter.Add(new SqlParameter("LXR", "%" +LXR+ "%"));
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
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_BMXX> list = new List<T_HR_BMXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select top " + pageSize + " * from T_HR_BMXX  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_BMXX order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + ""))
            {
                while (reader.Read())
                {
                    T_HR_BMXX model = new T_HR_BMXX();
                    model.BM_ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.BMBM = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.BMMC = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CJRQ = reader.IsDBNull(3) ? null : (DateTime?)reader.GetDateTime(3);
                    model.ZZMS = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.FZR = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.LXR = reader.IsDBNull(6) ? null : reader.GetString(6);
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

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select top " + pageSize + " * from T_HR_BMXX  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_BMXX order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_BMXX> list = new List<T_HR_BMXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_BMXX )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + ""))
            {
                while (reader.Read())
                {
                    T_HR_BMXX model = new T_HR_BMXX();
                    //开窗函数会多出一列，第一列为rownum，所以传入索引1开始
                    model.BM_ID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.BMBM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.BMMC = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.CJRQ = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                    model.ZZMS = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.FZR = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.LXR = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.GXRID = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.GXRXM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GXLX = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.GXYY = reader.IsDBNull(11) ? null : reader.GetString(11);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_BMXX )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///DAL方法：判断根据条件的查找结果是否存在------>请传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_BMXXIsExist(string strDBColumnName,string strDBColumnValue)
        {
            object b = SqlHelper.ExecuteScalar("select * from T_HR_BMXX where " + strDBColumnName + " = @strDBColumnValue",new SqlParameter("@strDBColumnValue",strDBColumnValue));
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
            bool b = SqlHelper.DataBulkCopy("T_HR_BMXX",table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPage_Proc(int pageIndex, int pageSize,out object totalCount)
        {
            DataTable dt = new DataTable();
            SqlParameter totalParameter = new SqlParameter("@total", SqlDbType.Int);
            totalParameter.Direction = ParameterDirection.Output;
            dt = SqlHelper.ExecuteDataTable_Proc("T_HR_BMXX_Proc_LoadPageData", out totalCount, new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize), totalParameter);
            return DataTableToList(dt);
        }
        #endregion

        #region DataTable到List的转换
        /// <summary>
        ///DAL方法：DataTable到IEnumerable<T_HR_BMXX> 的转换------>请传入DataTable类型数据，返回IEnumerable<T_HR_BMXX>类型对象
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T_HR_BMXX> DataTableToList(DataTable dt)
        {
            List<T_HR_BMXX> list = new List<T_HR_BMXX>();
            foreach (DataRow dr in dt.Rows)
            {
                T_HR_BMXX model = new T_HR_BMXX();
                model.BM_ID = (dr["BM_ID"] == DBNull.Value) ? null : (string)dr["BM_ID"];
                model.BMBM = (dr["BMBM"] == DBNull.Value) ? null : (string)dr["BMBM"];
                model.BMMC = (dr["BMMC"] == DBNull.Value) ? null : (string)dr["BMMC"];
                model.CJRQ = (dr["CJRQ"] == DBNull.Value) ? null : (DateTime?)dr["CJRQ"];
                model.ZZMS = (dr["ZZMS"] == DBNull.Value) ? null : (string)dr["ZZMS"];
                model.FZR = (dr["FZR"] == DBNull.Value) ? null : (string)dr["FZR"];
                model.LXR = (dr["LXR"] == DBNull.Value) ? null : (string)dr["LXR"];
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