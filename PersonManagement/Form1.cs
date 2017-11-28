using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace PersonManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.dataGridView1.DataSource = bll.SelectAllByAdapter();




            T_HR_YGJBXX model = new T_HR_YGJBXX();
            model.RID = "1";
            model.GH = "000001";
            model.XM = "heihei";
            model.SSBM = "aaa";
            model.ZJHM = "bbb";
            model.SFYLDSC = "1";
            model.SFBLGSBJJ = "1";
            model.SFBLGGJJ = "1";
            model.SFBLGZHBX = "1";
            model.YDWSFBLTG = "1";


            T_HR_YGJBXXBLL bll = new T_HR_YGJBXXBLL();
            bll.Add(model);

            T_HR_XXPXLL xj = new T_HR_XXPXLL();
            xj.RID = "1";

            T_HR_XXPXLLBLL bllxp = new T_HR_XXPXLLBLL();
            bllxp.Add(xj);


            //T_HR_YGJBXXBLL bll = new T_HR_YGJBXXBLL();
            //bll.Delete("RID", "1");

            MessageBox.Show("ok");
        }
    }
}
