using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学科
    public class XK
    {
        public XK()
        {
          xkbh= -1;
          xybh= -1;
          xkfzr = "";
          xkmc= "";
        }
        private int xkbh; //学科编号

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }
        private int xybh; //学院编号

        public int Xybh
        {
            get { return xybh; }
            set { xybh = value; }
        }
        private string xkfzr; //教师编号

        public string Xkfzr
        {
            get { return xkfzr; }
            set { xkfzr = value; }
        }
        private string xkmc; //学科名称

        public string Xkmc
        {
            get { return xkmc; }
            set { xkmc = value; }
        }

    }
}