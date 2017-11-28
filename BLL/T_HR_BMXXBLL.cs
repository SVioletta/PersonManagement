using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public partial class T_HR_BMXXBLL
    {
        #region 向数据库中增加一条数据
        /// <summary>
        ///BLL方法：向数据库中增加新一条新的T_HR_BMXX对象数据------>请传入对象，返回首行首列
        /// </summary>
        /// <returns></returns>  
        public object Add(T_HR_BMXX model)
        {
            T_HR_BMXXDAL td = new T_HR_BMXXDAL();
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
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
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
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            int d = Td.DeleteMultiterm(strDBColumnName,strDBValues);
            return d;
        }
        #endregion

        #region 更新数据库中的一条数据
        /// <summary>
        ///BLL方法：更新数据库中的一条数据------>根据传入的参数更新数据,请传入数据库的列名以及更新对象的具体依据，返回影响条数
        /// </summary>
        /// <returns></returns>
        public int Update(T_HR_BMXX model,string strDBColumnName,string strUpdateId)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
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
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            int d = Td.UpdateMultiterm(updateDBColumnName,updateDBColumnValue,strAccord,strDBValues);
            return d;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///BLL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_BMXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_BMXX SelectSingleModelByReader(string strDBColumnName,string strSelId)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            T_HR_BMXX T = Td.SelectSingleModelByReader(strDBColumnName,strSelId);
            return T;
        }
        #endregion

        #region 查找数据库中的一条数据
        /// <summary>
        ///BLL方法：查找数据库中的一条数据------>根据传入的参数查找数据,请传入数据库的列名以及查找对象的具体依据，返回T_HR_BMXX对象类型性数据
        /// </summary>
        /// <returns></returns>
        public T_HR_BMXX SelectSingleModelByAdapter(string strDBColumnName,string strSelId)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            T_HR_BMXX T = Td.SelectSingleModelByAdapter(strDBColumnName,strSelId);
            return T;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///BLL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectAllByReader()
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.SelectAllByReader();
            return i;
        }
        #endregion

        #region 查找数据库中的全部数据
        /// <summary>
        ///BLL方法：查找数据库中的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectAllByAdapter()
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.SelectAllByAdapter();
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
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            int c = Td.GetCount(strDBColumnName,strSelValue);
            return c;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///BLL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> FuzzyQueryByReader(bool BM_IDIsChecked,string BM_ID,bool BMBMIsChecked,string BMBM,bool BMMCIsChecked,string BMMC,bool CJRQIsChecked,string CJRQ,bool ZZMSIsChecked,string ZZMS,bool FZRIsChecked,string FZR,bool LXRIsChecked,string LXR,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.FuzzyQueryByReader(BM_IDIsChecked,BM_ID,BMBMIsChecked,BMBM,BMMCIsChecked,BMMC,CJRQIsChecked,CJRQ,ZZMSIsChecked,ZZMS,FZRIsChecked,FZR,LXRIsChecked,LXR,GXRIDIsChecked,GXRID,GXRXMIsChecked,GXRXM,GXLXIsChecked,GXLX,GXYYIsChecked,GXYY,GXSJIsChecked,GXSJ);
            return i;
        }
        #endregion

        #region 模糊查找数据库中符合条件的全部数据
        /// <summary>
        ///BLL方法：模糊查找数据库中符合条件的全部数据------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> FuzzyQueryByAdapter(bool BM_IDIsChecked,string BM_ID,bool BMBMIsChecked,string BMBM,bool BMMCIsChecked,string BMMC,bool CJRQIsChecked,string CJRQ,bool ZZMSIsChecked,string ZZMS,bool FZRIsChecked,string FZR,bool LXRIsChecked,string LXR,bool GXRIDIsChecked,string GXRID,bool GXRXMIsChecked,string GXRXM,bool GXLXIsChecked,string GXLX,bool GXYYIsChecked,string GXYY,bool GXSJIsChecked,string GXSJ)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.FuzzyQueryByAdapter(BM_IDIsChecked,BM_ID,BMBMIsChecked,BMBM,BMMCIsChecked,BMMC,CJRQIsChecked,CJRQ,ZZMSIsChecked,ZZMS,FZRIsChecked,FZR,LXRIsChecked,LXR,GXRIDIsChecked,GXRID,GXRXMIsChecked,GXRXM,GXLXIsChecked,GXLX,GXYYIsChecked,GXYY,GXSJIsChecked,GXSJ);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"]------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageUsingReader(int pageIndex, int pageSize, string strAccord,string strASCorDESC)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.SelectT_HR_BMXXByPageUsingReader(pageIndex,pageSize,strAccord,strASCorDESC);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（not in select top...子查询方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)not in select top...子查询方法[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"]------>返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageUsingAdapter(int pageIndex, int pageSize, string strAccord,string strASCorDESC)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            IEnumerable<T_HR_BMXX> i = Td.SelectT_HR_BMXXByPageUsingAdapter(pageIndex,pageSize,strAccord,strASCorDESC);
            return i;
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageRow_NumberUsingReader(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
             return Td.SelectT_HR_BMXXByPageRow_NumberUsingReader(pageIndex,pageSize,strAccord,strASCorDESC);
        }
        #endregion

        #region 分页查找数据库中的数据（Row_Number开窗函数方法）
        /// <summary>
        ///BLL方法：分页查找数据库中的数据(首页数据为第1页)Row_Number开窗函数方法------>根据传入的参数分页查找数据,请传入查找排序的具体依据[说明：strAccord为数据库列名，strASCorDESC请填写"ASC"或"DESC"],返回IEnumerable&lt;T_HR_BMXX&gt;接口数据
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPageRow_NumberUsingAdapter(int pageIndex,int pageSize,string strAccord,string strASCorDESC)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
             return Td.SelectT_HR_BMXXByPageRow_NumberUsingAdapter(pageIndex,pageSize,strAccord,strASCorDESC);
        }
        #endregion

        #region 判断根据条件的查找结果是否存在
        /// <summary>
        ///BLL方法：判断根据条件的查找结果是否存在------>传入数据库的列名，数据库的值，返回bool类型数据
        /// </summary>
        /// <returns></returns>
        public bool T_HR_BMXXIsExist(string strDBColumnName,string strDBColumnValue)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            bool b = Td.T_HR_BMXXIsExist(strDBColumnName,strDBColumnValue);
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
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            bool b = Td.AddDataTableToDB(table);
            return b;
        }
        #endregion

        #region 调用存储过程实现分页
        /// <summary>
        ///DAL方法：调用存储过程实现分页------>用out参数返回当前数据库总条数（并非分页条数）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T_HR_BMXX> SelectT_HR_BMXXByPage_Proc(int pageIndex, int pageSize, out object totalCount)
        {
            T_HR_BMXXDAL Td = new T_HR_BMXXDAL();
            return Td.SelectT_HR_BMXXByPage_Proc(pageIndex, pageSize, out totalCount);
        }
        #endregion
    }
}