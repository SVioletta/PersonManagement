using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_FJZL实体
    public partial class T_HR_FJZL
    {
        public string FJ_ID { get; set; }
        public string RID { get; set; }
        public string ZLLX { get; set; }
        public string WJLX { get; set; }
        public string ZLMC { get; set; }
        public string WJMC { get; set; }
        public string ZLNR { get; set; }
        public string BZ { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
