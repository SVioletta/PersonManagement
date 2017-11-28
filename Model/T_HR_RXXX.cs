using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_RXXX实体
    public partial class T_HR_RXXX
    {
        public string ID { get; set; }
        public string RID { get; set; }
        public DateTime? PSSJ { get; set; }
        public string LX { get; set; }
        public string YT { get; set; }
        public string XP { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public object GXSJ { get; set; }
    }
}
