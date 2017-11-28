using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public partial class T_HR_YGJBXXBLL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///BLL方法：向数据库中增加新一条新的T_HR_YGJBXX对象数据------>请传入对象，返回首行首列
        /// </summary>
        /// <returns></returns>
        public object Add(T_HR_YGJBXX model)
        {
            T_HR_YGJBXXDAL td = new T_HR_YGJBXXDAL();
            object a = td.Add(model);
            return a;
        }
        #endregion

        #region 删除数据库中的一条数据
        /// <summary>
        ///BLL方法：删除数据库中的一条数据------>根据传入的参数删除数据,请传入数据库的列名以及删除对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Delete(string strDBColumnName,string strDelId)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            int d = Td.Delete(strDBColumnName,strDelId);
            return d;
        }
        #endregion

        #region 删除数据库中的多条数据
        /// <summary>
        ///BLL方法：删除数据库中的多条数据------>根据传入的参数删除数据,请传入数据库的列名以及删除的具体依据[例如："delete from XXX where strDBColumnName in (params strDBValue)"],返回影响条数
        /// </summary>
        /// <returns></returns>
        public int DeleteMultiterm(string strDBColumnName, params string[] strDBValues)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            int d = Td.DeleteMultiterm(strDBColumnName,strDBValues);
            return d;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///BLL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_YGJBXX model,string strDBColumnName,string strUpdateId)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            int u = Td.Update(model,strDBColumnName,strUpdateId);
            return u;
        }
        #endregion

        #region 更新数据库中的多条数据
        /// <summary>
        ///BLL方法：更新数据库中的多条数据[可用于做多选软删除]------>根据传入的参数更新数据,请传入数据库的列名以及更新的具体依据[例如："update XXX set updateDBColumnName=updateDBColumnValue  where strAccord in (params strDBValue)"],返回影响条数
        /// </summary>
        /// <returns></returns>
       public int UpdateMultiterm(string updateDBColumnName, string updateDBColumnValue, string strAccord, params string[] strDBValues)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            int d = Td.UpdateMultiterm(updateDBColumnName,updateDBColumnValue,strAccord,strDBValues);
            return d;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///BLL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGJBXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGJBXX SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            T_HR_YGJBXX T = Td.SelectSingleModelByReader(strDBColumnName,strSelId);
            return T;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///BLL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_YGJBXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_YGJBXX SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            T_HR_YGJBXX T = Td.SelectSingleModelByAdapter(strDBColumnName,strSelId);
            return T;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///BLL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectAllByReader()
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.SelectAllByReader();
            return i;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///BLL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectAllByAdapter()
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.SelectAllByAdapter();
            return i;
        }
        #endregion

        #region 查找数据库中的数据条数
        /// <summary>
        ///BLL方法：查找数据库中的数据条数([例如：select Count(*) from... where "XXX"="YYY"],查询整体数据条数Count(*)请传入"1","1"-->sql语句拼接"where 1=1")------>请传入数据库的列名，数据库的值，返回首行首列
        /// </summary>
        /// <returns></returns>
        public int GetCount(string strDBColumnName,string strSelValue)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            int c = Td.GetCount(strDBColumnName,strSelValue);
            return c;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///BLL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> FuzzyQueryByReader(bool RIDIsChecked,string RID,bool GHIsChecked,string GH,bool XMIsChecked,string XM,bool JGIsChecked,string JG,bool SSBMIsChecked,string SSBM,bool ZWIsChecked,string ZW,bool ZJHMIsChecked,string ZJHM,bool ZJZLIsChecked,string ZJZL,bool XBIsChecked,string XB,bool ZZMMIsChecked,string ZZMM,bool CSRQIsChecked,string CSRQ,bool MZIsChecked,string MZ,bool HYZKIsChecked,string HYZK,bool XLIsChecked,string XL,bool XWIsChecked,string XW,bool BYRQIsChecked,string BYRQ,bool BYXXIsChecked,string BYXX,bool SXZYIsChecked,string SXZY,bool ZCIsChecked,string ZC,bool HJLBIsChecked,string HJLB,bool HJDXZQHIsChecked,string HJDXZQH,bool HJDXZIsChecked,string HJDXZ,bool JZDXZQHIsChecked,string JZDXZQH,bool JZDXZIsChecked,string JZDXZ,bool JZDYZBMIsChecked,string JZDYZBM,bool LXDHIsChecked,string LXDH,bool JTDHIsChecked,string JTDH,bool DASZDIsChecked,string DASZD,bool SFYJZZIsChecked,string SFYJZZ,bool JZZQSRQIsChecked,string JZZQSRQ,bool JZZJZRQIsChecked,string JZZJZRQ,bool SFYLDSCIsChecked,string SFYLDSC,bool SFBLGSBJJIsChecked,string SFBLGSBJJ,bool SFBLGGJJIsChecked,string SFBLGGJJ,bool GJJZHIsChecked,string GJJZH,bool SFBLGZHBXIsChecked,string SFBLGZHBX,bool YDWSFBLTGIsChecked,string YDWSFBLTG,bool RYLBIsChecked,string RYLB,bool SCRZRQIsChecked,string SCRZRQ,bool LZRQIsChecked,string LZRQ,bool LZYYIsChecked,string LZYY,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.FuzzyQueryByReader(RIDIsChecked,RID,GHIsChecked,GH,XMIsChecked,XM,JGIsChecked,JG,SSBMIsChecked,SSBM,ZWIsChecked,ZW,ZJHMIsChecked,ZJHM,ZJZLIsChecked,ZJZL,XBIsChecked,XB,ZZMMIsChecked,ZZMM,CSRQIsChecked,CSRQ,MZIsChecked,MZ,HYZKIsChecked,HYZK,XLIsChecked,XL,XWIsChecked,XW,BYRQIsChecked,BYRQ,BYXXIsChecked,BYXX,SXZYIsChecked,SXZY,ZCIsChecked,ZC,HJLBIsChecked,HJLB,HJDXZQHIsChecked,HJDXZQH,HJDXZIsChecked,HJDXZ,JZDXZQHIsChecked,JZDXZQH,JZDXZIsChecked,JZDXZ,JZDYZBMIsChecked,JZDYZBM,LXDHIsChecked,LXDH,JTDHIsChecked,JTDH,DASZDIsChecked,DASZD,SFYJZZIsChecked,SFYJZZ,JZZQSRQIsChecked,JZZQSRQ,JZZJZRQIsChecked,JZZJZRQ,SFYLDSCIsChecked,SFYLDSC,SFBLGSBJJIsChecked,SFBLGSBJJ,SFBLGGJJIsChecked,SFBLGGJJ,GJJZHIsChecked,GJJZH,SFBLGZHBXIsChecked,SFBLGZHBX,YDWSFBLTGIsChecked,YDWSFBLTG,RYLBIsChecked,RYLB,SCRZRQIsChecked,SCRZRQ,LZRQIsChecked,LZRQ,LZYYIsChecked,LZYY,GXRIDIsChecked,GXRID,GXRXMIsChecked,GXRXM,GXLXIsChecked,GXLX,GXYYIsChecked,GXYY,GXSJIsChecked,GXSJ);
            return i;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///BLL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> FuzzyQueryByAdapter(bool RIDIsChecked,string RID,bool GHIsChecked,string GH,bool XMIsChecked,string XM,bool JGIsChecked,string JG,bool SSBMIsChecked,string SSBM,bool ZWIsChecked,string ZW,bool ZJHMIsChecked,string ZJHM,bool ZJZLIsChecked,string ZJZL,bool XBIsChecked,string XB,bool ZZMMIsChecked,string ZZMM,bool CSRQIsChecked,string CSRQ,bool MZIsChecked,string MZ,bool HYZKIsChecked,string HYZK,bool XLIsChecked,string XL,bool XWIsChecked,string XW,bool BYRQIsChecked,string BYRQ,bool BYXXIsChecked,string BYXX,bool SXZYIsChecked,string SXZY,bool ZCIsChecked,string ZC,bool HJLBIsChecked,string HJLB,bool HJDXZQHIsChecked,string HJDXZQH,bool HJDXZIsChecked,string HJDXZ,bool JZDXZQHIsChecked,string JZDXZQH,bool JZDXZIsChecked,string JZDXZ,bool JZDYZBMIsChecked,string JZDYZBM,bool LXDHIsChecked,string LXDH,bool JTDHIsChecked,string JTDH,bool DASZDIsChecked,string DASZD,bool SFYJZZIsChecked,string SFYJZZ,bool JZZQSRQIsChecked,string JZZQSRQ,bool JZZJZRQIsChecked,string JZZJZRQ,bool SFYLDSCIsChecked,string SFYLDSC,bool SFBLGSBJJIsChecked,string SFBLGSBJJ,bool SFBLGGJJIsChecked,string SFBLGGJJ,bool GJJZHIsChecked,string GJJZH,bool SFBLGZHBXIsChecked,string SFBLGZHBX,bool YDWSFBLTGIsChecked,string YDWSFBLTG,bool RYLBIsChecked,string RYLB,bool SCRZRQIsChecked,string SCRZRQ,bool LZRQIsChecked,string LZRQ,bool LZYYIsChecked,string LZYY,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.FuzzyQueryByAdapter(RIDIsChecked,RID,GHIsChecked,GH,XMIsChecked,XM,JGIsChecked,JG,SSBMIsChecked,SSBM,ZWIsChecked,ZW,ZJHMIsChecked,ZJHM,ZJZLIsChecked,ZJZL,XBIsChecked,XB,ZZMMIsChecked,ZZMM,CSRQIsChecked,CSRQ,MZIsChecked,MZ,HYZKIsChecked,HYZK,XLIsChecked,XL,XWIsChecked,XW,BYRQIsChecked,BYRQ,BYXXIsChecked,BYXX,SXZYIsChecked,SXZY,ZCIsChecked,ZC,HJLBIsChecked,HJLB,HJDXZQHIsChecked,HJDXZQH,HJDXZIsChecked,HJDXZ,JZDXZQHIsChecked,JZDXZQH,JZDXZIsChecked,JZDXZ,JZDYZBMIsChecked,JZDYZBM,LXDHIsChecked,LXDH,JTDHIsChecked,JTDH,DASZDIsChecked,DASZD,SFYJZZIsChecked,SFYJZZ,JZZQSRQIsChecked,JZZQSRQ,JZZJZRQIsChecked,JZZJZRQ,SFYLDSCIsChecked,SFYLDSC,SFBLGSBJJIsChecked,SFBLGSBJJ,SFBLGGJJIsChecked,SFBLGGJJ,GJJZHIsChecked,GJJZH,SFBLGZHBXIsChecked,SFBLGZHBX,YDWSFBLTGIsChecked,YDWSFBLTG,RYLBIsChecked,RYLB,SCRZRQIsChecked,SCRZRQ,LZRQIsChecked,LZRQ,LZYYIsChecked,LZYY,GXRIDIsChecked,GXRID,GXRXMIsChecked,GXRXM,GXLXIsChecked,GXLX,GXYYIsChecked,GXYY,GXSJIsChecked,GXSJ);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"]------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageUsingReader(int pageIndex, int pageSize, string strAccord,string strASCorDESC)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.SelectT_HR_YGJBXXByPageUsingReader(pageIndex,pageSize,strAccord,strASCorDESC);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"]------>返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageUsingAdapter(int pageIndex, int pageSize, string strAccord,string strASCorDESC)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            IEnumerable<T_HR_YGJBXX> i = Td.SelectT_HR_YGJBXXByPageUsingAdapter(pageIndex,pageSize,strAccord,strASCorDESC);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
             return Td.SelectT_HR_YGJBXXByPageRow_NumberUsingReader(pageIndex,pageSize,strAccord,strASCorDESC);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_YGJBXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_YGJBXX> SelectT_HR_YGJBXXByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
             return Td.SelectT_HR_YGJBXXByPageRow_NumberUsingAdapter(pageIndex,pageSize,strAccord,strASCorDESC);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///BLL方法：判断根据条件的查找结果是否存在------>传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_YGJBXXIsExist(string strDBColumnName,string strDBColumnValue)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            bool b = Td.T_HR_YGJBXXIsExist(strDBColumnName,strDBColumnValue);
            return b;
        }
        #endregion

        #region 将DataTable整体插入数据库
        /// <summary>
        ///BLL方法：将DataTable整体插入数据库------>请传入DataTable类型数据(DataTable需要跟数据库的列保持一致)，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool AddDataTableToDB(DataTable table)
        {
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            bool b = Td.AddDataTableToDB(table);
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
            T_HR_YGJBXXDAL Td = new T_HR_YGJBXXDAL();
            return Td.SelectT_HR_YGJBXXByPage_Proc(pageIndex, pageSize, out totalCount);
        }
        #endregion
    }
}