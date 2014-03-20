using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //知识点
    public class ZSD
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
        private int zsdbh; //知识点编号

        public int Zsdbh
        {
            get { return zsdbh; }
            set { zsdbh = value; }
        }
        private string zsdmc; //知识点名称

        public string Zsdmc
        {
            get { return zsdmc; }
            set { zsdmc = value; }
        }
        private string bz; //备注

        public string Bz
        {
            get { return bz; }
            set { bz = value; }
        }

    }
}