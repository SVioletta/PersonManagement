using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_GZLL实体
    public partial class T_HR_GZLL
    {
        public string GZLL_ID { get; set; }
        public string RID { get; set; }
        public DateTime? QSRQ { get; set; }
        public DateTime? JZRQ { get; set; }
        public string GZDW { get; set; }
        public string ZW { get; set; }
        public string ZMR { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
