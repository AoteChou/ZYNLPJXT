using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //学院
    public class XY
    {
        public XY()
        {
            xybh= -1;
            xymc= "";
        }
        private int xybh; //学院编号 

        public int Xybh
        {
            get { return xybh; }
            set { xybh = value; }
        }
        private string xymc; //学院名称

        public string Xymc
        {
            get { return xymc; }
            set { xymc = value; }
        }


    }
}