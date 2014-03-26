using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //班级
    public class BJ
    {
        /// <summary>
        /// 默认构造函数。所有字段赋值为默认值.datetime的默认值为1000/1/1
        /// </summary>
        public BJ() {
            this.Bjbh = -1;
            this.Bjmc = "";
            this.Njbh = -1;
            this.Rxnf = DateTime.Parse("1753/1/1");
            this.Zybh = -1;
        }


        /// <summary>
        /// 构造函数.在使用数据访问层的insert函数使用本构造函数。update和get函数使用有bjbh的构造函数
        /// </summary>
        public BJ(string _bjmc, int _njbh, DateTime _rxnf, int _zybh)
        {
            this.Bjbh = -1;
            this.Bjmc = _bjmc;
            this.Njbh = _njbh;
            this.Rxnf = _rxnf;
            this.Zybh = _zybh;
        }


        /// <summary>
        /// 构造函数.在使用数据库访问层的get和update函数使用本构造函数。insert函数使用无bjbh的构造函数
        /// </summary>
        public BJ(int _bjbh,string _bjmc,int _njbh,DateTime _rxnf,int _zybh) {
            this.Bjbh = _bjbh;
            this.Bjmc = _bjmc;
            this.Njbh = _njbh;
            this.Rxnf = _rxnf;
            this.Zybh = _zybh;
        }


        //班级编号
        private int bjbh;

        public int Bjbh
        {
            get { return bjbh; }
            set { bjbh = value; }
        }

        //年级编号
        private int njbh;

        public int Njbh
        {
            get { return njbh; }
            set { njbh = value; }
        }

        //专业编号
        private int zybh;

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }

        //班级名称
        private string bjmc;

        public string Bjmc
        {
            get { return bjmc; }
            set { bjmc = value; }
        }

        //入学年份
        private DateTime rxnf;

        public DateTime Rxnf
        {
            get { return rxnf; }
            set { rxnf = value; }
        }

    }
}