using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //专业
    public class ZY
    {
        public ZY()
        {
            zybh= -1;
            xkbh= -1;
            zym= "";
            zyfzr= "";
        }
        private int zybh; //专业编号

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }
        private int xkbh; //学科编号

        public int Xkbh
        {
            get { return xkbh; }
            set { xkbh = value; }
        }
        private string zym; //专业名

        public string Zym
        {
            get { return zym; }
            set { zym = value; }
        }
        private string zyfzr; //专业负责人

        public string Zyfzr
        {
            get { return zyfzr; }
            set { zyfzr = value; }
        }

    }
}