using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //班级
    public class BJ
    {

        //班级编号
        private int bjbh;

        public int Bjbh
        {
            get { return bjbh; }
            set { bjbh = value; }
        }

        //年级编号
        private int njbh;

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }

        //专业编号
        private int zybh;

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }

        //班级名称
        private string bjmc;

        public string Bjmc
        {
            get { return bjmc; }
            set { bjmc = value; }
        }

        //入学年份
        private DateTime rxnf;

        public DateTime Rxnf
        {
            get { return rxnf; }
            set { rxnf = value; }
        }

    }
}