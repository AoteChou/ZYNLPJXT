using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学生课程表
    public class XSKCB
    {
        private int kcbh; //课程编号

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }
        private int zybh; //专业编号

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }
        private int njbh; //年级编号

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }
        private string jsbh; //教师编号

        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }
        private string xsbh; //学生编号

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
        }

    }
}