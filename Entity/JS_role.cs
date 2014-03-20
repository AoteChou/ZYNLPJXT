using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //角色
    public class JS_role
    {
        //教师编号
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