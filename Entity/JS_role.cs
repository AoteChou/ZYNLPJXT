using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //角色
    public class JS_role
    {

        /// <summary>
        /// 新增角色实体时使用的构造函数。因为角色的主键是自增，无需设置。该构造函数默认设置编号值为-1.
        /// </summary>
        public JS_role(string _jsmc) {
            this.Jsm = _jsmc;
            this.Jsbh = -1;
        }
        
        /// <summary>
        /// 默认构造函数。默认构造函数会将实体类的字段设置为默认值。数字默认值-1，字符默认值null，bool默认值为smallint类型的-1
        /// </summary>
        public JS_role() {
            this.Jsbh = -1;
            this.Jsm = "";
        }
        
        /// <summary>
        /// 从数据库读取数据时使用的构造函数。因为数据库中已经存在了自增后的主键和名称，可以填充所有字段。
        /// </summary>
        public JS_role(int _jsbh, string _jsmc) {
            this.Jsbh = _jsbh;
            this.Jsm = _jsmc;
        }

        //角色编号
        private int jsbh;

        public int Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

        //角色名称
        private string jsm;

        public string Jsm
        {
            get { return jsm; }
            set { jsm = value; }
        }
    }
}