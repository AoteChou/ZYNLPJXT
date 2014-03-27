using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //二级指标
    public class EJZB
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public EJZB() {
            this.Ejzbbh = -1;
            this.Yjzbbh = -1;
            this.Ejzbmc = "";
        }

        /// <summary>
        /// insert使用函数
        /// </summary>
        public EJZB(int _yjzbbh, string _ejzbmc) {
            this.Ejzbbh = -1;
            this.Yjzbbh = _yjzbbh;
            this.Ejzbmc = _ejzbmc;
        }

        /// <summary>
        /// get和update使用函数
        /// </summary>
        public EJZB(int _yjzbbh, int _ejzhbh, string _ejzbmc) {
            this.Yjzbbh = _yjzbbh;
            this.Ejzbbh = _ejzhbh;
            this.Ejzbmc = _ejzbmc.Trim();
        }

        //二级指标编号
        private int ejzbbh;

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }

        //一级指标编号
        private int yjzbbh;

        public int Yjzbbh
        {
            get { return yjzbbh; }
            set { yjzbbh = value; }
        }

        //二级指标名称
        private string ejzbmc;

        public string Ejzbmc
        {
            get { return ejzbmc; }
            set { ejzbmc = value; }
        }


    }
}