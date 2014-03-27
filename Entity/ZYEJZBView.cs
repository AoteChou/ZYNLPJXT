using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    /// <summary>
    /// 专业二级指标视图
    /// </summary>
    public class ZYEJZBView
    {
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
        private int yjzbbh; //一级指标编号

        public int Yjzbbh
        {
            get { return yjzbbh; }
            set { yjzbbh = value; }
        }
        private string ejzbmc; //二级指标名称

        public string Ejzbmc
        {
            get { return ejzbmc; }
            set { ejzbmc = value; }
        }
        private int ejzbbh; //二级指标编号

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }
        private int nlyq; //能力要求

        public int Nlyq
        {
            get { return nlyq; }
            set { nlyq = value; }
        }
  
    }
}