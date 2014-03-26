using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //年级专业课程
    public class NJZYKC
    {
        /// <summary>
        /// 无参构造函数，初始值为默认值
        /// </summary>
        public NJZYKC() {
            this.Kcbh = -1;
            this.Njbh = -1;
            this.Zybh = -1;
        }

        public NJZYKC(int _kcbh, int _njbh, int _zykc) {
            this.Kcbh = _kcbh;
            this.Njbh = _njbh;
            this.Zybh = _zykc;
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

        //年级编号
        private int njbh;

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }
    }
}