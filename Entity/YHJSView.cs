using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //用户角色视图
    public class YHJSView
    {
        private string jsm; //角色名

        public string Jsm
        {
            get { return jsm; }
            set { jsm = value; }
        }
        private string mm; //密码

        public string Mm
        {
            get { return mm; }
            set { mm = value; }
        }
        private string xm; //姓名

        public string Xm
        {
            get { return xm; }
            set { xm = value; }
        }
        private int xb; //性别

        public int Xb
        {
            get { return xb; }
            set { xb = value; }
        }
        private string yhbh; //用户角色

        public string Yhbh
        {
            get { return yhbh; }
            set { yhbh = value; }
        }
        private int jsbh; //角色编号

        public int Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

    }
}