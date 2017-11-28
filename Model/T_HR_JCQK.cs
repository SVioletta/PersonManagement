using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_JCQK实体
    public partial class T_HR_JCQK
    {
        public string JCQK_ID { get; set; }
        public string RID { get; set; }
        public string JCQK { get; set; }
        public string JCDJ { get; set; }
        public string JCDW { get; set; }
        public DateTime? JCSJ { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
