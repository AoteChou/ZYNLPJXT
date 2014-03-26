using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //功能点
    public class GND
    {
        /// <summary>
        /// 默认无参构造函数.数据会被赋值为默认值
        /// </summary>
        public GND() {
            this.Gnbh = -1;
            this.Gnm = "";
            this.Gnlj = "";
            this.Ssml = "";
        }

        /// <summary>
        /// insert使用的构造函数
        /// </summary>
        public GND(string _gnm, string _gnlj, string _ssml) {
            this.Gnbh = -1;
            this.Gnm = _gnm;
            this.Gnlj = _gnlj;
            this.Ssml = _ssml;
        }

        /// <summary>
        /// update，get使用的构造函数
        /// </summary>
        public GND(int _gnbh, string _gnm, string _gnlj, string _ssml) {
            this.Gnbh = _gnbh;
            this.Gnm = _gnm;
            this.Gnlj = _gnlj;
            this.Ssml = _ssml;
        }

        //功能编号
        private int gnbh;

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }

        //功能名称
        private string gnm;

        public string Gnm
        {
            get { return gnm; }
            set { gnm = value; }
        }

        //功能链接
        private string gnlj;

        public string Gnlj
        {
            get { return gnlj; }
            set { gnlj = value; }
        }

        //所属目录
        private string ssml;

        public string Ssml
        {
            get { return ssml; }
            set { ssml = value; }
        }


    }
}