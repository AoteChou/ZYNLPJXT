using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //一级指标
    public class YJZB
    {
        public YJZB()
        {
            yjzbbh= -1;
            yjzbmc= "";
        }
        private int yjzbbh; //一级指标编号

        public int Yjzbbh
        {
            get { return yjzbbh; }
            set { yjzbbh = value; }
        }
        private string yjzbmc; //一级指标名称

        public string Yjzbmc
        {
            get { return yjzbmc; }
            set { yjzbmc = value; }
        }

    }
}