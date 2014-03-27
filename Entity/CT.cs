using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //出题
    public class CT
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public CT() {
            this.kcbh = -1;
            this.Zybh = -1;
            this.Ctr = "";
        }

        public CT(int _kcbh, int _zybh, string _ctr) {
            this.Kcbh = _kcbh;
            this.Zybh = _zybh;
            this.Ctr = _ctr;
        }

        //课程编号
        private int kcbh;

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }

        //专业编号
        private int zybh;

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }

        //教师编号.  外键别名为出题人
        private string ctr;

        public string Ctr
        {
            get { return ctr; }
            set { ctr = value; }
        }
    }
}