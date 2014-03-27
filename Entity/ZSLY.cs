using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //知识领域
    public class ZSLY
    {
        public ZSLY()
        {
            zslybh= -1;
            zslymc= "";
            bz= "";
        }
        private int zslybh; //知识领域编号

        public int Zslybh
        {
            get { return zslybh; }
            set { zslybh = value; }
        }
        private string zslymc; //知识领域名称

        public string Zslymc
        {
            get { return zslymc; }
            set { zslymc = value; }
        }
        private string bz; //备注

        public string Bz
        {
            get { return bz; }
            set { bz = value; }
        }

    }
}