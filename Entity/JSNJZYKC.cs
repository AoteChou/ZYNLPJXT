﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //教师年级专业课程
    public class JSNJZYKC
    {
        /// <summary>
        /// 无参构造函数。字段被赋予默认值
        /// </summary>
        public JSNJZYKC() {
            this.Jsbh = "";
            this.Njbh = -1;
            this.Zybh = -1;
            this.Kcbh = -1;
        }

        public JSNJZYKC(string _jsbh,int _njbh,int _zybh,int _kcbh) {
            this.Jsbh = _jsbh.Trim(); ;
            this.Njbh = _njbh;
            this.Zybh = _zybh;
            this.Kcbh = _kcbh;
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

        //教师编号
        private string jsbh;

        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }
    }
}