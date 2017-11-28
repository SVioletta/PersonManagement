using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_JTCY实体
    public partial class T_HR_JTCY
    {
        public string ID { get; set; }
        public string RID { get; set; }
        public string XM { get; set; }
        public string CW { get; set; }
        public DateTime? CSRQ { get; set; }
        public string JG { get; set; }
        public string MZ { get; set; }
        public string XL { get; set; }
        public string XW { get; set; }
        public string ZZMM { get; set; }
        public string GZDW { get; set; }
        public string ZW { get; set; }
        public string LXDH { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
