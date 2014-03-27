using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //用户功能表
    public class YHGNB
    {
        public YHGNB()
        {
            gnbh= -1;
            yhbh= "";
        }
        private int gnbh; //功能编号

        public int Gnbh
        {
            get { return gnbh; }
            set { gnbh = value; }
        }
        private string yhbh; //用户编号

        public string Yhbh
        {
            get { return yhbh; }
            set { yhbh = value; }
        }

    }
}