using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class T_HR_JTCYDAL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///DAL方法：向数据库中增加一条新的T_HR_JTCY对象数据------>请传入对象,返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_JTCY model)
        {
            object b = SqlHelper.ExecuteScalar("insert into T_HR_JTCY (ID,RID,XM,CW,CSRQ,JG,MZ,XL,XW,ZZMM,GZDW,ZW,LXDH,GXRID,GXRXM,GXLX,GXYY,GXSJ) output inserted.ID values(@ID,@RID,@XM,@CW,@CSRQ,@JG,@MZ,@XL,@XW,@ZZMM,@GZDW,@ZW,@LXDH,@GXRID,@GXRXM,@GXLX,@GXYY,@GXSJ)",new SqlParameter("ID",model.ID),new SqlParameter("RID",model.RID),new SqlParameter("XM",model.XM),new SqlParameter("CW",model.CW),new SqlParameter("CSRQ",model.CSRQ),new SqlParameter("JG",model.JG),new SqlParameter("MZ",model.MZ),new SqlParameter("XL",model.XL),new SqlParameter("XW",model.XW),new SqlParameter("ZZMM",model.ZZMM),new SqlParameter("GZDW",model.GZDW),new SqlParameter("ZW",model.ZW),new SqlParameter("LXDH",model.LXDH),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_JTCY where " + strDBColumnName + " = @strDelId",new SqlParameter("@strDelId",strDelId));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_JTCY where " + strDBColumnName + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///DAL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_JTCY model,string strDBColumnName,string strUpdateId)
        {
            int e = SqlHelper.ExecuteNonQuery("update T_HR_JTCY set ID=@ID,RID=@RID,XM=@XM,CW=@CW,CSRQ=@CSRQ,JG=@JG,MZ=@MZ,XL=@XL,XW=@XW,ZZMM=@ZZMM,GZDW=@GZDW,ZW=@ZW,LXDH=@LXDH,GXRID=@GXRID,GXRXM=@GXRXM,GXLX=@GXLX,GXYY=@GXYY,GXSJ=@GXSJ where " + strDBColumnName + " = @Id",new SqlParameter("ID",model.ID),new SqlParameter("RID",model.RID),new SqlParameter("XM",model.XM),new SqlParameter("CW",model.CW),new SqlParameter("CSRQ",model.CSRQ),new SqlParameter("JG",model.JG),new SqlParameter("MZ",model.MZ),new SqlParameter("XL",model.XL),new SqlParameter("XW",model.XW),new SqlParameter("ZZMM",model.ZZMM),new SqlParameter("GZDW",model.GZDW),new SqlParameter("ZW",model.ZW),new SqlParameter("LXDH",model.LXDH),new SqlParameter("GXRID",model.GXRID),new SqlParameter("GXRXM",model.GXRXM),new SqlParameter("GXLX",model.GXLX),new SqlParameter("GXYY",model.GXYY),new SqlParameter("GXSJ",model.GXSJ),new SqlParameter("Id", strUpdateId));
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
            int e = SqlHelper.ExecuteNonQuery("update T_HR_JTCY set " + updateDBColumnName + " = " + updateDBColumnValue + " where " + strAccord + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_JTCY对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_JTCY SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_JTCY where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        T_HR_JTCY model = new T_HR_JTCY();
                        model.ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                        model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                        model.CW = reader.IsDBNull(3) ? null : reader.GetString(3);
                        model.CSRQ = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                        model.JG = reader.IsDBNull(5) ? null : reader.GetString(5);
                        model.MZ = reader.IsDBNull(6) ? null : reader.GetString(6);
                        model.XL = reader.IsDBNull(7) ? null : reader.GetString(7);
                        model.XW = reader.IsDBNull(8) ? null : reader.GetString(8);
                        model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                        model.GZDW = reader.IsDBNull(10) ? null : reader.GetString(10);
                        model.ZW = reader.IsDBNull(11) ? null : reader.GetString(11);
                        model.LXDH = reader.IsDBNull(12) ? null : reader.GetString(12);
                        model.GXRID = reader.IsDBNull(13) ? null : reader.GetString(13);
                        model.GXRXM = reader.IsDBNull(14) ? null : reader.GetString(14);
                        model.GXLX = reader.IsDBNull(15) ? null : reader.GetString(15);
                        model.GXYY = reader.IsDBNull(16) ? null : reader.GetString(16);
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
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_JTCY对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_JTCY SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_JTCY where " + strDBColumnName + " = @ID",new SqlParameter("ID",strSelId));
            if(dt.Rows.Count<=0)
            {
                return null;
            }
            else if(dt.Rows.Count==1)
            {
                T_HR_JTCY model = new T_HR_JTCY();
                DataRow dr = dt.Rows[0];
                model.ID = (dr["ID"] == DBNull.Value) ? null : (string)dr["ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.XM = (dr["XM"] == DBNull.Value) ? null : (string)dr["XM"];
                model.CW = (dr["CW"] == DBNull.Value) ? null : (string)dr["CW"];
                model.CSRQ = (dr["CSRQ"] == DBNull.Value) ? null : (DateTime?)dr["CSRQ"];
                model.JG = (dr["JG"] == DBNull.Value) ? null : (string)dr["JG"];
                model.MZ = (dr["MZ"] == DBNull.Value) ? null : (string)dr["MZ"];
                model.XL = (dr["XL"] == DBNull.Value) ? null : (string)dr["XL"];
                model.XW = (dr["XW"] == DBNull.Value) ? null : (string)dr["XW"];
                model.ZZMM = (dr["ZZMM"] == DBNull.Value) ? null : (string)dr["ZZMM"];
                model.GZDW = (dr["GZDW"] == DBNull.Value) ? null : (string)dr["GZDW"];
                model.ZW = (dr["ZW"] == DBNull.Value) ? null : (string)dr["ZW"];
                model.LXDH = (dr["LXDH"] == DBNull.Value) ? null : (string)dr["LXDH"];
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
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectAllByReader()
        {
            List<T_HR_JTCY> list = new List<T_HR_JTCY>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_JTCY"))
            {
                while (reader.Read())
                {
                T_HR_JTCY model = new T_HR_JTCY();
                    model.ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CW = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.CSRQ = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                    model.JG = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.MZ = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.XL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XW = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GZDW = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.ZW = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.LXDH = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.GXRID = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.GXRXM = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.GXLX = reader.IsDBNull(15) ? null : reader.GetString(15);
                    model.GXYY = reader.IsDBNull(16) ? null : reader.GetString(16);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectAllByAdapter()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_JTCY");
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
            object count = SqlHelper.ExecuteScalar("select Count(*) from T_HR_JTCY where " + strDBColumnName + " = @SelValue",new SqlParameter("SelValue",strSelValue));
            return Convert.ToInt32(count);
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> FuzzyQueryByReader(bool IDIsChecked,string ID,bool RIDIsChecked,string RID,bool XMIsChecked,string XM,bool CWIsChecked,string CW,bool CSRQIsChecked,string CSRQ,bool JGIsChecked,string JG,bool MZIsChecked,string MZ,bool XLIsChecked,string XL,bool XWIsChecked,string XW,bool ZZMMIsChecked,string ZZMM,bool GZDWIsChecked,string GZDW,bool ZWIsChecked,string ZW,bool LXDHIsChecked,string LXDH,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_JTCY");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(IDIsChecked)
            {
               list.Add("ID like @ID");
               listParameter.Add(new SqlParameter("ID", "%" +ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(XMIsChecked)
            {
               list.Add("XM like @XM");
               listParameter.Add(new SqlParameter("XM", "%" +XM+ "%"));
            }
            if(CWIsChecked)
            {
               list.Add("CW like @CW");
               listParameter.Add(new SqlParameter("CW", "%" +CW+ "%"));
            }
            if(CSRQIsChecked)
            {
               list.Add("CSRQ like @CSRQ");
               listParameter.Add(new SqlParameter("CSRQ", "%" +CSRQ+ "%"));
            }
            if(JGIsChecked)
            {
               list.Add("JG like @JG");
               listParameter.Add(new SqlParameter("JG", "%" +JG+ "%"));
            }
            if(MZIsChecked)
            {
               list.Add("MZ like @MZ");
               listParameter.Add(new SqlParameter("MZ", "%" +MZ+ "%"));
            }
            if(XLIsChecked)
            {
               list.Add("XL like @XL");
               listParameter.Add(new SqlParameter("XL", "%" +XL+ "%"));
            }
            if(XWIsChecked)
            {
               list.Add("XW like @XW");
               listParameter.Add(new SqlParameter("XW", "%" +XW+ "%"));
            }
            if(ZZMMIsChecked)
            {
               list.Add("ZZMM like @ZZMM");
               listParameter.Add(new SqlParameter("ZZMM", "%" +ZZMM+ "%"));
            }
            if(GZDWIsChecked)
            {
               list.Add("GZDW like @GZDW");
               listParameter.Add(new SqlParameter("GZDW", "%" +GZDW+ "%"));
            }
            if(ZWIsChecked)
            {
               list.Add("ZW like @ZW");
               listParameter.Add(new SqlParameter("ZW", "%" +ZW+ "%"));
            }
            if(LXDHIsChecked)
            {
               list.Add("LXDH like @LXDH");
               listParameter.Add(new SqlParameter("LXDH", "%" +LXDH+ "%"));
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
            List<T_HR_JTCY> listT_HR_JTCY = new List<T_HR_JTCY>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader(sb.ToString(), listParameter.ToArray()))
            {
                while (reader.Read())
                {
                    T_HR_JTCY model = new T_HR_JTCY();
                    model.ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CW = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.CSRQ = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                    model.JG = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.MZ = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.XL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XW = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GZDW = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.ZW = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.LXDH = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.GXRID = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.GXRXM = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.GXLX = reader.IsDBNull(15) ? null : reader.GetString(15);
                    model.GXYY = reader.IsDBNull(16) ? null : reader.GetString(16);
                    listT_HR_JTCY.Add(model);
                }
            }
            return listT_HR_JTCY;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> FuzzyQueryByAdapter(bool IDIsChecked,string ID,bool RIDIsChecked,string RID,bool XMIsChecked,string XM,bool CWIsChecked,string CW,bool CSRQIsChecked,string CSRQ,bool JGIsChecked,string JG,bool MZIsChecked,string MZ,bool XLIsChecked,string XL,bool XWIsChecked,string XW,bool ZZMMIsChecked,string ZZMM,bool GZDWIsChecked,string GZDW,bool ZWIsChecked,string ZW,bool LXDHIsChecked,string LXDH,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_JTCY");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if(IDIsChecked)
            {
               list.Add("ID like @ID");
               listParameter.Add(new SqlParameter("ID", "%" +ID+ "%"));
            }
            if(RIDIsChecked)
            {
               list.Add("RID like @RID");
               listParameter.Add(new SqlParameter("RID", "%" +RID+ "%"));
            }
            if(XMIsChecked)
            {
               list.Add("XM like @XM");
               listParameter.Add(new SqlParameter("XM", "%" +XM+ "%"));
            }
            if(CWIsChecked)
            {
               list.Add("CW like @CW");
               listParameter.Add(new SqlParameter("CW", "%" +CW+ "%"));
            }
            if(CSRQIsChecked)
            {
               list.Add("CSRQ like @CSRQ");
               listParameter.Add(new SqlParameter("CSRQ", "%" +CSRQ+ "%"));
            }
            if(JGIsChecked)
            {
               list.Add("JG like @JG");
               listParameter.Add(new SqlParameter("JG", "%" +JG+ "%"));
            }
            if(MZIsChecked)
            {
               list.Add("MZ like @MZ");
               listParameter.Add(new SqlParameter("MZ", "%" +MZ+ "%"));
            }
            if(XLIsChecked)
            {
               list.Add("XL like @XL");
               listParameter.Add(new SqlParameter("XL", "%" +XL+ "%"));
            }
            if(XWIsChecked)
            {
               list.Add("XW like @XW");
               listParameter.Add(new SqlParameter("XW", "%" +XW+ "%"));
            }
            if(ZZMMIsChecked)
            {
               list.Add("ZZMM like @ZZMM");
               listParameter.Add(new SqlParameter("ZZMM", "%" +ZZMM+ "%"));
            }
            if(GZDWIsChecked)
            {
               list.Add("GZDW like @GZDW");
               listParameter.Add(new SqlParameter("GZDW", "%" +GZDW+ "%"));
            }
            if(ZWIsChecked)
            {
               list.Add("ZW like @ZW");
               listParameter.Add(new SqlParameter("ZW", "%" +ZW+ "%"));
            }
            if(LXDHIsChecked)
            {
               list.Add("LXDH like @LXDH");
               listParameter.Add(new SqlParameter("LXDH", "%" +LXDH+ "%"));
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
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectT_HR_JTCYByPageUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_JTCY> list = new List<T_HR_JTCY>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select top " + pageSize + " * from T_HR_JTCY  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_JTCY order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + ""))
            {
                while (reader.Read())
                {
                    T_HR_JTCY model = new T_HR_JTCY();
                    model.ID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.CW = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.CSRQ = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4);
                    model.JG = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.MZ = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.XL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XW = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.GZDW = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.ZW = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.LXDH = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.GXRID = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.GXRXM = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.GXLX = reader.IsDBNull(15) ? null : reader.GetString(15);
                    model.GXYY = reader.IsDBNull(16) ? null : reader.GetString(16);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectT_HR_JTCYByPageUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select top " + pageSize + " * from T_HR_JTCY  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_JTCY order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectT_HR_JTCYByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            List<T_HR_JTCY> list = new List<T_HR_JTCY>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_JTCY )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + ""))
            {
                while (reader.Read())
                {
                    T_HR_JTCY model = new T_HR_JTCY();
                    //开窗函数会多出一列，第一列为rownum，所以传入索引1开始
                    model.ID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.RID = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.XM = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.CW = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.CSRQ = reader.IsDBNull(5) ? null : (DateTime?)reader.GetDateTime(5);
                    model.JG = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.MZ = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XL = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.XW = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.ZZMM = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.GZDW = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.ZW = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.LXDH = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.GXRID = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.GXRXM = reader.IsDBNull(15) ? null : reader.GetString(15);
                    model.GXLX = reader.IsDBNull(16) ? null : reader.GetString(16);
                    model.GXYY = reader.IsDBNull(17) ? null : reader.GetString(17);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_JTCY&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectT_HR_JTCYByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select * from ( select row_number() over(order by "+ strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_JTCY )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<="+ (((pageIndex - 1) * pageSize) + pageSize).ToString() + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///DAL方法：判断根据条件的查找结果是否存在------>请传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_JTCYIsExist(string strDBColumnName,string strDBColumnValue)
        {
            object b = SqlHelper.ExecuteScalar("select * from T_HR_JTCY where " + strDBColumnName + " = @strDBColumnValue",new SqlParameter("@strDBColumnValue",strDBColumnValue));
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
            bool b = SqlHelper.DataBulkCopy("T_HR_JTCY",table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_JTCY> SelectT_HR_JTCYByPage_Proc(int pageIndex, int pageSize,out object totalCount)
        {
            DataTable dt = new DataTable();
            SqlParameter totalParameter = new SqlParameter("@total", SqlDbType.Int);
            totalParameter.Direction = ParameterDirection.Output;
            dt = SqlHelper.ExecuteDataTable_Proc("T_HR_JTCY_Proc_LoadPageData", out totalCount, new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize), totalParameter);
            return DataTableToList(dt);
        }
        #endregion

        #region DataTable到List的转换
        /// <summary>
        ///DAL方法：DataTable到IEnumerable<T_HR_JTCY> 的转换------>请传入DataTable类型数据，返回IEnumerable<T_HR_JTCY>类型对象
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T_HR_JTCY> DataTableToList(DataTable dt)
        {
            List<T_HR_JTCY> list = new List<T_HR_JTCY>();
            foreach (DataRow dr in dt.Rows)
            {
                T_HR_JTCY model = new T_HR_JTCY();
                model.ID = (dr["ID"] == DBNull.Value) ? null : (string)dr["ID"];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.XM = (dr["XM"] == DBNull.Value) ? null : (string)dr["XM"];
                model.CW = (dr["CW"] == DBNull.Value) ? null : (string)dr["CW"];
                model.CSRQ = (dr["CSRQ"] == DBNull.Value) ? null : (DateTime?)dr["CSRQ"];
                model.JG = (dr["JG"] == DBNull.Value) ? null : (string)dr["JG"];
                model.MZ = (dr["MZ"] == DBNull.Value) ? null : (string)dr["MZ"];
                model.XL = (dr["XL"] == DBNull.Value) ? null : (string)dr["XL"];
                model.XW = (dr["XW"] == DBNull.Value) ? null : (string)dr["XW"];
                model.ZZMM = (dr["ZZMM"] == DBNull.Value) ? null : (string)dr["ZZMM"];
                model.GZDW = (dr["GZDW"] == DBNull.Value) ? null : (string)dr["GZDW"];
                model.ZW = (dr["ZW"] == DBNull.Value) ? null : (string)dr["ZW"];
                model.LXDH = (dr["LXDH"] == DBNull.Value) ? null : (string)dr["LXDH"];
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