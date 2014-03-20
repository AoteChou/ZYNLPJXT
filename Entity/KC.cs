using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZYNLPJXT.Entity
{
    //课程
    public class KC
    {
        //课程编号
        private int kcbh;

        public int Kcbh
        {
            get { return kcbh; }
            set { kcbh = value; }
        }

        //课程简介
        private string kcjj;

        public string Kcjj
        {
            get { return kcjj; }
            set { kcjj = value; }
        }

        //课程名称
        private string kcmc;

        public string Kcmc
        {
            get { return kcmc; }
            set { kcmc = value; }
        }
    }
}