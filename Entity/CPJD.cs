using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //测评阶段
    public class CPJD
    {
        public CPJD() {
            this.Njbh = -1;
            this.Jdbh = -1;
            this.Zybh = -1;
            this.Jdmc = "";
            this.Qsxq = -1;
            this.Jzxq = -1;
            this.Cpjdjj = "";
        }

        /// <summary>
        /// insert使用的构造函数
        /// </summary>
        public CPJD(int _njbh,int _zybh,string _jdmc,int _qsxq,int _jzxq,string _cpjdjj) {
            this.Njbh = _njbh;
            this.Zybh = _zybh;
            this.Jdmc = _jdmc;
            this.Qsxq = _qsxq;
            this.Jzxq = _jzxq;
            this.Cpjdjj = _cpjdjj;
        }

        /// <summary>
        /// get,update使用的构造函数
        /// </summary>
        public CPJD(int _jdbh,int _njbh, int _zybh, string _jdmc, int _qsxq, int _jzxq, string _cpjdjj)
        {
            this.Jdbh = _jdbh;
            this.Njbh = _njbh;
            this.Zybh = _zybh;
            this.Jdmc = _jdmc;
            this.Qsxq = _qsxq;
            this.Jzxq = _jzxq;
            this.Cpjdjj = _cpjdjj;
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


        private string cpjdjj;

        public string Cpjdjj
        {
            get { return cpjdjj; }
            set { cpjdjj = value; }
        }

    }
}