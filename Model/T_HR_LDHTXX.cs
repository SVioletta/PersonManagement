using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_LDHTXX实体
    public partial class T_HR_LDHTXX
    {
        public string HT_ID { get; set; }
        public string RID { get; set; }
        public string HTBH { get; set; }
        public string HTLX { get; set; }
        public DateTime? KSRQ { get; set; }
        public DateTime? DQRQ { get; set; }
        public string DASZD { get; set; }
        public string LDSC { get; set; }
        public DateTime? BLLYSXRQ { get; set; }
        public DateTime? BLBXRQ { get; set; }
        public DateTime? BLGJJRQ { get; set; }
        public string YXBS { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
