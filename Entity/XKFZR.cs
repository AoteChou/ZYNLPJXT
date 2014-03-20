using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学科负责人
    public class XKFZR
    {
        private int xkbh; //学科编号

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }
        private string jsbh; //教师编号

        public string Jsbh
        {
            get { return jsbh; }
            set { jsbh = value; }
        }

    }
}