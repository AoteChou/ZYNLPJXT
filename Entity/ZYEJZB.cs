using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //专业二级指标
    public class ZYEJZB
    {
        public ZYEJZB()
        {
            ejzbbh= -1;
            zybh= -1;
            nlyq= -1;
        }
        private int ejzbbh; //二级指标编号

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }
        private int zybh; //专业编号

        public int Zybh
        {
            get { return zybh; }
            set { zybh = value; }
        }
        private int nlyq; //能力要求

        public int Nlyq
        {
            get { return nlyq; }
            set { nlyq = value; }
        }
    }
}