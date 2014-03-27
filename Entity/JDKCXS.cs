using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //阶段课程学生
    public class JDKCXS
    {
        /// <summary>
        ///无参构造函数
        /// </summary>
        public JDKCXS() {
            this.Kcbh = -1;
            this.Zybh = -1;
            this.Njbh = -1;
            this.Jdbh = -1;
            this.Xsbh = "";
            this.Jsbh = "";
        }

        public JDKCXS(int _kcbh,int _zybh,int _jdbh,int _njbh,string _xsbh,string _jsbh){
            this.Kcbh = _kcbh;
            this.Zybh = _zybh;
            this.Njbh = _njbh;
            this.Jdbh = _jdbh;
            this.Xsbh = _xsbh.Trim();
            this.Jsbh = _jsbh.Trim();
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

        //学生编号
        private string xsbh;

        public string Xsbh
        {
            get { return xsbh; }
            set { xsbh = value; }
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