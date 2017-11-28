using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_YGGZ实体
    public partial class T_HR_YGGZ
    {
        public string GZ_ID { get; set; }
        public string RID { get; set; }
        public object JBGZ { get; set; }
        public object ZWGZ { get; set; }
        public string YXBS { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
