using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学生课程View
    public class XSKCView
    {
        //课程简介
        private string kcjj;

        public string Kcjj
        {
            get { return kcjj; }
            set { kcjj = value; }
        }

        //课程名称
        private string kcmc;

        public string Kcmc
        {
            get { return kcmc; }
            set { kcmc = value; }
        }

        //学科编号
        private int xkbh;

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }

        //专业名
        private string zym;

        public string Zym
        {
            get { return zym; }
            set { zym = value; }
        }

        //专业负责人
        private string zyfzr;

        public string Zyfzr
        {
            get { return zyfzr; }
            set { zyfzr = value; }
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

        //教师编号
        private string jsbh;

        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

        //学生编号
        private string xsbh;

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
        }

        //年级编号
        private int njbh;

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }

        //年级名称
        private string njmc;

        public string Njmc
        {
            get { return njmc; }
            set { njmc = value; }
        }
    }
}