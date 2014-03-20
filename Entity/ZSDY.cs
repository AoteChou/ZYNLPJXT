using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //知识单元
    public class ZSDY
    {
        private int zslybh; //知识领域编号

        public int Zslybh
        {
            get { return zslybh; }
            set { zslybh = value; }
        }
        private int zsdybh; //知识单元编号

        public int Zsdybh
        {
            get { return zsdybh; }
            set { zsdybh = value; }
        }
        private int ejzbbh; //二级指标编号

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }
        private string zsdymc; //知识单元名称

        public string Zsdymc
        {
            get { return zsdymc; }
            set { zsdymc = value; }
        }
        private string bz; //备注

        public string Bz
        {
            get { return bz; }
            set { bz = value; }
        }

    }
}