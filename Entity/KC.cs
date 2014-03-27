using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //课程
    public class KC
    {
        /// <summary>
        /// 无参构造函数。该构造函数会将所有值设置为默认值
        /// </summary>
        public KC() {
            this.Kcbh = -1;
            this.Kcmc = "";
            this.Kcjj = "";
            this.Kcfzr = "";
        }

        /// <summary>
        /// insert函数使用的构造函数
        /// </summary>
        public KC(string _kcmc, string _kcjj, string _xkfzr) {
            this.Kcbh = -1;
            this.Kcmc = _kcmc;
            this.kcjj = _kcjj.Trim();
            this.Kcfzr = _xkfzr.Trim();
        }

        /// <summary>
        /// get,update函数使用的构造函数
        /// </summary>
        public KC(int _kcbh, string _kcmc, string _kcjj, string _xkfzr) {
            this.Kcbh = _kcbh;
            this.Kcmc = _kcmc;
            this.Kcjj = _kcjj.Trim();
            this.Kcfzr = _xkfzr.Trim();
        }

        //课程编号
        private int kcbh;

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }

        //课程简介
        private string kcjj;

        public string Kcjj
        {
            get { return kcjj; }
            set { kcjj = value.Trim(); }
        }

        //课程名称
        private string kcmc;

        public string Kcmc
        {
            get { return kcmc; }
            set { kcmc = value; }
        }

        //学科负责人
        private string kcfzr;

        public string Kcfzr
        {
            get { return kcfzr; }
            set { kcfzr = value.Trim(); }
        }
    }
}