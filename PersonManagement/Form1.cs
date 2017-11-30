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
            




            T_HR_YGJBXX model = new T_HR_YGJBXX
            {
                RID = "3",
                GH = "000001",
                XM = "heihei",
                SSBM = "1",
                ZJHM = "bbb",
                SFYLDSC = "1",
                SFBLGSBJJ = "1",
                SFBLGGJJ = "1",
                SFBLGZHBX = "1",
                YDWSFBLTG = "1"
            };


            T_HR_YGJBXXBLL bll = new T_HR_YGJBXXBLL();
            bll.Add(model);

            //T_HR_XXPXLL xj = new T_HR_XXPXLL();
            //xj.RID = "1";

            //T_HR_XXPXLLBLL bllxp = new T_HR_XXPXLLBLL();
            //bllxp.Add(xj);


            //T_HR_YGJBXXBLL bll = new T_HR_YGJBXXBLL();
            //bll.Delete("RID", "1");

            this.dataGridView1.DataSource = bll.SelectAllByAdapter();

            MessageBox.Show("ok");
        }
    }
}
