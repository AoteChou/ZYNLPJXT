﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //阶段课程
    public class JDKC
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public JDKC() {
            this.Kcbh = -1;
            this.Zybh = -1;
            this.Jdbh = -1;
            this.Njbh = -1;
        }

        public JDKC(int _kcbh,int _zybh, int _jdbh, int _njbh) {
            this.Kcbh = _kcbh;
            this.Zybh = _zybh;
            this.Jdbh = _jdbh;
            this.Njbh = _njbh;
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

        //阶段编号
        private int jdbh;

        public int Jdbh
        {
            get { return jdbh; }
            set { jdbh = value; }
        }


    }
}