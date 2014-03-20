using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //测评阶段
    public class CPJD
    {

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

        //专业编号
        private int zybh;

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }

        //阶段名称
        private string jdmc;

        public string Jdmc
        {
            get { return jdmc; }
            set { jdmc = value; }
        }

        //起始学期
        private int qsxq;

        public int Qsxq
        {
            get { return qsxq; }
            set { qsxq = value; }
        }

        //截止学期
        private int jzxq;

        public int Jzxq
        {
            get { return jzxq; }
            set { jzxq = value; }
        }

        //测评阶段简介
        private string cpjdjj;

        public string Cpjdjj
        {
            get { return cpjdjj; }
            set { cpjdjj = value; }
        }

        
    }
}