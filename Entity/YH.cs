﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //用户
    public class YH
    {
        private string yhbh; //用户编号

        public string Yhbh
        {
            get { return yhbh; }
            set { yhbh = value; }
        }
        private string mm; //密码

        public string Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        private string xm; //姓名

        public string Xm
        {
            get { return xm; }
            set { xm = value; }
        }
        private int xb; //性别

        public int Xb
        {
            get { return xb; }
            set { xb = value; }
        }

    }
}