using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class T_HR_YGJBXXDAL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///DAL方法：向数据库中增加一条新的T_HR_YGJBXX对象数据------>请传入对象,返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_YGJBXX model)
        {
            object b = SqlHelper.ExecuteScalar(
                "insert into T_HR_YGJBXX (RID,GH,XM,JG,SSBM,ZW,ZJHM,ZJZL,XB,ZZMM,CSRQ,MZ,HYZK,XL,XW,BYRQ,BYXX,SXZY,ZC,HJLB,HJDXZQH,HJDXZ,JZDXZQH,JZDXZ,JZDYZBM,LXDH,JTDH,DASZD,SFYJZZ,JZZQSRQ,JZZJZRQ,SFYLDSC,SFBLGSBJJ,SFBLGGJJ,GJJZH,SFBLGZHBX,YDWSFBLTG,RYLB,SCRZRQ,LZRQ,LZYY) output inserted.RID values(@RID,@GH,@XM,@JG,@SSBM,@ZW,@ZJHM,@ZJZL,@XB,@ZZMM,@CSRQ,@MZ,@HYZK,@XL,@XW,@BYRQ,@BYXX,@SXZY,@ZC,@HJLB,@HJDXZQH,@HJDXZ,@JZDXZQH,@JZDXZ,@JZDYZBM,@LXDH,@JTDH,@DASZD,@SFYJZZ,@JZZQSRQ,@JZZJZRQ,@SFYLDSC,@SFBLGSBJJ,@SFBLGGJJ,@GJJZH,@SFBLGZHBX,@YDWSFBLTG,@RYLB,@SCRZRQ,@LZRQ,@LZYY)",
                new SqlParameter("RID", model.RID), new SqlParameter("GH", model.GH), new SqlParameter("XM", model.XM),
                new SqlParameter("JG", model.JG), new SqlParameter("SSBM", model.SSBM),
                new SqlParameter("ZW", model.ZW), new SqlParameter("ZJHM", model.ZJHM),
                new SqlParameter("ZJZL", model.ZJZL), new SqlParameter("XB", model.XB),
                new SqlParameter("ZZMM", model.ZZMM), new SqlParameter("CSRQ", model.CSRQ),
                new SqlParameter("MZ", model.MZ), new SqlParameter("HYZK", model.HYZK),
                new SqlParameter("XL", model.XL), new SqlParameter("XW", model.XW),
                new SqlParameter("BYRQ", model.BYRQ), new SqlParameter("BYXX", model.BYXX),
                new SqlParameter("SXZY", model.SXZY), new SqlParameter("ZC", model.ZC),
                new SqlParameter("HJLB", model.HJLB), new SqlParameter("HJDXZQH", model.HJDXZQH),
                new SqlParameter("HJDXZ", model.HJDXZ), new SqlParameter("JZDXZQH", model.JZDXZQH),
                new SqlParameter("JZDXZ", model.JZDXZ), new SqlParameter("JZDYZBM", model.JZDYZBM),
                new SqlParameter("LXDH", model.LXDH), new SqlParameter("JTDH", model.JTDH),
                new SqlParameter("DASZD", model.DASZD), new SqlParameter("SFYJZZ", model.SFYJZZ),
                new SqlParameter("JZZQSRQ", model.JZZQSRQ), new SqlParameter("JZZJZRQ", model.JZZJZRQ),
                new SqlParameter("SFYLDSC", model.SFYLDSC), new SqlParameter("SFBLGSBJJ", model.SFBLGSBJJ),
                new SqlParameter("SFBLGGJJ", model.SFBLGGJJ), new SqlParameter("GJJZH", model.GJJZH),
                new SqlParameter("SFBLGZHBX", model.SFBLGZHBX), new SqlParameter("YDWSFBLTG", model.YDWSFBLTG),
                new SqlParameter("RYLB", model.RYLB), new SqlParameter("SCRZRQ", model.SCRZRQ),
                new SqlParameter("LZRQ", model.LZRQ), new SqlParameter("LZYY", model.LZYY)
                );
            return b;
        }
        #endregion

        #region 删除数据库中的一条数据
        /// <summary>
        ///DAL方法：删除数据库中的一条数据------>根据传入的参数删除数据,请传入数据库的列名以及删除对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Delete(string strDBColumnName, string strDelId)
        {
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_YGJBXX where " + strDBColumnName + " = @strDelId", new SqlParameter("@strDelId", strDelId));
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
            int e = SqlHelper.ExecuteNonQuery("delete from T_HR_YGJBXX where " + strDBColumnName + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///DAL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_YGJBXX model, string strDBColumnName, string strUpdateId)
        {
            int e = SqlHelper.ExecuteNonQuery("update T_HR_YGJBXX set RID=@RID,GH=@GH,XM=@XM,JG=@JG,SSBM=@SSBM,ZW=@ZW,ZJHM=@ZJHM,ZJZL=@ZJZL,XB=@XB,ZZMM=@ZZMM,CSRQ=@CSRQ,MZ=@MZ,HYZK=@HYZK,XL=@XL,XW=@XW,BYRQ=@BYRQ,BYXX=@BYXX,SXZY=@SXZY,ZC=@ZC,HJLB=@HJLB,HJDXZQH=@HJDXZQH,HJDXZ=@HJDXZ,JZDXZQH=@JZDXZQH,JZDXZ=@JZDXZ,JZDYZBM=@JZDYZBM,LXDH=@LXDH,JTDH=@JTDH,DASZD=@DASZD,SFYJZZ=@SFYJZZ,JZZQSRQ=@JZZQSRQ,JZZJZRQ=@JZZJZRQ,SFYLDSC=@SFYLDSC,SFBLGSBJJ=@SFBLGSBJJ,SFBLGGJJ=@SFBLGGJJ,GJJZH=@GJJZH,SFBLGZHBX=@SFBLGZHBX,YDWSFBLTG=@YDWSFBLTG,RYLB=@RYLB,SCRZRQ=@SCRZRQ,LZRQ=@LZRQ,LZYY=@LZYY,GXRID=@GXRID,GXRXM=@GXRXM,GXLX=@GXLX,GXYY=@GXYY,GXSJ=@GXSJ where " + strDBColumnName + " = @Id", new SqlParameter("RID", model.RID), new SqlParameter("GH", model.GH), new SqlParameter("XM", model.XM), new SqlParameter("JG", model.JG), new SqlParameter("SSBM", model.SSBM), new SqlParameter("ZW", model.ZW), new SqlParameter("ZJHM", model.ZJHM), new SqlParameter("ZJZL", model.ZJZL), new SqlParameter("XB", model.XB), new SqlParameter("ZZMM", model.ZZMM), new SqlParameter("CSRQ", model.CSRQ), new SqlParameter("MZ", model.MZ), new SqlParameter("HYZK", model.HYZK), new SqlParameter("XL", model.XL), new SqlParameter("XW", model.XW), new SqlParameter("BYRQ", model.BYRQ), new SqlParameter("BYXX", model.BYXX), new SqlParameter("SXZY", model.SXZY), new SqlParameter("ZC", model.ZC), new SqlParameter("HJLB", model.HJLB), new SqlParameter("HJDXZQH", model.HJDXZQH), new SqlParameter("HJDXZ", model.HJDXZ), new SqlParameter("JZDXZQH", model.JZDXZQH), new SqlParameter("JZDXZ", model.JZDXZ), new SqlParameter("JZDYZBM", model.JZDYZBM), new SqlParameter("LXDH", model.LXDH), new SqlParameter("JTDH", model.JTDH), new SqlParameter("DASZD", model.DASZD), new SqlParameter("SFYJZZ", model.SFYJZZ), new SqlParameter("JZZQSRQ", model.JZZQSRQ), new SqlParameter("JZZJZRQ", model.JZZJZRQ), new SqlParameter("SFYLDSC", model.SFYLDSC), new SqlParameter("SFBLGSBJJ", model.SFBLGSBJJ), new SqlParameter("SFBLGGJJ", model.SFBLGGJJ), new SqlParameter("GJJZH", model.GJJZH), new SqlParameter("SFBLGZHBX", model.SFBLGZHBX), new SqlParameter("YDWSFBLTG", model.YDWSFBLTG), new SqlParameter("RYLB", model.RYLB), new SqlParameter("SCRZRQ", model.SCRZRQ), new SqlParameter("LZRQ", model.LZRQ), new SqlParameter("LZYY", model.LZYY), new SqlParameter("GXRID", model.GXRID), new SqlParameter("GXRXM", model.GXRXM), new SqlParameter("GXLX", model.GXLX), new SqlParameter("GXYY", model.GXYY), new SqlParameter("GXSJ", model.GXSJ), new SqlParameter("Id", strUpdateId));
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
            int e = SqlHelper.ExecuteNonQuery("update T_HR_YGJBXX set " + updateDBColumnName + " = " + updateDBColumnValue + " where " + strAccord + " in (" + str + ")");
            return e;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGJBXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGJBXX SelectSingleModelByReader(string strDBColumnName, string strSelId)
        {
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_YGJBXX where " + strDBColumnName + " = @ID", new SqlParameter("ID", strSelId)))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        T_HR_YGJBXX model = new T_HR_YGJBXX();
                        model.RID = reader.IsDBNull(0) ? null : reader.GetString(0);
                        model.GH = reader.IsDBNull(1) ? null : reader.GetString(1);
                        model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                        model.JG = reader.IsDBNull(3) ? null : reader.GetString(3);
                        model.SSBM = reader.IsDBNull(4) ? null : reader.GetString(4);
                        model.ZW = reader.IsDBNull(5) ? null : reader.GetString(5);
                        model.ZJHM = reader.IsDBNull(6) ? null : reader.GetString(6);
                        model.ZJZL = reader.IsDBNull(7) ? null : reader.GetString(7);
                        model.XB = reader.IsDBNull(8) ? null : reader.GetString(8);
                        model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                        model.CSRQ = reader.IsDBNull(10) ? null : reader.GetString(10);
                        model.MZ = reader.IsDBNull(11) ? null : reader.GetString(11);
                        model.HYZK = reader.IsDBNull(12) ? null : reader.GetString(12);
                        model.XL = reader.IsDBNull(13) ? null : reader.GetString(13);
                        model.XW = reader.IsDBNull(14) ? null : reader.GetString(14);
                        model.BYRQ = reader.IsDBNull(15) ? null : (DateTime?)reader.GetDateTime(15);
                        model.BYXX = reader.IsDBNull(16) ? null : reader.GetString(16);
                        model.SXZY = reader.IsDBNull(17) ? null : reader.GetString(17);
                        model.ZC = reader.IsDBNull(18) ? null : reader.GetString(18);
                        model.HJLB = reader.IsDBNull(19) ? null : reader.GetString(19);
                        model.HJDXZQH = reader.IsDBNull(20) ? null : reader.GetString(20);
                        model.HJDXZ = reader.IsDBNull(21) ? null : reader.GetString(21);
                        model.JZDXZQH = reader.IsDBNull(22) ? null : reader.GetString(22);
                        model.JZDXZ = reader.IsDBNull(23) ? null : reader.GetString(23);
                        model.JZDYZBM = reader.IsDBNull(24) ? null : reader.GetString(24);
                        model.LXDH = reader.IsDBNull(25) ? null : reader.GetString(25);
                        model.JTDH = reader.IsDBNull(26) ? null : reader.GetString(26);
                        model.DASZD = reader.IsDBNull(27) ? null : reader.GetString(27);
                        model.SFYJZZ = reader.IsDBNull(28) ? null : reader.GetString(28);
                        model.JZZQSRQ = reader.IsDBNull(29) ? null : (DateTime?)reader.GetDateTime(29);
                        model.JZZJZRQ = reader.IsDBNull(30) ? null : (DateTime?)reader.GetDateTime(30);
                        model.SFYLDSC = reader.IsDBNull(31) ? null : reader.GetString(31);
                        model.SFBLGSBJJ = reader.IsDBNull(32) ? null : reader.GetString(32);
                        model.SFBLGGJJ = reader.IsDBNull(33) ? null : reader.GetString(33);
                        model.GJJZH = reader.IsDBNull(34) ? null : reader.GetString(34);
                        model.SFBLGZHBX = reader.IsDBNull(35) ? null : reader.GetString(35);
                        model.YDWSFBLTG = reader.IsDBNull(36) ? null : reader.GetString(36);
                        model.RYLB = reader.IsDBNull(37) ? null : reader.GetString(37);
                        model.SCRZRQ = reader.IsDBNull(38) ? null : (DateTime?)reader.GetDateTime(38);
                        model.LZRQ = reader.IsDBNull(39) ? null : (DateTime?)reader.GetDateTime(39);
                        model.LZYY = reader.IsDBNull(40) ? null : reader.GetString(40);
                        model.GXRID = reader.IsDBNull(41) ? null : reader.GetString(41);
                        model.GXRXM = reader.IsDBNull(42) ? null : reader.GetString(42);
                        model.GXLX = reader.IsDBNull(43) ? null : reader.GetString(43);
                        model.GXYY = reader.IsDBNull(44) ? null : reader.GetString(44);
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
        ///DAL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGJBXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGJBXX SelectSingleModelByAdapter(string strDBColumnName, string strSelId)
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_YGJBXX where " + strDBColumnName + " = @ID", new SqlParameter("ID", strSelId));
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else if (dt.Rows.Count == 1)
            {
                T_HR_YGJBXX model = new T_HR_YGJBXX();
                DataRow dr = dt.Rows[0];
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.GH = (dr["GH"] == DBNull.Value) ? null : (string)dr["GH"];
                model.XM = (dr["XM"] == DBNull.Value) ? null : (string)dr["XM"];
                model.JG = (dr["JG"] == DBNull.Value) ? null : (string)dr["JG"];
                model.SSBM = (dr["SSBM"] == DBNull.Value) ? null : (string)dr["SSBM"];
                model.ZW = (dr["ZW"] == DBNull.Value) ? null : (string)dr["ZW"];
                model.ZJHM = (dr["ZJHM"] == DBNull.Value) ? null : (string)dr["ZJHM"];
                model.ZJZL = (dr["ZJZL"] == DBNull.Value) ? null : (string)dr["ZJZL"];
                model.XB = (dr["XB"] == DBNull.Value) ? null : (string)dr["XB"];
                model.ZZMM = (dr["ZZMM"] == DBNull.Value) ? null : (string)dr["ZZMM"];
                model.CSRQ = (dr["CSRQ"] == DBNull.Value) ? null : (string)dr["CSRQ"];
                model.MZ = (dr["MZ"] == DBNull.Value) ? null : (string)dr["MZ"];
                model.HYZK = (dr["HYZK"] == DBNull.Value) ? null : (string)dr["HYZK"];
                model.XL = (dr["XL"] == DBNull.Value) ? null : (string)dr["XL"];
                model.XW = (dr["XW"] == DBNull.Value) ? null : (string)dr["XW"];
                model.BYRQ = (dr["BYRQ"] == DBNull.Value) ? null : (DateTime?)dr["BYRQ"];
                model.BYXX = (dr["BYXX"] == DBNull.Value) ? null : (string)dr["BYXX"];
                model.SXZY = (dr["SXZY"] == DBNull.Value) ? null : (string)dr["SXZY"];
                model.ZC = (dr["ZC"] == DBNull.Value) ? null : (string)dr["ZC"];
                model.HJLB = (dr["HJLB"] == DBNull.Value) ? null : (string)dr["HJLB"];
                model.HJDXZQH = (dr["HJDXZQH"] == DBNull.Value) ? null : (string)dr["HJDXZQH"];
                model.HJDXZ = (dr["HJDXZ"] == DBNull.Value) ? null : (string)dr["HJDXZ"];
                model.JZDXZQH = (dr["JZDXZQH"] == DBNull.Value) ? null : (string)dr["JZDXZQH"];
                model.JZDXZ = (dr["JZDXZ"] == DBNull.Value) ? null : (string)dr["JZDXZ"];
                model.JZDYZBM = (dr["JZDYZBM"] == DBNull.Value) ? null : (string)dr["JZDYZBM"];
                model.LXDH = (dr["LXDH"] == DBNull.Value) ? null : (string)dr["LXDH"];
                model.JTDH = (dr["JTDH"] == DBNull.Value) ? null : (string)dr["JTDH"];
                model.DASZD = (dr["DASZD"] == DBNull.Value) ? null : (string)dr["DASZD"];
                model.SFYJZZ = (dr["SFYJZZ"] == DBNull.Value) ? null : (string)dr["SFYJZZ"];
                model.JZZQSRQ = (dr["JZZQSRQ"] == DBNull.Value) ? null : (DateTime?)dr["JZZQSRQ"];
                model.JZZJZRQ = (dr["JZZJZRQ"] == DBNull.Value) ? null : (DateTime?)dr["JZZJZRQ"];
                model.SFYLDSC = (dr["SFYLDSC"] == DBNull.Value) ? null : (string)dr["SFYLDSC"];
                model.SFBLGSBJJ = (dr["SFBLGSBJJ"] == DBNull.Value) ? null : (string)dr["SFBLGSBJJ"];
                model.SFBLGGJJ = (dr["SFBLGGJJ"] == DBNull.Value) ? null : (string)dr["SFBLGGJJ"];
                model.GJJZH = (dr["GJJZH"] == DBNull.Value) ? null : (string)dr["GJJZH"];
                model.SFBLGZHBX = (dr["SFBLGZHBX"] == DBNull.Value) ? null : (string)dr["SFBLGZHBX"];
                model.YDWSFBLTG = (dr["YDWSFBLTG"] == DBNull.Value) ? null : (string)dr["YDWSFBLTG"];
                model.RYLB = (dr["RYLB"] == DBNull.Value) ? null : (string)dr["RYLB"];
                model.SCRZRQ = (dr["SCRZRQ"] == DBNull.Value) ? null : (DateTime?)dr["SCRZRQ"];
                model.LZRQ = (dr["LZRQ"] == DBNull.Value) ? null : (DateTime?)dr["LZRQ"];
                model.LZYY = (dr["LZYY"] == DBNull.Value) ? null : (string)dr["LZYY"];
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
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectAllByReader()
        {
            List<T_HR_YGJBXX> list = new List<T_HR_YGJBXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from T_HR_YGJBXX"))
            {
                while (reader.Read())
                {
                    T_HR_YGJBXX model = new T_HR_YGJBXX();
                    model.RID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.GH = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JG = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.SSBM = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.ZW = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.ZJHM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.ZJZL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XB = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.CSRQ = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.MZ = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.HYZK = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.XL = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.XW = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.BYRQ = reader.IsDBNull(15) ? null : (DateTime?)reader.GetDateTime(15);
                    model.BYXX = reader.IsDBNull(16) ? null : reader.GetString(16);
                    model.SXZY = reader.IsDBNull(17) ? null : reader.GetString(17);
                    model.ZC = reader.IsDBNull(18) ? null : reader.GetString(18);
                    model.HJLB = reader.IsDBNull(19) ? null : reader.GetString(19);
                    model.HJDXZQH = reader.IsDBNull(20) ? null : reader.GetString(20);
                    model.HJDXZ = reader.IsDBNull(21) ? null : reader.GetString(21);
                    model.JZDXZQH = reader.IsDBNull(22) ? null : reader.GetString(22);
                    model.JZDXZ = reader.IsDBNull(23) ? null : reader.GetString(23);
                    model.JZDYZBM = reader.IsDBNull(24) ? null : reader.GetString(24);
                    model.LXDH = reader.IsDBNull(25) ? null : reader.GetString(25);
                    model.JTDH = reader.IsDBNull(26) ? null : reader.GetString(26);
                    model.DASZD = reader.IsDBNull(27) ? null : reader.GetString(27);
                    model.SFYJZZ = reader.IsDBNull(28) ? null : reader.GetString(28);
                    model.JZZQSRQ = reader.IsDBNull(29) ? null : (DateTime?)reader.GetDateTime(29);
                    model.JZZJZRQ = reader.IsDBNull(30) ? null : (DateTime?)reader.GetDateTime(30);
                    model.SFYLDSC = reader.IsDBNull(31) ? null : reader.GetString(31);
                    model.SFBLGSBJJ = reader.IsDBNull(32) ? null : reader.GetString(32);
                    model.SFBLGGJJ = reader.IsDBNull(33) ? null : reader.GetString(33);
                    model.GJJZH = reader.IsDBNull(34) ? null : reader.GetString(34);
                    model.SFBLGZHBX = reader.IsDBNull(35) ? null : reader.GetString(35);
                    model.YDWSFBLTG = reader.IsDBNull(36) ? null : reader.GetString(36);
                    model.RYLB = reader.IsDBNull(37) ? null : reader.GetString(37);
                    model.SCRZRQ = reader.IsDBNull(38) ? null : (DateTime?)reader.GetDateTime(38);
                    model.LZRQ = reader.IsDBNull(39) ? null : (DateTime?)reader.GetDateTime(39);
                    model.LZYY = reader.IsDBNull(40) ? null : reader.GetString(40);
                    model.GXRID = reader.IsDBNull(41) ? null : reader.GetString(41);
                    model.GXRXM = reader.IsDBNull(42) ? null : reader.GetString(42);
                    model.GXLX = reader.IsDBNull(43) ? null : reader.GetString(43);
                    model.GXYY = reader.IsDBNull(44) ? null : reader.GetString(44);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///DAL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectAllByAdapter()
        {
            DataTable dt = SqlHelper.ExecuteDataTable("select * from T_HR_YGJBXX");
            return DataTableToList(dt);
        }
        #endregion

        #region 查找数据库中的数据条数
        /// <summary>
        ///DAL方法：查找数据库中的数据条数([例如：select Count(*) from... where "XXX"="YYY"],查询整体数据条数Count(*)请传入"1","1"-->sql语句拼接"where 1=1")------>请传入数据库的列名，数据库的值，返回首行首列
        /// </summary>
        /// <returns></returns>
        public int GetCount(string strDBColumnName, string strSelValue)
        {
            object count = SqlHelper.ExecuteScalar("select Count(*) from T_HR_YGJBXX where " + strDBColumnName + " = @SelValue", new SqlParameter("SelValue", strSelValue));
            return Convert.ToInt32(count);
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> FuzzyQueryByReader(bool RIDIsChecked, string RID, bool GHIsChecked, string GH, bool XMIsChecked, string XM, bool JGIsChecked, string JG, bool SSBMIsChecked, string SSBM, bool ZWIsChecked, string ZW, bool ZJHMIsChecked, string ZJHM, bool ZJZLIsChecked, string ZJZL, bool XBIsChecked, string XB, bool ZZMMIsChecked, string ZZMM, bool CSRQIsChecked, string CSRQ, bool MZIsChecked, string MZ, bool HYZKIsChecked, string HYZK, bool XLIsChecked, string XL, bool XWIsChecked, string XW, bool BYRQIsChecked, string BYRQ, bool BYXXIsChecked, string BYXX, bool SXZYIsChecked, string SXZY, bool ZCIsChecked, string ZC, bool HJLBIsChecked, string HJLB, bool HJDXZQHIsChecked, string HJDXZQH, bool HJDXZIsChecked, string HJDXZ, bool JZDXZQHIsChecked, string JZDXZQH, bool JZDXZIsChecked, string JZDXZ, bool JZDYZBMIsChecked, string JZDYZBM, bool LXDHIsChecked, string LXDH, bool JTDHIsChecked, string JTDH, bool DASZDIsChecked, string DASZD, bool SFYJZZIsChecked, string SFYJZZ, bool JZZQSRQIsChecked, string JZZQSRQ, bool JZZJZRQIsChecked, string JZZJZRQ, bool SFYLDSCIsChecked, string SFYLDSC, bool SFBLGSBJJIsChecked, string SFBLGSBJJ, bool SFBLGGJJIsChecked, string SFBLGGJJ, bool GJJZHIsChecked, string GJJZH, bool SFBLGZHBXIsChecked, string SFBLGZHBX, bool YDWSFBLTGIsChecked, string YDWSFBLTG, bool RYLBIsChecked, string RYLB, bool SCRZRQIsChecked, string SCRZRQ, bool LZRQIsChecked, string LZRQ, bool LZYYIsChecked, string LZYY, bool GXRIDIsChecked, string GXRID, bool GXRXMIsChecked, string GXRXM, bool GXLXIsChecked, string GXLX, bool GXYYIsChecked, string GXYY, bool GXSJIsChecked, string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_YGJBXX");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if (RIDIsChecked)
            {
                list.Add("RID like @RID");
                listParameter.Add(new SqlParameter("RID", "%" + RID + "%"));
            }
            if (GHIsChecked)
            {
                list.Add("GH like @GH");
                listParameter.Add(new SqlParameter("GH", "%" + GH + "%"));
            }
            if (XMIsChecked)
            {
                list.Add("XM like @XM");
                listParameter.Add(new SqlParameter("XM", "%" + XM + "%"));
            }
            if (JGIsChecked)
            {
                list.Add("JG like @JG");
                listParameter.Add(new SqlParameter("JG", "%" + JG + "%"));
            }
            if (SSBMIsChecked)
            {
                list.Add("SSBM like @SSBM");
                listParameter.Add(new SqlParameter("SSBM", "%" + SSBM + "%"));
            }
            if (ZWIsChecked)
            {
                list.Add("ZW like @ZW");
                listParameter.Add(new SqlParameter("ZW", "%" + ZW + "%"));
            }
            if (ZJHMIsChecked)
            {
                list.Add("ZJHM like @ZJHM");
                listParameter.Add(new SqlParameter("ZJHM", "%" + ZJHM + "%"));
            }
            if (ZJZLIsChecked)
            {
                list.Add("ZJZL like @ZJZL");
                listParameter.Add(new SqlParameter("ZJZL", "%" + ZJZL + "%"));
            }
            if (XBIsChecked)
            {
                list.Add("XB like @XB");
                listParameter.Add(new SqlParameter("XB", "%" + XB + "%"));
            }
            if (ZZMMIsChecked)
            {
                list.Add("ZZMM like @ZZMM");
                listParameter.Add(new SqlParameter("ZZMM", "%" + ZZMM + "%"));
            }
            if (CSRQIsChecked)
            {
                list.Add("CSRQ like @CSRQ");
                listParameter.Add(new SqlParameter("CSRQ", "%" + CSRQ + "%"));
            }
            if (MZIsChecked)
            {
                list.Add("MZ like @MZ");
                listParameter.Add(new SqlParameter("MZ", "%" + MZ + "%"));
            }
            if (HYZKIsChecked)
            {
                list.Add("HYZK like @HYZK");
                listParameter.Add(new SqlParameter("HYZK", "%" + HYZK + "%"));
            }
            if (XLIsChecked)
            {
                list.Add("XL like @XL");
                listParameter.Add(new SqlParameter("XL", "%" + XL + "%"));
            }
            if (XWIsChecked)
            {
                list.Add("XW like @XW");
                listParameter.Add(new SqlParameter("XW", "%" + XW + "%"));
            }
            if (BYRQIsChecked)
            {
                list.Add("BYRQ like @BYRQ");
                listParameter.Add(new SqlParameter("BYRQ", "%" + BYRQ + "%"));
            }
            if (BYXXIsChecked)
            {
                list.Add("BYXX like @BYXX");
                listParameter.Add(new SqlParameter("BYXX", "%" + BYXX + "%"));
            }
            if (SXZYIsChecked)
            {
                list.Add("SXZY like @SXZY");
                listParameter.Add(new SqlParameter("SXZY", "%" + SXZY + "%"));
            }
            if (ZCIsChecked)
            {
                list.Add("ZC like @ZC");
                listParameter.Add(new SqlParameter("ZC", "%" + ZC + "%"));
            }
            if (HJLBIsChecked)
            {
                list.Add("HJLB like @HJLB");
                listParameter.Add(new SqlParameter("HJLB", "%" + HJLB + "%"));
            }
            if (HJDXZQHIsChecked)
            {
                list.Add("HJDXZQH like @HJDXZQH");
                listParameter.Add(new SqlParameter("HJDXZQH", "%" + HJDXZQH + "%"));
            }
            if (HJDXZIsChecked)
            {
                list.Add("HJDXZ like @HJDXZ");
                listParameter.Add(new SqlParameter("HJDXZ", "%" + HJDXZ + "%"));
            }
            if (JZDXZQHIsChecked)
            {
                list.Add("JZDXZQH like @JZDXZQH");
                listParameter.Add(new SqlParameter("JZDXZQH", "%" + JZDXZQH + "%"));
            }
            if (JZDXZIsChecked)
            {
                list.Add("JZDXZ like @JZDXZ");
                listParameter.Add(new SqlParameter("JZDXZ", "%" + JZDXZ + "%"));
            }
            if (JZDYZBMIsChecked)
            {
                list.Add("JZDYZBM like @JZDYZBM");
                listParameter.Add(new SqlParameter("JZDYZBM", "%" + JZDYZBM + "%"));
            }
            if (LXDHIsChecked)
            {
                list.Add("LXDH like @LXDH");
                listParameter.Add(new SqlParameter("LXDH", "%" + LXDH + "%"));
            }
            if (JTDHIsChecked)
            {
                list.Add("JTDH like @JTDH");
                listParameter.Add(new SqlParameter("JTDH", "%" + JTDH + "%"));
            }
            if (DASZDIsChecked)
            {
                list.Add("DASZD like @DASZD");
                listParameter.Add(new SqlParameter("DASZD", "%" + DASZD + "%"));
            }
            if (SFYJZZIsChecked)
            {
                list.Add("SFYJZZ like @SFYJZZ");
                listParameter.Add(new SqlParameter("SFYJZZ", "%" + SFYJZZ + "%"));
            }
            if (JZZQSRQIsChecked)
            {
                list.Add("JZZQSRQ like @JZZQSRQ");
                listParameter.Add(new SqlParameter("JZZQSRQ", "%" + JZZQSRQ + "%"));
            }
            if (JZZJZRQIsChecked)
            {
                list.Add("JZZJZRQ like @JZZJZRQ");
                listParameter.Add(new SqlParameter("JZZJZRQ", "%" + JZZJZRQ + "%"));
            }
            if (SFYLDSCIsChecked)
            {
                list.Add("SFYLDSC like @SFYLDSC");
                listParameter.Add(new SqlParameter("SFYLDSC", "%" + SFYLDSC + "%"));
            }
            if (SFBLGSBJJIsChecked)
            {
                list.Add("SFBLGSBJJ like @SFBLGSBJJ");
                listParameter.Add(new SqlParameter("SFBLGSBJJ", "%" + SFBLGSBJJ + "%"));
            }
            if (SFBLGGJJIsChecked)
            {
                list.Add("SFBLGGJJ like @SFBLGGJJ");
                listParameter.Add(new SqlParameter("SFBLGGJJ", "%" + SFBLGGJJ + "%"));
            }
            if (GJJZHIsChecked)
            {
                list.Add("GJJZH like @GJJZH");
                listParameter.Add(new SqlParameter("GJJZH", "%" + GJJZH + "%"));
            }
            if (SFBLGZHBXIsChecked)
            {
                list.Add("SFBLGZHBX like @SFBLGZHBX");
                listParameter.Add(new SqlParameter("SFBLGZHBX", "%" + SFBLGZHBX + "%"));
            }
            if (YDWSFBLTGIsChecked)
            {
                list.Add("YDWSFBLTG like @YDWSFBLTG");
                listParameter.Add(new SqlParameter("YDWSFBLTG", "%" + YDWSFBLTG + "%"));
            }
            if (RYLBIsChecked)
            {
                list.Add("RYLB like @RYLB");
                listParameter.Add(new SqlParameter("RYLB", "%" + RYLB + "%"));
            }
            if (SCRZRQIsChecked)
            {
                list.Add("SCRZRQ like @SCRZRQ");
                listParameter.Add(new SqlParameter("SCRZRQ", "%" + SCRZRQ + "%"));
            }
            if (LZRQIsChecked)
            {
                list.Add("LZRQ like @LZRQ");
                listParameter.Add(new SqlParameter("LZRQ", "%" + LZRQ + "%"));
            }
            if (LZYYIsChecked)
            {
                list.Add("LZYY like @LZYY");
                listParameter.Add(new SqlParameter("LZYY", "%" + LZYY + "%"));
            }
            if (GXRIDIsChecked)
            {
                list.Add("GXRID like @GXRID");
                listParameter.Add(new SqlParameter("GXRID", "%" + GXRID + "%"));
            }
            if (GXRXMIsChecked)
            {
                list.Add("GXRXM like @GXRXM");
                listParameter.Add(new SqlParameter("GXRXM", "%" + GXRXM + "%"));
            }
            if (GXLXIsChecked)
            {
                list.Add("GXLX like @GXLX");
                listParameter.Add(new SqlParameter("GXLX", "%" + GXLX + "%"));
            }
            if (GXYYIsChecked)
            {
                list.Add("GXYY like @GXYY");
                listParameter.Add(new SqlParameter("GXYY", "%" + GXYY + "%"));
            }
            if (GXSJIsChecked)
            {
                list.Add("GXSJ like @GXSJ");
                listParameter.Add(new SqlParameter("GXSJ", "%" + GXSJ + "%"));
            }
            if (list.Count > 0)
            {
                sb.Append(" where ");
                string sql = string.Join(" and ", list.ToArray());
                sb.Append(sql);
            }
            List<T_HR_YGJBXX> listT_HR_YGJBXX = new List<T_HR_YGJBXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader(sb.ToString(), listParameter.ToArray()))
            {
                while (reader.Read())
                {
                    T_HR_YGJBXX model = new T_HR_YGJBXX();
                    model.RID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.GH = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JG = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.SSBM = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.ZW = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.ZJHM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.ZJZL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XB = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.CSRQ = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.MZ = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.HYZK = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.XL = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.XW = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.BYRQ = reader.IsDBNull(15) ? null : (DateTime?)reader.GetDateTime(15);
                    model.BYXX = reader.IsDBNull(16) ? null : reader.GetString(16);
                    model.SXZY = reader.IsDBNull(17) ? null : reader.GetString(17);
                    model.ZC = reader.IsDBNull(18) ? null : reader.GetString(18);
                    model.HJLB = reader.IsDBNull(19) ? null : reader.GetString(19);
                    model.HJDXZQH = reader.IsDBNull(20) ? null : reader.GetString(20);
                    model.HJDXZ = reader.IsDBNull(21) ? null : reader.GetString(21);
                    model.JZDXZQH = reader.IsDBNull(22) ? null : reader.GetString(22);
                    model.JZDXZ = reader.IsDBNull(23) ? null : reader.GetString(23);
                    model.JZDYZBM = reader.IsDBNull(24) ? null : reader.GetString(24);
                    model.LXDH = reader.IsDBNull(25) ? null : reader.GetString(25);
                    model.JTDH = reader.IsDBNull(26) ? null : reader.GetString(26);
                    model.DASZD = reader.IsDBNull(27) ? null : reader.GetString(27);
                    model.SFYJZZ = reader.IsDBNull(28) ? null : reader.GetString(28);
                    model.JZZQSRQ = reader.IsDBNull(29) ? null : (DateTime?)reader.GetDateTime(29);
                    model.JZZJZRQ = reader.IsDBNull(30) ? null : (DateTime?)reader.GetDateTime(30);
                    model.SFYLDSC = reader.IsDBNull(31) ? null : reader.GetString(31);
                    model.SFBLGSBJJ = reader.IsDBNull(32) ? null : reader.GetString(32);
                    model.SFBLGGJJ = reader.IsDBNull(33) ? null : reader.GetString(33);
                    model.GJJZH = reader.IsDBNull(34) ? null : reader.GetString(34);
                    model.SFBLGZHBX = reader.IsDBNull(35) ? null : reader.GetString(35);
                    model.YDWSFBLTG = reader.IsDBNull(36) ? null : reader.GetString(36);
                    model.RYLB = reader.IsDBNull(37) ? null : reader.GetString(37);
                    model.SCRZRQ = reader.IsDBNull(38) ? null : (DateTime?)reader.GetDateTime(38);
                    model.LZRQ = reader.IsDBNull(39) ? null : (DateTime?)reader.GetDateTime(39);
                    model.LZYY = reader.IsDBNull(40) ? null : reader.GetString(40);
                    model.GXRID = reader.IsDBNull(41) ? null : reader.GetString(41);
                    model.GXRXM = reader.IsDBNull(42) ? null : reader.GetString(42);
                    model.GXLX = reader.IsDBNull(43) ? null : reader.GetString(43);
                    model.GXYY = reader.IsDBNull(44) ? null : reader.GetString(44);
                    listT_HR_YGJBXX.Add(model);
                }
            }
            return listT_HR_YGJBXX;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///DAL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> FuzzyQueryByAdapter(bool RIDIsChecked, string RID, bool GHIsChecked, string GH, bool XMIsChecked, string XM, bool JGIsChecked, string JG, bool SSBMIsChecked, string SSBM, bool ZWIsChecked, string ZW, bool ZJHMIsChecked, string ZJHM, bool ZJZLIsChecked, string ZJZL, bool XBIsChecked, string XB, bool ZZMMIsChecked, string ZZMM, bool CSRQIsChecked, string CSRQ, bool MZIsChecked, string MZ, bool HYZKIsChecked, string HYZK, bool XLIsChecked, string XL, bool XWIsChecked, string XW, bool BYRQIsChecked, string BYRQ, bool BYXXIsChecked, string BYXX, bool SXZYIsChecked, string SXZY, bool ZCIsChecked, string ZC, bool HJLBIsChecked, string HJLB, bool HJDXZQHIsChecked, string HJDXZQH, bool HJDXZIsChecked, string HJDXZ, bool JZDXZQHIsChecked, string JZDXZQH, bool JZDXZIsChecked, string JZDXZ, bool JZDYZBMIsChecked, string JZDYZBM, bool LXDHIsChecked, string LXDH, bool JTDHIsChecked, string JTDH, bool DASZDIsChecked, string DASZD, bool SFYJZZIsChecked, string SFYJZZ, bool JZZQSRQIsChecked, string JZZQSRQ, bool JZZJZRQIsChecked, string JZZJZRQ, bool SFYLDSCIsChecked, string SFYLDSC, bool SFBLGSBJJIsChecked, string SFBLGSBJJ, bool SFBLGGJJIsChecked, string SFBLGGJJ, bool GJJZHIsChecked, string GJJZH, bool SFBLGZHBXIsChecked, string SFBLGZHBX, bool YDWSFBLTGIsChecked, string YDWSFBLTG, bool RYLBIsChecked, string RYLB, bool SCRZRQIsChecked, string SCRZRQ, bool LZRQIsChecked, string LZRQ, bool LZYYIsChecked, string LZYY, bool GXRIDIsChecked, string GXRID, bool GXRXMIsChecked, string GXRXM, bool GXLXIsChecked, string GXLX, bool GXYYIsChecked, string GXYY, bool GXSJIsChecked, string GXSJ)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from T_HR_YGJBXX");
            List<string> list = new List<string>();
            List<SqlParameter> listParameter = new List<SqlParameter>();
            if (RIDIsChecked)
            {
                list.Add("RID like @RID");
                listParameter.Add(new SqlParameter("RID", "%" + RID + "%"));
            }
            if (GHIsChecked)
            {
                list.Add("GH like @GH");
                listParameter.Add(new SqlParameter("GH", "%" + GH + "%"));
            }
            if (XMIsChecked)
            {
                list.Add("XM like @XM");
                listParameter.Add(new SqlParameter("XM", "%" + XM + "%"));
            }
            if (JGIsChecked)
            {
                list.Add("JG like @JG");
                listParameter.Add(new SqlParameter("JG", "%" + JG + "%"));
            }
            if (SSBMIsChecked)
            {
                list.Add("SSBM like @SSBM");
                listParameter.Add(new SqlParameter("SSBM", "%" + SSBM + "%"));
            }
            if (ZWIsChecked)
            {
                list.Add("ZW like @ZW");
                listParameter.Add(new SqlParameter("ZW", "%" + ZW + "%"));
            }
            if (ZJHMIsChecked)
            {
                list.Add("ZJHM like @ZJHM");
                listParameter.Add(new SqlParameter("ZJHM", "%" + ZJHM + "%"));
            }
            if (ZJZLIsChecked)
            {
                list.Add("ZJZL like @ZJZL");
                listParameter.Add(new SqlParameter("ZJZL", "%" + ZJZL + "%"));
            }
            if (XBIsChecked)
            {
                list.Add("XB like @XB");
                listParameter.Add(new SqlParameter("XB", "%" + XB + "%"));
            }
            if (ZZMMIsChecked)
            {
                list.Add("ZZMM like @ZZMM");
                listParameter.Add(new SqlParameter("ZZMM", "%" + ZZMM + "%"));
            }
            if (CSRQIsChecked)
            {
                list.Add("CSRQ like @CSRQ");
                listParameter.Add(new SqlParameter("CSRQ", "%" + CSRQ + "%"));
            }
            if (MZIsChecked)
            {
                list.Add("MZ like @MZ");
                listParameter.Add(new SqlParameter("MZ", "%" + MZ + "%"));
            }
            if (HYZKIsChecked)
            {
                list.Add("HYZK like @HYZK");
                listParameter.Add(new SqlParameter("HYZK", "%" + HYZK + "%"));
            }
            if (XLIsChecked)
            {
                list.Add("XL like @XL");
                listParameter.Add(new SqlParameter("XL", "%" + XL + "%"));
            }
            if (XWIsChecked)
            {
                list.Add("XW like @XW");
                listParameter.Add(new SqlParameter("XW", "%" + XW + "%"));
            }
            if (BYRQIsChecked)
            {
                list.Add("BYRQ like @BYRQ");
                listParameter.Add(new SqlParameter("BYRQ", "%" + BYRQ + "%"));
            }
            if (BYXXIsChecked)
            {
                list.Add("BYXX like @BYXX");
                listParameter.Add(new SqlParameter("BYXX", "%" + BYXX + "%"));
            }
            if (SXZYIsChecked)
            {
                list.Add("SXZY like @SXZY");
                listParameter.Add(new SqlParameter("SXZY", "%" + SXZY + "%"));
            }
            if (ZCIsChecked)
            {
                list.Add("ZC like @ZC");
                listParameter.Add(new SqlParameter("ZC", "%" + ZC + "%"));
            }
            if (HJLBIsChecked)
            {
                list.Add("HJLB like @HJLB");
                listParameter.Add(new SqlParameter("HJLB", "%" + HJLB + "%"));
            }
            if (HJDXZQHIsChecked)
            {
                list.Add("HJDXZQH like @HJDXZQH");
                listParameter.Add(new SqlParameter("HJDXZQH", "%" + HJDXZQH + "%"));
            }
            if (HJDXZIsChecked)
            {
                list.Add("HJDXZ like @HJDXZ");
                listParameter.Add(new SqlParameter("HJDXZ", "%" + HJDXZ + "%"));
            }
            if (JZDXZQHIsChecked)
            {
                list.Add("JZDXZQH like @JZDXZQH");
                listParameter.Add(new SqlParameter("JZDXZQH", "%" + JZDXZQH + "%"));
            }
            if (JZDXZIsChecked)
            {
                list.Add("JZDXZ like @JZDXZ");
                listParameter.Add(new SqlParameter("JZDXZ", "%" + JZDXZ + "%"));
            }
            if (JZDYZBMIsChecked)
            {
                list.Add("JZDYZBM like @JZDYZBM");
                listParameter.Add(new SqlParameter("JZDYZBM", "%" + JZDYZBM + "%"));
            }
            if (LXDHIsChecked)
            {
                list.Add("LXDH like @LXDH");
                listParameter.Add(new SqlParameter("LXDH", "%" + LXDH + "%"));
            }
            if (JTDHIsChecked)
            {
                list.Add("JTDH like @JTDH");
                listParameter.Add(new SqlParameter("JTDH", "%" + JTDH + "%"));
            }
            if (DASZDIsChecked)
            {
                list.Add("DASZD like @DASZD");
                listParameter.Add(new SqlParameter("DASZD", "%" + DASZD + "%"));
            }
            if (SFYJZZIsChecked)
            {
                list.Add("SFYJZZ like @SFYJZZ");
                listParameter.Add(new SqlParameter("SFYJZZ", "%" + SFYJZZ + "%"));
            }
            if (JZZQSRQIsChecked)
            {
                list.Add("JZZQSRQ like @JZZQSRQ");
                listParameter.Add(new SqlParameter("JZZQSRQ", "%" + JZZQSRQ + "%"));
            }
            if (JZZJZRQIsChecked)
            {
                list.Add("JZZJZRQ like @JZZJZRQ");
                listParameter.Add(new SqlParameter("JZZJZRQ", "%" + JZZJZRQ + "%"));
            }
            if (SFYLDSCIsChecked)
            {
                list.Add("SFYLDSC like @SFYLDSC");
                listParameter.Add(new SqlParameter("SFYLDSC", "%" + SFYLDSC + "%"));
            }
            if (SFBLGSBJJIsChecked)
            {
                list.Add("SFBLGSBJJ like @SFBLGSBJJ");
                listParameter.Add(new SqlParameter("SFBLGSBJJ", "%" + SFBLGSBJJ + "%"));
            }
            if (SFBLGGJJIsChecked)
            {
                list.Add("SFBLGGJJ like @SFBLGGJJ");
                listParameter.Add(new SqlParameter("SFBLGGJJ", "%" + SFBLGGJJ + "%"));
            }
            if (GJJZHIsChecked)
            {
                list.Add("GJJZH like @GJJZH");
                listParameter.Add(new SqlParameter("GJJZH", "%" + GJJZH + "%"));
            }
            if (SFBLGZHBXIsChecked)
            {
                list.Add("SFBLGZHBX like @SFBLGZHBX");
                listParameter.Add(new SqlParameter("SFBLGZHBX", "%" + SFBLGZHBX + "%"));
            }
            if (YDWSFBLTGIsChecked)
            {
                list.Add("YDWSFBLTG like @YDWSFBLTG");
                listParameter.Add(new SqlParameter("YDWSFBLTG", "%" + YDWSFBLTG + "%"));
            }
            if (RYLBIsChecked)
            {
                list.Add("RYLB like @RYLB");
                listParameter.Add(new SqlParameter("RYLB", "%" + RYLB + "%"));
            }
            if (SCRZRQIsChecked)
            {
                list.Add("SCRZRQ like @SCRZRQ");
                listParameter.Add(new SqlParameter("SCRZRQ", "%" + SCRZRQ + "%"));
            }
            if (LZRQIsChecked)
            {
                list.Add("LZRQ like @LZRQ");
                listParameter.Add(new SqlParameter("LZRQ", "%" + LZRQ + "%"));
            }
            if (LZYYIsChecked)
            {
                list.Add("LZYY like @LZYY");
                listParameter.Add(new SqlParameter("LZYY", "%" + LZYY + "%"));
            }
            if (GXRIDIsChecked)
            {
                list.Add("GXRID like @GXRID");
                listParameter.Add(new SqlParameter("GXRID", "%" + GXRID + "%"));
            }
            if (GXRXMIsChecked)
            {
                list.Add("GXRXM like @GXRXM");
                listParameter.Add(new SqlParameter("GXRXM", "%" + GXRXM + "%"));
            }
            if (GXLXIsChecked)
            {
                list.Add("GXLX like @GXLX");
                listParameter.Add(new SqlParameter("GXLX", "%" + GXLX + "%"));
            }
            if (GXYYIsChecked)
            {
                list.Add("GXYY like @GXYY");
                listParameter.Add(new SqlParameter("GXYY", "%" + GXYY + "%"));
            }
            if (GXSJIsChecked)
            {
                list.Add("GXSJ like @GXSJ");
                listParameter.Add(new SqlParameter("GXSJ", "%" + GXSJ + "%"));
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
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageUsingReader(int pageIndex, int pageSize, string strAccord, string strASCorDESC)
        {
            List<T_HR_YGJBXX> list = new List<T_HR_YGJBXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select top " + pageSize + " * from T_HR_YGJBXX  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_YGJBXX order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + ""))
            {
                while (reader.Read())
                {
                    T_HR_YGJBXX model = new T_HR_YGJBXX();
                    model.RID = reader.IsDBNull(0) ? null : reader.GetString(0);
                    model.GH = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.XM = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.JG = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.SSBM = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.ZW = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.ZJHM = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.ZJZL = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.XB = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.ZZMM = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.CSRQ = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.MZ = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.HYZK = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.XL = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.XW = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.BYRQ = reader.IsDBNull(15) ? null : (DateTime?)reader.GetDateTime(15);
                    model.BYXX = reader.IsDBNull(16) ? null : reader.GetString(16);
                    model.SXZY = reader.IsDBNull(17) ? null : reader.GetString(17);
                    model.ZC = reader.IsDBNull(18) ? null : reader.GetString(18);
                    model.HJLB = reader.IsDBNull(19) ? null : reader.GetString(19);
                    model.HJDXZQH = reader.IsDBNull(20) ? null : reader.GetString(20);
                    model.HJDXZ = reader.IsDBNull(21) ? null : reader.GetString(21);
                    model.JZDXZQH = reader.IsDBNull(22) ? null : reader.GetString(22);
                    model.JZDXZ = reader.IsDBNull(23) ? null : reader.GetString(23);
                    model.JZDYZBM = reader.IsDBNull(24) ? null : reader.GetString(24);
                    model.LXDH = reader.IsDBNull(25) ? null : reader.GetString(25);
                    model.JTDH = reader.IsDBNull(26) ? null : reader.GetString(26);
                    model.DASZD = reader.IsDBNull(27) ? null : reader.GetString(27);
                    model.SFYJZZ = reader.IsDBNull(28) ? null : reader.GetString(28);
                    model.JZZQSRQ = reader.IsDBNull(29) ? null : (DateTime?)reader.GetDateTime(29);
                    model.JZZJZRQ = reader.IsDBNull(30) ? null : (DateTime?)reader.GetDateTime(30);
                    model.SFYLDSC = reader.IsDBNull(31) ? null : reader.GetString(31);
                    model.SFBLGSBJJ = reader.IsDBNull(32) ? null : reader.GetString(32);
                    model.SFBLGGJJ = reader.IsDBNull(33) ? null : reader.GetString(33);
                    model.GJJZH = reader.IsDBNull(34) ? null : reader.GetString(34);
                    model.SFBLGZHBX = reader.IsDBNull(35) ? null : reader.GetString(35);
                    model.YDWSFBLTG = reader.IsDBNull(36) ? null : reader.GetString(36);
                    model.RYLB = reader.IsDBNull(37) ? null : reader.GetString(37);
                    model.SCRZRQ = reader.IsDBNull(38) ? null : (DateTime?)reader.GetDateTime(38);
                    model.LZRQ = reader.IsDBNull(39) ? null : (DateTime?)reader.GetDateTime(39);
                    model.LZYY = reader.IsDBNull(40) ? null : reader.GetString(40);
                    model.GXRID = reader.IsDBNull(41) ? null : reader.GetString(41);
                    model.GXRXM = reader.IsDBNull(42) ? null : reader.GetString(42);
                    model.GXLX = reader.IsDBNull(43) ? null : reader.GetString(43);
                    model.GXYY = reader.IsDBNull(44) ? null : reader.GetString(44);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[例如：select top pageSize * from...where strAccord not in...(select top pageSize strAccord from...)][说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageUsingAdapter(int pageIndex, int pageSize, string strAccord, string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select top " + pageSize + " * from T_HR_YGJBXX  where " + strAccord + " not in (select top " + (pageIndex - 1) * pageSize + " " + strAccord + " from T_HR_YGJBXX order by " + strAccord + " " + strASCorDESC + ") order by " + strAccord + " " + strASCorDESC + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageRow_NumberUsingReader(int pageIndex, int pageSize, string strAccord, string strASCorDESC)
        {
            List<T_HR_YGJBXX> list = new List<T_HR_YGJBXX>();
            using (SqlDataReader reader = SqlHelper.ExcuteReader("select * from ( select row_number() over(order by " + strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_YGJBXX )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<=" + (((pageIndex - 1) * pageSize) + pageSize).ToString() + ""))
            {
                while (reader.Read())
                {
                    T_HR_YGJBXX model = new T_HR_YGJBXX();
                    //开窗函数会多出一列，第一列为rownum，所以传入索引1开始
                    model.RID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    model.GH = reader.IsDBNull(2) ? null : reader.GetString(2);
                    model.XM = reader.IsDBNull(3) ? null : reader.GetString(3);
                    model.JG = reader.IsDBNull(4) ? null : reader.GetString(4);
                    model.SSBM = reader.IsDBNull(5) ? null : reader.GetString(5);
                    model.ZW = reader.IsDBNull(6) ? null : reader.GetString(6);
                    model.ZJHM = reader.IsDBNull(7) ? null : reader.GetString(7);
                    model.ZJZL = reader.IsDBNull(8) ? null : reader.GetString(8);
                    model.XB = reader.IsDBNull(9) ? null : reader.GetString(9);
                    model.ZZMM = reader.IsDBNull(10) ? null : reader.GetString(10);
                    model.CSRQ = reader.IsDBNull(11) ? null : reader.GetString(11);
                    model.MZ = reader.IsDBNull(12) ? null : reader.GetString(12);
                    model.HYZK = reader.IsDBNull(13) ? null : reader.GetString(13);
                    model.XL = reader.IsDBNull(14) ? null : reader.GetString(14);
                    model.XW = reader.IsDBNull(15) ? null : reader.GetString(15);
                    model.BYRQ = reader.IsDBNull(16) ? null : (DateTime?)reader.GetDateTime(16);
                    model.BYXX = reader.IsDBNull(17) ? null : reader.GetString(17);
                    model.SXZY = reader.IsDBNull(18) ? null : reader.GetString(18);
                    model.ZC = reader.IsDBNull(19) ? null : reader.GetString(19);
                    model.HJLB = reader.IsDBNull(20) ? null : reader.GetString(20);
                    model.HJDXZQH = reader.IsDBNull(21) ? null : reader.GetString(21);
                    model.HJDXZ = reader.IsDBNull(22) ? null : reader.GetString(22);
                    model.JZDXZQH = reader.IsDBNull(23) ? null : reader.GetString(23);
                    model.JZDXZ = reader.IsDBNull(24) ? null : reader.GetString(24);
                    model.JZDYZBM = reader.IsDBNull(25) ? null : reader.GetString(25);
                    model.LXDH = reader.IsDBNull(26) ? null : reader.GetString(26);
                    model.JTDH = reader.IsDBNull(27) ? null : reader.GetString(27);
                    model.DASZD = reader.IsDBNull(28) ? null : reader.GetString(28);
                    model.SFYJZZ = reader.IsDBNull(29) ? null : reader.GetString(29);
                    model.JZZQSRQ = reader.IsDBNull(30) ? null : (DateTime?)reader.GetDateTime(30);
                    model.JZZJZRQ = reader.IsDBNull(31) ? null : (DateTime?)reader.GetDateTime(31);
                    model.SFYLDSC = reader.IsDBNull(32) ? null : reader.GetString(32);
                    model.SFBLGSBJJ = reader.IsDBNull(33) ? null : reader.GetString(33);
                    model.SFBLGGJJ = reader.IsDBNull(34) ? null : reader.GetString(34);
                    model.GJJZH = reader.IsDBNull(35) ? null : reader.GetString(35);
                    model.SFBLGZHBX = reader.IsDBNull(36) ? null : reader.GetString(36);
                    model.YDWSFBLTG = reader.IsDBNull(37) ? null : reader.GetString(37);
                    model.RYLB = reader.IsDBNull(38) ? null : reader.GetString(38);
                    model.SCRZRQ = reader.IsDBNull(39) ? null : (DateTime?)reader.GetDateTime(39);
                    model.LZRQ = reader.IsDBNull(40) ? null : (DateTime?)reader.GetDateTime(40);
                    model.LZYY = reader.IsDBNull(41) ? null : reader.GetString(41);
                    model.GXRID = reader.IsDBNull(42) ? null : reader.GetString(42);
                    model.GXRXM = reader.IsDBNull(43) ? null : reader.GetString(43);
                    model.GXLX = reader.IsDBNull(44) ? null : reader.GetString(44);
                    model.GXYY = reader.IsDBNull(45) ? null : reader.GetString(45);
                    list.Add(model);
                }
            }
            return list;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///DAL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageRow_NumberUsingAdapter(int pageIndex, int pageSize, string strAccord, string strASCorDESC)
        {
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDataTable("select * from ( select row_number() over(order by " + strAccord + " " + strASCorDESC + ") as rownum ,* from T_HR_YGJBXX )as tempTable where tempTable.rownum> " + ((pageIndex - 1) * pageSize).ToString() + " and tempTable.rownum<=" + (((pageIndex - 1) * pageSize) + pageSize).ToString() + "");
            return DataTableToList(dt);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///DAL方法：判断根据条件的查找结果是否存在------>请传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_YGJBXXIsExist(string strDBColumnName, string strDBColumnValue)
        {
            object b = SqlHelper.ExecuteScalar("select * from T_HR_YGJBXX where " + strDBColumnName + " = @strDBColumnValue", new SqlParameter("@strDBColumnValue", strDBColumnValue));
            if (b != null)
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
            bool b = SqlHelper.DataBulkCopy("T_HR_YGJBXX", table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPage_Proc(int pageIndex, int pageSize, out object totalCount)
        {
            DataTable dt = new DataTable();
            SqlParameter totalParameter = new SqlParameter("@total", SqlDbType.Int);
            totalParameter.Direction = ParameterDirection.Output;
            dt = SqlHelper.ExecuteDataTable_Proc("T_HR_YGJBXX_Proc_LoadPageData", out totalCount, new SqlParameter("@pageIndex", pageIndex), new SqlParameter("@pageSize", pageSize), totalParameter);
            return DataTableToList(dt);
        }
        #endregion

        #region DataTable到List的转换
        /// <summary>
        ///DAL方法：DataTable到IEnumerable<T_HR_YGJBXX> 的转换------>请传入DataTable类型数据，返回IEnumerable<T_HR_YGJBXX>类型对象
        /// </summary>
        /// <returns></returns>
        private IEnumerable<T_HR_YGJBXX> DataTableToList(DataTable dt)
        {
            List<T_HR_YGJBXX> list = new List<T_HR_YGJBXX>();
            foreach (DataRow dr in dt.Rows)
            {
                T_HR_YGJBXX model = new T_HR_YGJBXX();
                model.RID = (dr["RID"] == DBNull.Value) ? null : (string)dr["RID"];
                model.GH = (dr["GH"] == DBNull.Value) ? null : (string)dr["GH"];
                model.XM = (dr["XM"] == DBNull.Value) ? null : (string)dr["XM"];
                model.JG = (dr["JG"] == DBNull.Value) ? null : (string)dr["JG"];
                model.SSBM = (dr["SSBM"] == DBNull.Value) ? null : (string)dr["SSBM"];
                model.ZW = (dr["ZW"] == DBNull.Value) ? null : (string)dr["ZW"];
                model.ZJHM = (dr["ZJHM"] == DBNull.Value) ? null : (string)dr["ZJHM"];
                model.ZJZL = (dr["ZJZL"] == DBNull.Value) ? null : (string)dr["ZJZL"];
                model.XB = (dr["XB"] == DBNull.Value) ? null : (string)dr["XB"];
                model.ZZMM = (dr["ZZMM"] == DBNull.Value) ? null : (string)dr["ZZMM"];
                model.CSRQ = (dr["CSRQ"] == DBNull.Value) ? null : (string)dr["CSRQ"];
                model.MZ = (dr["MZ"] == DBNull.Value) ? null : (string)dr["MZ"];
                model.HYZK = (dr["HYZK"] == DBNull.Value) ? null : (string)dr["HYZK"];
                model.XL = (dr["XL"] == DBNull.Value) ? null : (string)dr["XL"];
                model.XW = (dr["XW"] == DBNull.Value) ? null : (string)dr["XW"];
                model.BYRQ = (dr["BYRQ"] == DBNull.Value) ? null : (DateTime?)dr["BYRQ"];
                model.BYXX = (dr["BYXX"] == DBNull.Value) ? null : (string)dr["BYXX"];
                model.SXZY = (dr["SXZY"] == DBNull.Value) ? null : (string)dr["SXZY"];
                model.ZC = (dr["ZC"] == DBNull.Value) ? null : (string)dr["ZC"];
                model.HJLB = (dr["HJLB"] == DBNull.Value) ? null : (string)dr["HJLB"];
                model.HJDXZQH = (dr["HJDXZQH"] == DBNull.Value) ? null : (string)dr["HJDXZQH"];
                model.HJDXZ = (dr["HJDXZ"] == DBNull.Value) ? null : (string)dr["HJDXZ"];
                model.JZDXZQH = (dr["JZDXZQH"] == DBNull.Value) ? null : (string)dr["JZDXZQH"];
                model.JZDXZ = (dr["JZDXZ"] == DBNull.Value) ? null : (string)dr["JZDXZ"];
                model.JZDYZBM = (dr["JZDYZBM"] == DBNull.Value) ? null : (string)dr["JZDYZBM"];
                model.LXDH = (dr["LXDH"] == DBNull.Value) ? null : (string)dr["LXDH"];
                model.JTDH = (dr["JTDH"] == DBNull.Value) ? null : (string)dr["JTDH"];
                model.DASZD = (dr["DASZD"] == DBNull.Value) ? null : (string)dr["DASZD"];
                model.SFYJZZ = (dr["SFYJZZ"] == DBNull.Value) ? null : (string)dr["SFYJZZ"];
                model.JZZQSRQ = (dr["JZZQSRQ"] == DBNull.Value) ? null : (DateTime?)dr["JZZQSRQ"];
                model.JZZJZRQ = (dr["JZZJZRQ"] == DBNull.Value) ? null : (DateTime?)dr["JZZJZRQ"];
                model.SFYLDSC = (dr["SFYLDSC"] == DBNull.Value) ? null : (string)dr["SFYLDSC"];
                model.SFBLGSBJJ = (dr["SFBLGSBJJ"] == DBNull.Value) ? null : (string)dr["SFBLGSBJJ"];
                model.SFBLGGJJ = (dr["SFBLGGJJ"] == DBNull.Value) ? null : (string)dr["SFBLGGJJ"];
                model.GJJZH = (dr["GJJZH"] == DBNull.Value) ? null : (string)dr["GJJZH"];
                model.SFBLGZHBX = (dr["SFBLGZHBX"] == DBNull.Value) ? null : (string)dr["SFBLGZHBX"];
                model.YDWSFBLTG = (dr["YDWSFBLTG"] == DBNull.Value) ? null : (string)dr["YDWSFBLTG"];
                model.RYLB = (dr["RYLB"] == DBNull.Value) ? null : (string)dr["RYLB"];
                model.SCRZRQ = (dr["SCRZRQ"] == DBNull.Value) ? null : (DateTime?)dr["SCRZRQ"];
                model.LZRQ = (dr["LZRQ"] == DBNull.Value) ? null : (DateTime?)dr["LZRQ"];
                model.LZYY = (dr["LZYY"] == DBNull.Value) ? null : (string)dr["LZYY"];
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