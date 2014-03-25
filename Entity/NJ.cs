using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //年级
    public class NJ
    {
        /// <summary>
        /// 新增年级时使用的构造函数。因为年级的主键是自增，无需设置。该构造函数默认设置编号值为-1.
        /// </summary>
        /// <param name="njmc">年级名称</param>
        public NJ(string _njmc) {
            this.Njmc = _njmc;
            this.Njbh = -1;
        }

        
        public NJ() { }
        
        /// <summary>
        /// 从数据库读取数据时使用的构造函数。因为数据库中已经存在了自增后的主键和名称，可以填充所有字段。
        /// </summary>
        /// <param name="_njbh">年级编号</param>
        /// <param name="_njmc">年级名称</param>
        public NJ(int _njbh, string _njmc) {
            this.Njbh = _njbh;
            this.Njmc = _njmc;
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