using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Model
{
    //创建数据库中T_HR_BMXX实体
    public partial class T_HR_BMXX
    {
        public string BM_ID { get; set; }
        public string BMBM { get; set; }
        public string BMMC { get; set; }
        public DateTime? CJRQ { get; set; }
        public string ZZMS { get; set; }
        public string FZR { get; set; }
        public string LXR { get; set; }
        public string GXRID { get; set; }
        public string GXRXM { get; set; }
        public string GXLX { get; set; }
        public string GXYY { get; set; }
        public object GXSJ { get; set; }
    }
}
