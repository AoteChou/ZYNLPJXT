using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //角色功能表
    public class JSGNB
    {
        //角色编号
        private int jsbh;

        public int Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

        //功能编号
        private int gnbh;

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }
    }
}