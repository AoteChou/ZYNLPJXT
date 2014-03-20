using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //用户角色表
    public class YHJSB
    {
        private string yhbh; //用户编号

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