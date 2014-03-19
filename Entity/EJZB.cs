using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //二级指标
    public class EJZB
    {
        //二级指标编号
        private int ejzbbh;

        public int Ejzbbh
        {
            get { return ejzbbh; }
            set { ejzbbh = value; }
        }

        //一级指标编号
        private int yjzbbh;

        public int Yjzbbh
        {
            get { return yjzbbh; }
            set { yjzbbh = value; }
        }

        //二级指标名称
        private string ejzbmc;

        public string Ejzbmc
        {
            get { return ejzbmc; }
            set { ejzbmc = value; }
        }


    }
}